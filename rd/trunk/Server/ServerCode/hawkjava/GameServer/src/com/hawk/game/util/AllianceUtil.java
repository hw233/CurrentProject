package com.hawk.game.util;

import java.util.Comparator;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

import org.hawk.os.HawkTime;

import com.hawk.game.config.SociatyTechnologyCfg;
import com.hawk.game.entity.AllianceApplyEntity;
import com.hawk.game.entity.AllianceEntity;
import com.hawk.game.entity.AllianceTeamEntity;
import com.hawk.game.entity.PlayerAllianceEntity;
import com.hawk.game.protocol.Alliance.AllianceApply;
import com.hawk.game.protocol.Alliance.AllianceInfo;
import com.hawk.game.protocol.Alliance.AllianceMember;
import com.hawk.game.protocol.Alliance.AllianceTaskInfo;
import com.hawk.game.protocol.Alliance.AllianceTeamInfo;
import com.hawk.game.protocol.Alliance.AllianceTeamMemInfo;
import com.hawk.game.protocol.Alliance.AllianceTeamQuestInfo;
import com.hawk.game.protocol.Alliance.HSAllianceApplyListRet;
import com.hawk.game.protocol.Alliance.HSAllianceMembersRet;
import com.hawk.game.protocol.Alliance.HSAllianceSelfTeamRet;
import com.hawk.game.protocol.Alliance.HSAllianceTeamListRet;

public class AllianceUtil {

	/**
	 * 检测公会名称是否合法
	 * @param name
	 * @return
	 */
	public static boolean checkName(String name) {  
		String regEx = "^[0-9A-Za-z\u4e00-\u9fa5]{2,6}$";
		Pattern pat = Pattern.compile(regEx);  
		Matcher mat = pat.matcher(name);  
		return mat.find();     
    }
	
	/**
	 * 公会排行比较器
	 */
	public final static Comparator<AllianceEntity> SORTALLIANCE = new Comparator<AllianceEntity>() {
		@Override
		public int compare(AllianceEntity o1, AllianceEntity o2) {
			if(o1.getId() == o2.getId()) return 0;
			if (o1.getLevel() < o2.getLevel()) {
				return 1;
			} else if (o1.getLevel() == o2.getLevel()) {
				if (o1.getContribution() == o2.getContribution()) {
					if (o1.getId() > o2.getId())
						return 1;
					else 
						return -1;
				}
				if (o1.getContribution() < o2.getContribution()) {
					return 1;
				} else {
					return -1;
				}
			} else {
				return -1;
			}
		}
	};
	
	/**
	 * 检查工会通告
	 * @param name
	 * @return
	 */	
	public static boolean checkNotice(String name) {  
		return name.length() <= GsConst.Alliance.NOTICE_MAX_LENGTH;     
      }
	
	/**
	 * 检查是否是工会Id
	 * @param name
	 * @return
	 */
	public static boolean isAllianceId(String str){ 
	    Pattern pattern = Pattern.compile("[0-9]*"); 
	    return pattern.matcher(str).matches();    
	 } 

	/**
	 * 构造公会信息回复协议
	 * @param allianceEntity
	 * @param playerId
	 * @param remGold
	 * @return
	 */
	public static AllianceInfo.Builder getAllianceInfo(AllianceEntity allianceEntity){	
		AllianceInfo.Builder builder = AllianceInfo.newBuilder();
		builder.setId(allianceEntity.getId());
		builder.setLevel(allianceEntity.getLevel());
		builder.setCurrentPop(allianceEntity.getMemberList().size());
		builder.setMaxPop(SociatyTechnologyCfg.getMemberPop(allianceEntity.getMemLevel()));
		builder.setContribution(allianceEntity.getContribution());
		builder.setContributionToday(allianceEntity.getContribution0());
		builder.setContribution3Day(allianceEntity.get3DaysContribution());
		builder.setNotice(allianceEntity.getNotice());
		builder.setExpLevel(allianceEntity.getExpLevel());
		builder.setMemLevel(allianceEntity.getMemLevel());
		builder.setCoinLevel(allianceEntity.getCoinLevel());
		builder.setName(allianceEntity.getName());
		builder.setAutoAccept(allianceEntity.isAutoAccept());
		builder.setMinLevel(allianceEntity.getMinLevel());
		return builder;
	}

