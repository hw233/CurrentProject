//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Protocol/Status.proto
namespace PB
{
    [global::ProtoBuf.ProtoContract(Name=@"errorMask")]
    public enum errorMask
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"NORMAL_ERROR", Value=0)]
      NORMAL_ERROR = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"LOGIN_ERROR", Value=65536)]
      LOGIN_ERROR = 65536,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PLAYER_ERROR", Value=131072)]
      PLAYER_ERROR = 131072,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MONSTER_ERROR", Value=196608)]
      MONSTER_ERROR = 196608,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ITEM_ERROR", Value=262144)]
      ITEM_ERROR = 262144,
            
      [global::ProtoBuf.ProtoEnum(Name=@"QUEST_ERROR", Value=327680)]
      QUEST_ERROR = 327680,
            
      [global::ProtoBuf.ProtoEnum(Name=@"INSTANCE_ERROR", Value=393216)]
      INSTANCE_ERROR = 393216,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MAIL_ERROR", Value=458752)]
      MAIL_ERROR = 458752,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCE_ERROR", Value=524288)]
      ALLIANCE_ERROR = 524288,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SHOP_ERROR", Value=589824)]
      SHOP_ERROR = 589824,
            
      [global::ProtoBuf.ProtoEnum(Name=@"IM_ERROR", Value=655360)]
      IM_ERROR = 655360,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SETTING_ERROR", Value=720896)]
      SETTING_ERROR = 720896,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ADVENTURE_ERROR", Value=786432)]
      ADVENTURE_ERROR = 786432,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SUMMON_ERROR", Value=851968)]
      SUMMON_ERROR = 851968,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PVP_ERROR", Value=917504)]
      PVP_ERROR = 917504
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"error")]
    public enum error
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"NONE_ERROR", Value=0)]
      NONE_ERROR = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CONFIG_ERROR", Value=1)]
      CONFIG_ERROR = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ONLINE_MAX_LIMIT", Value=2)]
      ONLINE_MAX_LIMIT = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"REGISTER_MAX_LIMIT", Value=3)]
      REGISTER_MAX_LIMIT = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SERVER_GRAY_STATE", Value=4)]
      SERVER_GRAY_STATE = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DATA_BASE_ERROR", Value=5)]
      DATA_BASE_ERROR = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PARAMS_INVALID", Value=6)]
      PARAMS_INVALID = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CONFIG_NOT_FOUND", Value=7)]
      CONFIG_NOT_FOUND = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UNSUPPORT_ACTION", Value=8)]
      UNSUPPORT_ACTION = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"LOGIN_INTERVAL_SHORT", Value=9)]
      LOGIN_INTERVAL_SHORT = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"LOGIN_LOCK", Value=10)]
      LOGIN_LOCK = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SERVER_ERROR", Value=4096)]
      SERVER_ERROR = 4096
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"PlayerError")]
    public enum PlayerError
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"PLAYER_NOT_EXIST", Value=131073)]
      PLAYER_NOT_EXIST = 131073,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PLAYER_NICKNAME_EXIST", Value=131074)]
      PLAYER_NICKNAME_EXIST = 131074,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PUID_EXIST", Value=131075)]
      PUID_EXIST = 131075,
            
      [global::ProtoBuf.ProtoEnum(Name=@"COIN_NOT_ENOUGH", Value=131076)]
      COIN_NOT_ENOUGH = 131076,
            
      [global::ProtoBuf.ProtoEnum(Name=@"COIN_LIMIT", Value=131077)]
      COIN_LIMIT = 131077,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GOLD_NOT_ENOUGH", Value=131078)]
      GOLD_NOT_ENOUGH = 131078,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GOLD_LIMIT", Value=131079)]
      GOLD_LIMIT = 131079,
            
      [global::ProtoBuf.ProtoEnum(Name=@"FATIGUE_NOT_ENOUGH", Value=131080)]
      FATIGUE_NOT_ENOUGH = 131080,
            
      [global::ProtoBuf.ProtoEnum(Name=@"FATIGUE_LIMIT", Value=131081)]
      FATIGUE_LIMIT = 131081,
            
      [global::ProtoBuf.ProtoEnum(Name=@"TOWER_COIN_NOT_ENOUGH", Value=131082)]
      TOWER_COIN_NOT_ENOUGH = 131082,
            
      [global::ProtoBuf.ProtoEnum(Name=@"TOWER_COIN_LIMIT", Value=131083)]
      TOWER_COIN_LIMIT = 131083,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ARENA_COIN_NOT_ENOUGH", Value=131084)]
      ARENA_COIN_NOT_ENOUGH = 131084,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ARENA_COIN_LIMIT", Value=131085)]
      ARENA_COIN_LIMIT = 131085,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CONTRIBUTION_NOT_ENOUGH", Value=131086)]
      CONTRIBUTION_NOT_ENOUGH = 131086,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CONTRIBUTION_LIMIT", Value=131087)]
      CONTRIBUTION_LIMIT = 131087,
            
      [global::ProtoBuf.ProtoEnum(Name=@"HONOR_POINT_LIMIT", Value=131088)]
      HONOR_POINT_LIMIT = 131088,
            
      [global::ProtoBuf.ProtoEnum(Name=@"HONOR_POINT_NOT_ENOUGH", Value=131089)]
      HONOR_POINT_NOT_ENOUGH = 131089,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SIGNIN_ALREADY", Value=135169)]
      SIGNIN_ALREADY = 135169,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SIGNIN_NOT_YET", Value=135170)]
      SIGNIN_NOT_YET = 135170,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SIGNIN_FILL_ZERO", Value=135171)]
      SIGNIN_FILL_ZERO = 135171,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SIGNIN_FINISH", Value=135172)]
      SIGNIN_FINISH = 135172,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SIGNIN_STOP", Value=135173)]
      SIGNIN_STOP = 135173
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"monsterError")]
    public enum monsterError
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"MONSTER_MAX_SIZE", Value=196609)]
      MONSTER_MAX_SIZE = 196609,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MONSTER_NOT_EXIST", Value=196610)]
      MONSTER_NOT_EXIST = 196610,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SKILL_POINT_NOT_ENOUGH", Value=196611)]
      SKILL_POINT_NOT_ENOUGH = 196611,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SKILL_LEVEL_LIMIT", Value=196612)]
      SKILL_LEVEL_LIMIT = 196612,
            
      [global::ProtoBuf.ProtoEnum(Name=@"STAGE_LIMIT", Value=196613)]
      STAGE_LIMIT = 196613,
            
      [global::ProtoBuf.ProtoEnum(Name=@"STAGE_LEVEL_NOT_ENOUGH", Value=196614)]
      STAGE_LEVEL_NOT_ENOUGH = 196614,
            
      [global::ProtoBuf.ProtoEnum(Name=@"STAGE_CONSUME", Value=196615)]
      STAGE_CONSUME = 196615,
            
      [global::ProtoBuf.ProtoEnum(Name=@"BATTLE_MONSTER_COUNT", Value=196616)]
      BATTLE_MONSTER_COUNT = 196616,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MONSTER_LOCKED", Value=196617)]
      MONSTER_LOCKED = 196617,
            
      [global::ProtoBuf.ProtoEnum(Name=@"LOCK_ALREADY", Value=196618)]
      LOCK_ALREADY = 196618,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UNLOCK_ALREADY", Value=196619)]
      UNLOCK_ALREADY = 196619,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MONSTER_BUSY", Value=196620)]
      MONSTER_BUSY = 196620
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"itemError")]
    public enum itemError
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"ITEM_NOT_FOUND", Value=262145)]
      ITEM_NOT_FOUND = 262145,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ITEM_NOT_ENOUGH", Value=262146)]
      ITEM_NOT_ENOUGH = 262146,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ITEM_BUY_NOT_ALLOW", Value=262147)]
      ITEM_BUY_NOT_ALLOW = 262147,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ITEM_SELL_NOT_ALLOW", Value=262148)]
      ITEM_SELL_NOT_ALLOW = 262148,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ITEM_EXP_LEFT_TIMES", Value=262149)]
      ITEM_EXP_LEFT_TIMES = 262149,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ITEM_USE_COUNT", Value=262150)]
      ITEM_USE_COUNT = 262150,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EQUIP_NOT_FOUND", Value=266241)]
      EQUIP_NOT_FOUND = 266241,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EQUIP_MAX_LEVEL_ALREADY", Value=266242)]
      EQUIP_MAX_LEVEL_ALREADY = 266242,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EQUIP_LEVEL_NOT_ENOUGH", Value=266243)]
      EQUIP_LEVEL_NOT_ENOUGH = 266243,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EQUIP_MAX_STAGE_ALREADY", Value=266244)]
      EQUIP_MAX_STAGE_ALREADY = 266244,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EQUIP_DRESS_ALREADY", Value=266245)]
      EQUIP_DRESS_ALREADY = 266245,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EQUIP_NOT_DRESS_OTHER", Value=266246)]
      EQUIP_NOT_DRESS_OTHER = 266246,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EQUIP_DRESS_OTHER_ALREADY", Value=266247)]
      EQUIP_DRESS_OTHER_ALREADY = 266247,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EQUIP_NOT_DRESSED", Value=266248)]
      EQUIP_NOT_DRESSED = 266248,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EQUIP_SLOT_NOT_EMPTY", Value=266249)]
      EQUIP_SLOT_NOT_EMPTY = 266249,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EQUIP_SLOT_EMPTY", Value=266250)]
      EQUIP_SLOT_EMPTY = 266250,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EQUIP_GEM_NOT_FOUND", Value=266251)]
      EQUIP_GEM_NOT_FOUND = 266251,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EQUIP_CAN_NOT_OPEN_SLOT", Value=266252)]
      EQUIP_CAN_NOT_OPEN_SLOT = 266252,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EQUIP_GEM_MISMATCH", Value=266253)]
      EQUIP_GEM_MISMATCH = 266253,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EQUIP_SLOT_NOT_PUNCH", Value=266254)]
      EQUIP_SLOT_NOT_PUNCH = 266254,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EQUIP_PLAYER_LEVEL_DEMAND", Value=266255)]
      EQUIP_PLAYER_LEVEL_DEMAND = 266255
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"questError")]
    public enum questError
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"QUEST_NOT_ACCEPT", Value=327681)]
      QUEST_NOT_ACCEPT = 327681,
            
      [global::ProtoBuf.ProtoEnum(Name=@"QUEST_NOT_COMPLETE", Value=327682)]
      QUEST_NOT_COMPLETE = 327682,
            
      [global::ProtoBuf.ProtoEnum(Name=@"QUEST_NOT_OPEN", Value=327683)]
      QUEST_NOT_OPEN = 327683
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"instanceError")]
    public enum instanceError
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"INSTANCE_NOT_OPEN", Value=393217)]
      INSTANCE_NOT_OPEN = 393217,
            
      [global::ProtoBuf.ProtoEnum(Name=@"INSTANCE_LEVEL", Value=393218)]
      INSTANCE_LEVEL = 393218,
            
      [global::ProtoBuf.ProtoEnum(Name=@"INSTANCE_COUNT", Value=393219)]
      INSTANCE_COUNT = 393219,
            
      [global::ProtoBuf.ProtoEnum(Name=@"INSTANCE_FATIGUE", Value=393220)]
      INSTANCE_FATIGUE = 393220,
            
      [global::ProtoBuf.ProtoEnum(Name=@"INSTANCE_REVIVE_COUNT", Value=393221)]
      INSTANCE_REVIVE_COUNT = 393221,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SWEEP_STAR_COUNT", Value=393222)]
      SWEEP_STAR_COUNT = 393222,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAPTER_BOX_STAR_COUNT", Value=393223)]
      CHAPTER_BOX_STAR_COUNT = 393223,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAPTER_BOX_ALREADY_OPEN", Value=393224)]
      CHAPTER_BOX_ALREADY_OPEN = 393224,
            
      [global::ProtoBuf.ProtoEnum(Name=@"INSTANCE_NOT_ENTER", Value=393225)]
      INSTANCE_NOT_ENTER = 393225,
            
      [global::ProtoBuf.ProtoEnum(Name=@"TOWER_FLOOR", Value=393226)]
      TOWER_FLOOR = 393226
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"mailError")]
    public enum mailError
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"MAIL_NOT_EXIST", Value=458753)]
      MAIL_NOT_EXIST = 458753,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MAIL_NONE", Value=458754)]
      MAIL_NONE = 458754,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MAIL_COIN_FULL", Value=458755)]
      MAIL_COIN_FULL = 458755,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MAIL_GOLD_FULL", Value=458756)]
      MAIL_GOLD_FULL = 458756
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"allianceError")]
    public enum allianceError
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCE_LEVEL_NOT_ENOUGH", Value=524289)]
      ALLIANCE_LEVEL_NOT_ENOUGH = 524289,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCE_ALREADY_IN", Value=524290)]
      ALLIANCE_ALREADY_IN = 524290,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCE_NOT_EXIST", Value=524291)]
      ALLIANCE_NOT_EXIST = 524291,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCE_NAME_ERROR", Value=524292)]
      ALLIANCE_NAME_ERROR = 524292,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCE_NAME_EXIST", Value=524293)]
      ALLIANCE_NAME_EXIST = 524293,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCE_NOT_JOIN", Value=524294)]
      ALLIANCE_NOT_JOIN = 524294,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCE_NO_MAIN", Value=524295)]
      ALLIANCE_NO_MAIN = 524295,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCE_NOTICE_ERROR", Value=524296)]
      ALLIANCE_NOTICE_ERROR = 524296,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCE_ALREADY_APPLY", Value=524297)]
      ALLIANCE_ALREADY_APPLY = 524297,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCE_ALREADY_FULL", Value=524298)]
      ALLIANCE_ALREADY_FULL = 524298,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCE_APPLY_NOT_EXIST", Value=524299)]
      ALLIANCE_APPLY_NOT_EXIST = 524299,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCE_POSITION_ERROR", Value=524300)]
      ALLIANCE_POSITION_ERROR = 524300,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCE__LEAVE_NOT_EMPTY", Value=524301)]
      ALLIANCE__LEAVE_NOT_EMPTY = 524301,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCE_TARGET_NOT_JOIN", Value=524302)]
      ALLIANCE_TARGET_NOT_JOIN = 524302,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCE_TARGET_ALREADY_JOIN", Value=524303)]
      ALLIANCE_TARGET_ALREADY_JOIN = 524303,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCE_TECH_FULL", Value=524304)]
      ALLIANCE_TECH_FULL = 524304,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCE_LEVEL_LIMIT", Value=524305)]
      ALLIANCE_LEVEL_LIMIT = 524305,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCE_CONTRI_NOT_ENOUGH", Value=524306)]
      ALLIANCE_CONTRI_NOT_ENOUGH = 524306,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCE_PRAY_MAX_COUNT", Value=524307)]
      ALLIANCE_PRAY_MAX_COUNT = 524307,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCE_FRIZEN_TIME", Value=524308)]
      ALLIANCE_FRIZEN_TIME = 524308,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCE_MAX_FAGIGUE_COUNT", Value=524309)]
      ALLIANCE_MAX_FAGIGUE_COUNT = 524309,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCE_FAGIGUE_GIVE_ALREADY", Value=524310)]
      ALLIANCE_FAGIGUE_GIVE_ALREADY = 524310,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCE_CAPACITY_NOT_ENOUGH", Value=524311)]
      ALLIANCE_CAPACITY_NOT_ENOUGH = 524311,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCE_SAME_POSITION", Value=524312)]
      ALLIANCE_SAME_POSITION = 524312,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCE_MAX_APPLY", Value=524313)]
      ALLIANCE_MAX_APPLY = 524313,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCE_ALREADY_IN_TEAM", Value=524314)]
      ALLIANCE_ALREADY_IN_TEAM = 524314,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCE_TEAM_NOT_EXIST", Value=524315)]
      ALLIANCE_TEAM_NOT_EXIST = 524315,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCE_TEAM_FINISH", Value=524316)]
      ALLIANCE_TEAM_FINISH = 524316,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCE_TEAM_FULL", Value=524317)]
      ALLIANCE_TEAM_FULL = 524317,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCE_TASK_FINISH", Value=524318)]
      ALLIANCE_TASK_FINISH = 524318,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCE_NOT_IN_TEAM", Value=524319)]
      ALLIANCE_NOT_IN_TEAM = 524319,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCE_TASK_NOT_EXIST", Value=524320)]
      ALLIANCE_TASK_NOT_EXIST = 524320,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCE_MAX_BIG_TASK", Value=524321)]
      ALLIANCE_MAX_BIG_TASK = 524321,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCE_MAX_SMALL_TASK", Value=524322)]
      ALLIANCE_MAX_SMALL_TASK = 524322,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCE_QUEST_NOT_EXIST", Value=524323)]
      ALLIANCE_QUEST_NOT_EXIST = 524323,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCE_QUEST_FINISH", Value=524324)]
      ALLIANCE_QUEST_FINISH = 524324,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCE_TASK_NOT_FINISH", Value=524325)]
      ALLIANCE_TASK_NOT_FINISH = 524325,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCE_NOT_CAPTAIN", Value=524326)]
      ALLIANCE_NOT_CAPTAIN = 524326,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCE_HAVE_MEMBER", Value=524327)]
      ALLIANCE_HAVE_MEMBER = 524327,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCE_REWARD_ALREADY_GIVE", Value=524328)]
      ALLIANCE_REWARD_ALREADY_GIVE = 524328,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCE_MAX_COPY_MAIN", Value=524329)]
      ALLIANCE_MAX_COPY_MAIN = 524329,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCE_APPLY_LIST_EMPTY", Value=524330)]
      ALLIANCE_APPLY_LIST_EMPTY = 524330,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCE_BASE_HAVE_MONSTER", Value=524331)]
      ALLIANCE_BASE_HAVE_MONSTER = 524331,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCE_BASE_HAVE_NO_MONSTER", Value=524332)]
      ALLIANCE_BASE_HAVE_NO_MONSTER = 524332,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCE_BASE_POSITION_LOCK", Value=524333)]
      ALLIANCE_BASE_POSITION_LOCK = 524333,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCE_BASE_MONSTER_HAVE_SEND", Value=524334)]
      ALLIANCE_BASE_MONSTER_HAVE_SEND = 524334,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCE_BASE_TIME_LIMIT", Value=524335)]
      ALLIANCE_BASE_TIME_LIMIT = 524335
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"shopError")]
    public enum shopError
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"SHOP_REFRESH_TIMEOUT", Value=589825)]
      SHOP_REFRESH_TIMEOUT = 589825,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SHOP_ITEM_ALREADY_BUY", Value=589826)]
      SHOP_ITEM_ALREADY_BUY = 589826,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SHOP_REFRESH_MAX_COUNT", Value=589827)]
      SHOP_REFRESH_MAX_COUNT = 589827,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SHOP_GOLD2COIN_MAX_COUNT", Value=589828)]
      SHOP_GOLD2COIN_MAX_COUNT = 589828
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"imError")]
    public enum imError
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"IM_CHAT_LENGTH", Value=655361)]
      IM_CHAT_LENGTH = 655361,
            
      [global::ProtoBuf.ProtoEnum(Name=@"IM_DUMP_ERROR", Value=655362)]
      IM_DUMP_ERROR = 655362
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"settingError")]
    public enum settingError
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"SETTING_BLOCK_FULL", Value=720897)]
      SETTING_BLOCK_FULL = 720897
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"adventureError")]
    public enum adventureError
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"ADVENTURE_TEAM_COUNT", Value=786433)]
      ADVENTURE_TEAM_COUNT = 786433,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ADVENTURE_CHANGE_ZERO", Value=786434)]
      ADVENTURE_CHANGE_ZERO = 786434,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ADVENTURE_CHANGE_NOT_ZERO", Value=786435)]
      ADVENTURE_CHANGE_NOT_ZERO = 786435,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ADVENTURE_MONSTER_COUNT", Value=786436)]
      ADVENTURE_MONSTER_COUNT = 786436,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ADVENTURE_TEAM_NOT_OPEN", Value=786437)]
      ADVENTURE_TEAM_NOT_OPEN = 786437,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ADVENTURE_TEAM_BUSY", Value=786438)]
      ADVENTURE_TEAM_BUSY = 786438,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ADVENTURE_TEAM_IDLE", Value=786439)]
      ADVENTURE_TEAM_IDLE = 786439,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ADVENTURE_NOT_END", Value=786440)]
      ADVENTURE_NOT_END = 786440,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ADVENTURE_HIRE_ALREADY", Value=786441)]
      ADVENTURE_HIRE_ALREADY = 786441
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"summonError")]
    public enum summonError
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"SUMMON_DIAMOND_NO_FREE", Value=851969)]
      SUMMON_DIAMOND_NO_FREE = 851969,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SUMMON_COIN_NO_FREE", Value=851970)]
      SUMMON_COIN_NO_FREE = 851970,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SUMMON_COIN_FREE_CD", Value=851971)]
      SUMMON_COIN_FREE_CD = 851971
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"pvpError")]
    public enum pvpError
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"PVP_NOT_MATCH_TARGET", Value=917505)]
      PVP_NOT_MATCH_TARGET = 917505,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PVP_NOT_SET_DEFENCE", Value=917506)]
      PVP_NOT_SET_DEFENCE = 917506,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PVP_NOT_MATCH_BEFORE", Value=917507)]
      PVP_NOT_MATCH_BEFORE = 917507,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PVP_TIMES_NOT_ENOUGH", Value=917508)]
      PVP_TIMES_NOT_ENOUGH = 917508,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PVP_NOT_IN_RANK_LIST", Value=917509)]
      PVP_NOT_IN_RANK_LIST = 917509
    }
  
}