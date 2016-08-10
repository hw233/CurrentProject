package com.hawk.game.log;

import net.sf.json.JSONObject;

import org.apache.log4j.Logger;
import org.hawk.os.HawkException;

import com.hawk.game.entity.PlayerEntity;
import com.hawk.game.player.Player;

/**
 * 行为日志
 * 
 * @author hawk
 * @date 2014-7-24
 */
public class BehaviorLogger {
	/**
	 * 日志源
	 * 
	 * @author hawk
	 * @date 2014-7-25
	 */
	public static enum Source {
		/**
		 * 用户操作
		 */
		USER_OPERATION,
		/**
		 * 系统操作
		 */
		SYS_OPERATION,
		/**
		 * GM操作
		 */
		GM_OPERATION,
		/**
		 * 怪物移除
		 */
		MONSTER_REMOVE,
		/**
		 * 怪物添加
		 */
		MONSTER_ADD,
		/**
		 * 装备移除
		 */
		EQUIP_REMOVE,
		/**
		 * 装备增加
		 */
		EQUIP_ADD,
		/**
		 * 道具移除
		 */
		ITEM_REMOVE,
		/**
		 * 道具增加
		 */
		ITEM_ADD,
		/**
		 * 玩家属性改变
		 */
		PLAYER_ATTR_CHANGE,
		/**
		 * 公会属性改变
		 */
		ALLIANCE_ATTR_CHANGE,
		/**
		 * 怪物属性改变
		 */
		MONSTER_ATTR_CHANGE,
		/**
		 * 游戏奖励
		 */
		GAME_SYS_REWARD,
		/**
		 * 未知源
		 */
		UNKNOWN_SOURCE;
	}

	/**
	 * 行为定义
	 * 
	 * @author hawk
	 * @date 2014-2-24
	 */
	public static enum Action {
		/**
		 * 无明显Action操作的行为
		 */
		NULL,
		/**
		 * 初始化数据
		 */
		INIT,
		/**
		 * 系统行为
		 */
		SYSTEM,
		/**
		 * 登录游戏
		 */
		LOGIN_GAME,
		/**
		 * 登出游戏
		 */
		LOGOUT_GAME,
		/**
		 * 每日重置
		 */
		DAILY_RESET,
		/**
		 * 创建角色
		 */
		CREATE_PLAYER,
		/**
		 * 购买道具
		 */
		ITEM_BUY,
		/**
		 * 使用道具
		 */
		ITEM_USE,
		/**
		 * 购买并使用道具
		 */
		ITEM_BUY_AND_USE,
		/**
		 * 出售道具
		 */
		ITEM_SELL,
		/**
		 * 购买装备
		 */
		EQUIP_BUY,
		/**
		 * 装备出售
		 */
		EQUIP_SELL,
		/**
		 * 装备进阶
		 */
		EQUIP_ADVANCE,
		/**
		 * 装备强化
		 */
		EQUIP_EHANCE,
		/**
		 * 装备打孔
		 */
		EQUIP_PUNCH,
		/**
		 * 宝石镶嵌
		 */
		EQUIP_GEM,
		/**
		 * 装备穿戴
		 */
		EQUIP_DRESS,
		/**
		 * 装备脱下
		 */
		EQUIP_UNDRESS,
		/**
		 * 装备替换
		 */
		EQUIP_REPLACE,
		/**
		 * 宠物分解
		 */
		MONSTER_DECOMPOSE,
		/**
		 * 宠物合成
		 */
		MONSTER_COMPOSE,
		/**
		 * 装备分解
		 */
		EQUIP_DECOMPOSE,
		/**
		 * 装备合成
		 */
		ITEM_COMPOSE,
		/**
		 * 宝石合成
		 */
		GEM_COMPOSE,
		/**
		 * 游戏奖励
		 */
		GAME_SYS_REWARD,
		/**
		 * 邮件奖励
		 */
		MAIL_REWARD,
		/**
		 * 创建邮件
		 */
		MAIL_CREATE,
		/**
		 * 邮件溢出
		 */
		MAIL_OVERFLOW,
		/**
		 * 开宝箱
		 */
		OPEN_TREASURE,
		/**
		 * 副本进入
		 */
		INSTANCE_ENTER,
		/**
		 * 副本结算
		 */
		INSTANCE_SETTLE,
		/**
		 * 副本复活
		 */
		INSTANCE_REVIVE,
		/**
		 * 副本扫荡
		 */
		INSTANCE_SWEEP,
		/**
		 * 副本重置
		 */
		INSTANCE_RESET,
		/**
		 * 章节宝箱
		 */
		CHAPTER_BOX,
		/**
		 * 洞进入
		 */
		HOLE_ENTER,
		/**
		 * 塔进入
		 */
		TOWER_ENTER,
		/**
		 * 公会副本进入
		 */
		GUILD_INSTANCE_ENTER,
		/**
		 * 任务交付
		 */
		QUEST_SUBMIT,
		/**
		 * 技能升级
		 */
		SKILL_UP,
		/**
		 * 宠物进阶
		 */
		STAGE_UP,
		/**
		 * 公会祈福
		 */
		ALLIANCE_PRAY,
		/**
		 * 商店物品购买
		 */
		SHOP_ITEM_BUY,	
		/**
		 * 商店物品刷新
		 */
		SHOP_REFRESH,
		/**
		 * 钻石兑换金币
		 */
		SHOP_GOLD2COIN,	
		/**
		 * 充值
		 */
		SHOP_RECHARGE,	
		/**
		 * 公会创建
		 */
		ALLIANCE_CREATE_CONSUME,
		/**
		 * 公会大任务消耗
		 */
		ALLIANCE_TASK_CONSUME,
		/**
		 * 公会小任务消耗
		 */
		ALLIANCE_QUEST_CONSUME,
		/**
		 * 解散工会队伍奖励
		 */
		ALLIANCE_DISSOLVE_TEAM_REWARD,
		/**
		 * 解散每日贡献值奖励
		 */
		ALLIANCE_CONTRIBUTION_REWARD,
		/**
		 * 公会小任务奖励
		 */
		ALLIANCE_QUEST_REWARD,
		/**
		/**
		 * 公会大任务消耗
		 */
		ALLIANCE_TASK_REWARD,
		/**
		/**
		 * gm
		 */
		GM_ACTION,
		/**
		 * 未知行为
		 */
		UNKONWN_ACTION;