	/**
	 * 获取成员数据
	 * @param allianceId
	 * @param player
	 * @return
	 */
	public static AllianceMember.Builder getMemberInfo(PlayerAllianceEntity playerAllianceEntity, PlayerAllianceEntity selfEntity) {
		AllianceMember.Builder builder = AllianceMember.newBuilder();
		builder.setLevel(playerAllianceEntity.getLevel());
		builder.setName(playerAllianceEntity.getName());
		builder.setBattlePoint(0);
		builder.setContribution(playerAllianceEntity.getContribution());
		builder.setPostion(playerAllianceEntity.getPostion());
		builder.setId(playerAllianceEntity.getPlayerId());
		builder.setPrayCount(playerAllianceEntity.getFatigueCount());
		builder.setLoginTime(playerAllianceEntity.getLoginTime());
		builder.setLogoutTime(playerAllianceEntity.getLoginTime());
		if (selfEntity != null && selfEntity.getRefreshTime() > HawkTime.getSeconds() && selfEntity.getFatigueSet().contains(playerAllianceEntity.getPlayerId())) {
			builder.setSendFatigue(true);
		}
		else
		{
			builder.setSendFatigue(false);
		}
		return builder;
	}
	
	/**
	 * 构造公会成员回复协议
	 * @return 
	 */
	public static HSAllianceMembersRet.Builder getAllianceMembersInfo(AllianceEntity allianceEntity, PlayerAllianceEntity selfEntity, int filterId) {
		HSAllianceMembersRet.Builder builder = HSAllianceMembersRet.newBuilder();
		for (PlayerAllianceEntity eneity : allianceEntity.getMemberList().values()) {
			if (eneity.getPlayerId() != filterId) {
				builder.addMemberList(AllianceUtil.getMemberInfo(eneity, selfEntity));
			}
		}
		
		return builder;
	}
	
	/**
	 * 申请同步通知
	 * @param allianceId
	 * @param player
	 * @return
	 */
	public static AllianceApply.Builder getApplyNotify(AllianceApplyEntity applyEntity) {
		AllianceApply.Builder builder = AllianceApply.newBuilder();
		builder.setAllianceId(applyEntity.getAllianceId());
		builder.setPlayerId(applyEntity.getPlayerId());
		builder.setNickname(applyEntity.getName());
		builder.setLevel(applyEntity.getLevel());
		return builder;
	}
	
	/**
	 * 工会队伍列表
	 * @param allianceId
	 * @param player
	 * @return
	 */
	public static HSAllianceTeamListRet.Builder getTeamList(AllianceEntity allianceEntity) {
		HSAllianceTeamListRet.Builder builder = HSAllianceTeamListRet.newBuilder();
		for (AllianceTeamEntity teamEntity : allianceEntity.getUnfinishTeamList().values()) {
			builder.addAllianceTeams(getTeamInfo(teamEntity, allianceEntity, false));
		}
		return builder;
	}
	
	/**
	 * 工会队伍
	 * @param allianceId
	 * @param player
	 * @return
	 */
	public static AllianceTeamInfo.Builder getTeamInfo(AllianceTeamEntity teamEntity, AllianceEntity allianceEntity, boolean questInfo) {
		AllianceTeamInfo.Builder element = AllianceTeamInfo.newBuilder();
		element.setStartTime(teamEntity.getCreateTime());
		if (teamEntity.getCaptain() != 0) {
			AllianceTeamMemInfo.Builder member = getPlayerInfo(teamEntity.getCaptain(), allianceEntity);
			member.setIsCaptain(true);
			element.addMembers(member);
		}
		
		if (teamEntity.getMember1() != 0) {
			element.addMembers(getPlayerInfo(teamEntity.getMember1(), allianceEntity));
		}
		
		if (teamEntity.getMember2() != 0) {
			element.addMembers(getPlayerInfo(teamEntity.getMember2(), allianceEntity));
		}
		
		if (teamEntity.getMember3() != 0) {
			element.addMembers(getPlayerInfo(teamEntity.getMember3(), allianceEntity));
		}
		
		if (questInfo == true) {
			element.addQuestInfos(getTaskInfo(teamEntity.getItemQuest1PlayerId(), teamEntity.getItemQuest1(), teamEntity, allianceEntity));
			element.addQuestInfos(getTaskInfo(teamEntity.getItemQuest2PlayerId(), teamEntity.getItemQuest2(), teamEntity, allianceEntity));
			element.addQuestInfos(getTaskInfo(teamEntity.getItemQuest3PlayerId(), teamEntity.getItemQuest3(), teamEntity, allianceEntity));
			element.addQuestInfos(getTaskInfo(teamEntity.getCoinQuest1PlayerId(), teamEntity.getCoinQuest1(), teamEntity, allianceEntity));
			element.addQuestInfos(getTaskInfo(teamEntity.getCoinQuest2PlayerId(), teamEntity.getCoinQuest2(), teamEntity, allianceEntity));
			element.addQuestInfos(getTaskInfo(teamEntity.getInstanceQuest1PlayerId(), teamEntity.getInstanceQuest1(), teamEntity, allianceEntity));
		}
		
		return element;
	}
	
