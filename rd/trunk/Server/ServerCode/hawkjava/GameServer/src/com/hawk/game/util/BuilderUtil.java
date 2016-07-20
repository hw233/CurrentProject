package com.hawk.game.util;

import java.util.Map;
import java.util.Map.Entry;

import org.hawk.os.HawkTime;

import com.hawk.game.entity.EquipEntity;
import com.hawk.game.entity.ItemEntity;
import com.hawk.game.entity.MailEntity;
import com.hawk.game.entity.MonsterEntity;
import com.hawk.game.entity.PlayerEntity;
import com.hawk.game.entity.StatisticsEntity;
import com.hawk.game.item.AwardItems;
import com.hawk.game.item.GemInfo;
import com.hawk.game.protocol.Attribute.Attr;
import com.hawk.game.protocol.Const;
import com.hawk.game.protocol.Equip.EquipInfo;
import com.hawk.game.protocol.Equip.GemPunch;
import com.hawk.game.protocol.Item.ItemInfo;
import com.hawk.game.protocol.Mail.HSMail;
import com.hawk.game.protocol.Monster.HSMonster;
import com.hawk.game.protocol.Statistics.HSStatisticsInfoSync;
import com.hawk.game.protocol.Player.PlayerInfo;
import com.hawk.game.protocol.Skill.HSSkill;
import com.hawk.game.protocol.Statistics.InstanceState;

public class BuilderUtil {

	/**
	 * 生成玩家协议同步信息
	 * 
	 * @return
	 */
	public static PlayerInfo.Builder genPlayerBuilder(PlayerEntity playerEntity) {
		PlayerInfo.Builder builder = PlayerInfo.newBuilder();
		builder.setPlayerId(playerEntity.getId());
		builder.setNickname(playerEntity.getNickname());
		builder.setGold(playerEntity.getGold());
		builder.setCoin(playerEntity.getCoin());
		builder.setExp(playerEntity.getExp());
		builder.setCareer(playerEntity.getCareer());
		builder.setLevel(playerEntity.getLevel());
		builder.setGender(playerEntity.getLevel());
		builder.setEye(playerEntity.getExp());
		builder.setHair(playerEntity.getHair());
		builder.setHairColor(playerEntity.getHairColor());
		builder.addAllBattleMonster(playerEntity.getBattleMonsterList());
		builder.setRecharge(playerEntity.getRecharge());
		builder.setVipLevel(playerEntity.getVipLevel());
		return builder;
	}

	public static HSStatisticsInfoSync.Builder genStatisticsBuilder(StatisticsEntity statisticsEntity) {
		HSStatisticsInfoSync.Builder builder = HSStatisticsInfoSync.newBuilder();

		for (Entry<String, Integer> entry : statisticsEntity.getInstanceStarMap().entrySet()) {
			InstanceState.Builder instanceState = InstanceState.newBuilder();
			instanceState.setInstanceId(entry.getKey());
			instanceState.setStar(entry.getValue());
			instanceState.setCountDaily(statisticsEntity.getInstanceCountDaily(entry.getKey()));

			builder.addInstanceState(instanceState);
		}

		builder.setSkillPoint(statisticsEntity.getSkillPoint());
		builder.setSkillPointTimeStamp((int)(statisticsEntity.getSkillPointBeginTime().getTimeInMillis() / 1000));
		builder.setTimeStamp(HawkTime.getSeconds());

		return builder;
	}

	public static HSMonster.Builder genMonsterBuilder(MonsterEntity monsterEntity) {
		HSMonster.Builder builder = HSMonster.newBuilder();
		builder.setMonsterId(monsterEntity.getId());
		builder.setCfgId(monsterEntity.getCfgId());
		builder.setStage(monsterEntity.getStage());
		builder.setLevel(monsterEntity.getLevel());
		builder.setExp(monsterEntity.getExp());
		builder.setLazy(monsterEntity.getLazy());
		builder.setLazyExp(monsterEntity.getLazyExp());
		builder.setDisposition(monsterEntity.getDisposition());

		HSSkill.Builder skill = HSSkill.newBuilder();
		for (Entry<String, Integer> entry : monsterEntity.getSkillMap().entrySet()) {
			skill.setSkillId(entry.getKey());
			skill.setLevel(entry.getValue());
			builder.addSkill(skill);
		}
		return builder;
	}

	/**
	 * 生成物品实体的builder信息
	 * 
	 * @return
	 */
	public static ItemInfo.Builder genItemBuilder(ItemEntity itemEntity) {
		ItemInfo.Builder builder = ItemInfo.newBuilder();
		builder.setId(itemEntity.getId());
		builder.setItemId(itemEntity.getItemId());
		builder.setCount(itemEntity.getCount());
		builder.setStatus(itemEntity.getStatus());
		return builder;
	}

	/**
	 * 生成装备实体的builder信息
	 * 
	 * @return
	 */
	public static EquipInfo.Builder genEquipBuilder(EquipEntity equipEntity) {
		EquipInfo.Builder builder = EquipInfo.newBuilder();
		//组装基本数据
		builder.setId(equipEntity.getId());
		builder.setEquipId(equipEntity.getItemId());
		builder.setStage(equipEntity.getStage());
		builder.setLevel(equipEntity.getLevel());
		builder.setStatus(0);
		if (equipEntity.getExpireTime() != null) {
			builder.setExpireTime((int)equipEntity.getExpireTime().getTimeInMillis() / 1000);
		}

		//组装镶嵌宝石数据
		for (GemInfo element : equipEntity.GetGemDressList()) {
			GemPunch.Builder punchInfo = GemPunch.newBuilder();
			punchInfo.setType(element.getType());
			punchInfo.setGemItemId(element.getGemId());
			builder.addGemItems(punchInfo.build());
		}

		if (equipEntity.getAttr() != null) {
			//组装生成附加属性列表
			for (Map.Entry<Const.attr, Float> entry : equipEntity.getAttr().getAttrMap().entrySet()) {
				Attr.Builder attrInfo = Attr.newBuilder();
				attrInfo.setAttrId(entry.getKey().getNumber());
				attrInfo.setAttrValue(entry.getValue());
				builder.addAttrDatas(attrInfo);
			}
		}
		return builder;
	}

	public static HSMail.Builder genMailBuilder(MailEntity mailEntity) {
		HSMail.Builder builder = HSMail.newBuilder();
		builder.setMailId(mailEntity.getId());
		builder.setState(mailEntity.getState());
		builder.setSendTimeStamp((int)(mailEntity.getCreateTime().getTimeInMillis() / 1000));
		builder.setSenderId(mailEntity.getSenderId());
		builder.setSenderName(mailEntity.getSenderName());
		builder.setSubject(mailEntity.getSubject());
		builder.setContent(mailEntity.getContent());
		AwardItems convetor = AwardItems.valueOf(mailEntity.getRewardList());
		builder.addAllReward(convetor.getBuilder().getRewardItemsList());
		return builder;
	}
}