		/**
		 * 行为名
		 */
		private String actionName;

		/**
		 * 获取行为名
		 * 
		 * @return
		 */
		public String getActionName() {
			return actionName;
		}

		/**
		 * 构造函数
		 */
		private Action() {
			this("");
		}

		/**
		 * 构造函数
		 */
		private Action(String value) {
			this.actionName = value;
		}
	}

	/**
	 * 日志参数
	 * 
	 * @author hawk
	 * @date 2014-7-24
	 */
	public static class Params {
		private String name;
		private Object value;

		public static final String AFTER = "after";

		public static final String COST = "cost";

		public static Params valueOf(String name, Object value) {
			Params params = new Params();
			params.setName(name);
			params.setValue(value);
			return params;
		}

		public String getName() {
			return name;
		}

		public void setName(String name) {
			this.name = name;
		}

		public Object getValue() {
			return value;
		}

		public void setValue(Object value) {
			this.value = value;
		}
	}

	/**
	 * GM日志记录器
	 */
	private static final Logger GM_LOGGER = Logger.getLogger("GM");
	/**
	 * 行为日志，数据流变化日志记录器
	 */
	private static final Logger ACTION_LOGGER = Logger.getLogger("Action");
	/**
	 * 统计平台日志记录器
	 */
	private static final Logger PLATFORM_LOGGER = Logger.getLogger("Platform");
	