	/**
	 * 工会任务信息
	 * @param allianceId
	 * @param player
	 * @return
	 */
	public static AllianceTeamQuestInfo.Builder getTaskInfo(int playerId, int questId, AllianceTeamEntity teamEntity, AllianceEntity allianceEntity){
		AllianceTeamQuestInfo.Builder questBuilder = AllianceTeamQuestInfo.newBuilder();
		questBuilder.setQuestId(questId);
		questBuilder.setPlayerId(playerId);
		if (playerId != 0 && !isMemberInTeam(playerId, teamEntity) ) {
			PlayerAllianceEntity playerEntity = allianceEntity.getMember(teamEntity.getItemQuest1PlayerId());
			if (playerEntity != null) {
				questBuilder.setNickname(playerEntity.getName());
				questBuilder.setLevel(playerEntity.getLevel());
				questBuilder.setAvatar(0);
			}	
			else {
				questBuilder.setPlayerId(-1);
			}
		}	
		return questBuilder;
	}
	
	
	/**
	 * 工会队伍队员
	 * @param allianceId
	 * @param player
	 * @return
	 */
	public static AllianceTeamMemInfo.Builder getPlayerInfo(int playerId, AllianceEntity allianceEntity) {
		AllianceTeamMemInfo.Builder member = AllianceTeamMemInfo.newBuilder();
		PlayerAllianceEntity playerEntity = allianceEntity.getMember(playerId);
		if (playerEntity != null) {
			member.setPlayerId(playerId);
			member.setNickname(playerEntity.getName());
			member.setLevel(playerEntity.getLevel());
			member.setAvatar(0);
			member.setIsCaptain(false);
		}	
		return member;
	}
	
	/**
	 * 所有队伍
	 * @param allianceId
	 * @param player
	 * @return
	 */
	public static HSAllianceApplyListRet.Builder getApplyList(AllianceEntity allianceEntity) {
		HSAllianceApplyListRet.Builder builder = HSAllianceApplyListRet.newBuilder();
		for (AllianceApplyEntity applyEntity : allianceEntity.getApplyList().values()) {
			builder.addApply(getApplyNotify(applyEntity));
		}
		return builder;
	}
	
	/**
	 * 工会任务信息
	 * @param allianceId
	 * @param player
	 * @return
	 */
	public static AllianceTaskInfo.Builder getAllianceTaskInfo(AllianceTeamEntity teamEntity) {
		AllianceTaskInfo.Builder builder = AllianceTaskInfo.newBuilder();
		builder.addItemTask(teamEntity.getItemQuest1());
		builder.addItemTask(teamEntity.getItemQuest2());
		builder.addItemTask(teamEntity.getItemQuest3());
		builder.addCoinTask(teamEntity.getCoinQuest1());
		builder.addCoinTask(teamEntity.getCoinQuest2());
		builder.addInstanceTask(teamEntity.getInstanceQuest1());
		return builder;
	}
	
	/**
	 * 自身组队信息
	 * @param allianceId
	 * @param player
	 * @return
	 */
	public static HSAllianceSelfTeamRet.Builder getSelfTeamInfo(AllianceTeamEntity teamEntity, AllianceEntity allianceEntity) {
		HSAllianceSelfTeamRet.Builder builder = HSAllianceSelfTeamRet.newBuilder();
		builder.setSelfTeam(getTeamInfo(teamEntity, allianceEntity, true));
		return builder;
	}
	
	/**
	 * 自身组队信息
	 * @param allianceId
	 * @param player
	 * @return
	 */
	public static boolean isMemberInTeam(int playerId, AllianceTeamEntity teamEntity){
		if (teamEntity.getCaptain() != playerId && teamEntity.getMember1() != playerId && teamEntity.getMember2() != playerId && teamEntity.getMember3() != playerId) {
			return false;
		}
		
		return true;
	}
}
