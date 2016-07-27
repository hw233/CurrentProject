package com.hawk.game.config;

import java.util.LinkedList;
import java.util.List;

import org.hawk.config.HawkConfigBase;
import org.hawk.config.HawkConfigManager;

import com.hawk.game.item.ItemInfo;
import com.hawk.game.protocol.Const.equipPart;
import com.hawk.game.util.GsConst.ItemParseType;

@HawkConfigManager.CsvResource(file = "staticData/equipForge.csv", struct = "list")
public class EquipForgeCfg extends HawkConfigBase {
	/**
	 * 级别
	 */
	@Id
	protected final String stageLevel;
	/**
	 * 成功率
	 */
	protected final float successRate;
	/**
	 * 等级限制
	 */
	protected final int playerlevelDemand;
	/**
	 * 升级消耗列表
	 */
	protected final String levelDemand;	
	/**
	 * 打孔消耗列表
	 */
	protected final String punchDemand;	
	/**
	 * 升级消耗
	 */
	private List<ItemInfo> levelDemandList;
	/**
	 * 升级消耗
	 */
	private List<ItemInfo> punchDemandList;
	
	public  EquipForgeCfg() {
		stageLevel = null;
		successRate = .0f;
		playerlevelDemand = 0;
		levelDemand = null;
		punchDemand = null;
		levelDemandList = new LinkedList<ItemInfo>();
		punchDemandList = new LinkedList<ItemInfo>();
	}
	
	public String getStageLevel() {
		return stageLevel;
	}

	public float getSuccessRate() {
		return successRate;
	}

	public int getPlayerlevelDemand() {
		return playerlevelDemand;
	}

	public String getLevelDemand() {
		return levelDemand;
	}

	public String getPunchDemand() {
		return punchDemand;
	}

	public List<ItemInfo> getLevelDemandList() {
		return levelDemandList;
	}

	public List<ItemInfo> getPunchDemandList() {
		return punchDemandList;
	}

	@Override
	protected boolean assemble() {
		levelDemandList.clear();
		punchDemandList.clear();
		if (levelDemand != null && levelDemand.length() > 0 && !"0".equals(levelDemand)) {
			levelDemandList = ItemInfo.GetItemInfo(levelDemand, ItemParseType.PARSE_EQUIP_ATTR);
		}
				
		if (punchDemand != null && punchDemand.length() > 0 && !"0".equals(punchDemand)) {
			punchDemandList = ItemInfo.GetItemInfo(punchDemand, ItemParseType.PARSE_EQUIP_ATTR);
		}	
		
		return true;
	} 
	
	@Override
	protected boolean checkValid() {
		return true;
	}
	
	public static List<ItemInfo> getLevelDemandList(int stage, int level)
	{
		EquipForgeCfg equipForgeCfg = HawkConfigManager.getInstance().getConfigByIndex(EquipForgeCfg.class, (stage - 1) * 10 + level);
		if (equipForgeCfg != null) {
			return equipForgeCfg.getLevelDemandList();
		}
		return null;
	}
	
	public static List<ItemInfo> getPunchDemandList(int stage, int level)
	{
		EquipForgeCfg equipForgeCfg = HawkConfigManager.getInstance().getConfigByIndex(EquipForgeCfg.class, (stage - 1) * 10 + level );
		if (equipForgeCfg != null) {
			return equipForgeCfg.getPunchDemandList();
		}
		return null;
	}
	
	public static float getSuccessRate(int stage, int level)
	{
		EquipForgeCfg equipForgeCfg = HawkConfigManager.getInstance().getConfigByIndex(EquipForgeCfg.class, (stage - 1) * 10 + level);
		if (equipForgeCfg != null) {
			return equipForgeCfg.successRate;
		}
		return 0;
	}
	
	public static int getPlayerLevelDemand(int stage, int level)
	{
		EquipForgeCfg equipForgeCfg = HawkConfigManager.getInstance().getConfigByIndex(EquipForgeCfg.class, (stage - 1) * 10 + level);
		if (equipForgeCfg != null) {
			return equipForgeCfg.playerlevelDemand;
		}
		return 0;
	}
}