	/**
	 * 用于数据平台统计的日志输出
	 * 
	 * @param player
	 * @param action
	 * @param params
	 */
/*	public static void log4Platform(Player player, Action action, Params... params) {
		try {
			JSONObject jsonObject = new JSONObject();
			// 行为时间
			jsonObject.put("ts", HawkTime.getTimeString());
			// 平台用户Id
			jsonObject.put("puid", player.getPuid());
			// 设备Id
			jsonObject.put("device_id", player.getDevice());
			// 角色Id
			jsonObject.put("player_id", player.getId());
			// 场景，先留空
			jsonObject.put("scene", "scene");
			// 等级
			jsonObject.put("level", player.getLevel());
			// vip等级
			jsonObject.put("vip_level", player.getVipLevel());
			// 动作编号
			jsonObject.put("action", action.name());
			// 填充参数V1
			JSONObject paramsJsonObject = new JSONObject();
			for (Params param : params) {
				paramsJsonObject.put(param.getName(), param.getValue().toString());
			}
			jsonObject.put("v1", paramsJsonObject.toString());
			jsonObject.put("v2", "");
			jsonObject.put("v3", "");
			jsonObject.put("v4", "");

			// 渠道信息
			jsonObject.put("ip", player.getIp());
			jsonObject.put("gameid", GsConfig.getInstance().getGameId());
			jsonObject.put("server", GsConfig.getInstance().getPlatform() + "-" + GsConfig.getInstance().getServerId());
			jsonObject.put("store", player.getPlatform());
			// 手机信息
			jsonObject.put("phoneinfo", player.getPhoneInfo());

			PLATFORM_LOGGER.info(jsonObject.toString());
		} catch (Exception e) {
			HawkException.catchException(e);
		}
	}

	*//**
	 * 用于数据平台统计的日志输出
	 * 
	 * @param playerEntity
	 * @param action
	 * @param params
	 *//*
	public static void log4Platform(PlayerEntity playerEntity, Action action, Params... params) {
		try {
			JSONObject jsonObject = new JSONObject();
			// 行为时间
			jsonObject.put("ts", HawkTime.getTimeString());
			// 平台用户Id
			jsonObject.put("puid", playerEntity.getPuid());
			// 设备Id
			jsonObject.put("device_id", playerEntity.getDevice());
			// 角色Id
			jsonObject.put("player_id", playerEntity.getId());
			// 场景，先留空
			jsonObject.put("scene", "scene");
			// 等级
			jsonObject.put("level", playerEntity.getLevel());
			// vip等级
			jsonObject.put("vip_level", playerEntity.getVipLevel());
			// 动作编号
			jsonObject.put("action", action.name());
			// 填充参数V1
			JSONObject paramsJsonObject = new JSONObject();
			for (Params param : params) {
				paramsJsonObject.put(param.getName(), param.getValue().toString());
			}
			jsonObject.put("v1", paramsJsonObject.toString());
			jsonObject.put("v2", "");
			jsonObject.put("v3", "");
			jsonObject.put("v4", "");

			// 渠道信息
			jsonObject.put("ip", "");
			jsonObject.put("gameid", GsConfig.getInstance().getGameId());
			jsonObject.put("server", GsConfig.getInstance().getPlatform() + "-" + GsConfig.getInstance().getServerId());
			jsonObject.put("store", playerEntity.getPlatform());
			// 手机信息
			jsonObject.put("phoneinfo", playerEntity.getPhoneInfo());

			PLATFORM_LOGGER.info(jsonObject.toString());
		} catch (Exception e) {
			HawkException.catchException(e);
		}
	}
*/
	/**
	 * 数据流统计，主要用户客服问题查询
	 * 
	 * @param player
	 * @param source
	 * @param action
	 */
	public static void log4Service(Player player, Source source, Action action, Params... params) {
		try {
			JSONObject jsonObject = new JSONObject();
			// 行为时间
			jsonObject.put("puid", player.getPuid());
			jsonObject.put("playerId", player.getId());
			jsonObject.put("playerName", player.getName());
			jsonObject.put("source", source.name());
			jsonObject.put("action", action.name());

			JSONObject paramsJsonObject = new JSONObject();
			for (Params param : params) {
				paramsJsonObject.put(param.getName(), param.getValue().toString());
			}
			jsonObject.put("data", paramsJsonObject);

			ACTION_LOGGER.info(jsonObject.toString());
		} catch (Exception e) {
			HawkException.catchException(e);
		}
	}
	
	/**
	 * 数据流统计，主要用户客服问题查询
	 * 
	 * @param player
	 * @param source
	 * @param action
	 */
	public static void log4Service(PlayerEntity playerEntity, Source source, Action action, Params... params) {
		try {
			JSONObject jsonObject = new JSONObject();
			// 行为时间
			jsonObject.put("puid", playerEntity.getPuid());
			jsonObject.put("playerId", playerEntity.getId());
			jsonObject.put("playerName", playerEntity.getNickname());
			jsonObject.put("source", source.name());
			jsonObject.put("action", action.name());

			JSONObject paramsJsonObject = new JSONObject();
			for (Params param : params) {
				paramsJsonObject.put(param.getName(), param.getValue().toString());
			}
			jsonObject.put("data", paramsJsonObject);

			ACTION_LOGGER.info(jsonObject.toString());
		} catch (Exception e) {
			HawkException.catchException(e);
		}
	}

	/**
	 * 以玩家id为key统计
	 * 
	 * @param playerId
	 * @param source
	 * @param action
	 * @param params
	 */
	public static void log4Service(int playerId, Source source, Action action, Params... params) {
		try {
			JSONObject jsonObject = new JSONObject();
			// 行为时间
			jsonObject.put("playerId", playerId);
			jsonObject.put("source", source.name());
			jsonObject.put("action", action.name());

			JSONObject paramsJsonObject = new JSONObject();
			for (Params param : params) {
				paramsJsonObject.put(param.getName(), param.getValue().toString());
			}
			jsonObject.put("data", paramsJsonObject);

			ACTION_LOGGER.info(jsonObject.toString());
		} catch (Exception e) {
			HawkException.catchException(e);
		}
	}

	/**
	 * GM统计，主要记录GM操作
	 * 
	 * @param user
	 * @param source
	 * @param action
	 */
	public static void log4GM(String user, Source source, Action action, Params... params) {
		try {
			JSONObject jsonObject = new JSONObject();
			// 行为时间
			jsonObject.put("user", user);
			jsonObject.put("source", source.name());
			jsonObject.put("action", action.name());

			JSONObject paramsJsonObject = new JSONObject();
			for (Params param : params) {
				paramsJsonObject.put(param.getName(), param.getValue().toString());
			}
			jsonObject.put("data", paramsJsonObject);

			GM_LOGGER.info(jsonObject.toString());
		} catch (Exception e) {
			HawkException.catchException(e);
		}
	}

}
