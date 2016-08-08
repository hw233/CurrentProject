//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Protocol/Const.proto
namespace PB
{
    [global::ProtoBuf.ProtoContract(Name=@"chatType")]
    public enum chatType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_WORLD", Value=1)]
      CHAT_WORLD = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT_BROADCAST", Value=2)]
      CHAT_BROADCAST = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WORLD_BROADCAST", Value=3)]
      WORLD_BROADCAST = 3
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"kickReason")]
    public enum kickReason
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"DUPLICATE_LOGIN", Value=1)]
      DUPLICATE_LOGIN = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SERVER_SHUTDOWN", Value=2)]
      SERVER_SHUTDOWN = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"LOGIN_FORBIDEN", Value=3)]
      LOGIN_FORBIDEN = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"KICKED_OUT", Value=4)]
      KICKED_OUT = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SERVER_RESTART", Value=5)]
      SERVER_RESTART = 5
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"RewardReason")]
    public enum RewardReason
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"SYS_PRESENT", Value=1)]
      SYS_PRESENT = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NPC", Value=2)]
      NPC = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"QUEST", Value=3)]
      QUEST = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACITVITY", Value=4)]
      ACITVITY = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CATCH", Value=5)]
      CATCH = 5
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"ClassType")]
    public enum ClassType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"PLAYER_TYPE", Value=1)]
      PLAYER_TYPE = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MONSTER_TYPE", Value=2)]
      MONSTER_TYPE = 2
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"itemType")]
    public enum itemType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"NONE_ITEM", Value=0)]
      NONE_ITEM = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PLAYER_ATTR", Value=1)]
      PLAYER_ATTR = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MONSTER_ATTR", Value=2)]
      MONSTER_ATTR = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ITEM", Value=3)]
      ITEM = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EQUIP", Value=4)]
      EQUIP = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SKILL", Value=5)]
      SKILL = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GROUP", Value=6)]
      GROUP = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MONSTER", Value=7)]
      MONSTER = 7
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"moneyType")]
    public enum moneyType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"MONEY_GOLD", Value=1)]
      MONEY_GOLD = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MONEY_COIN", Value=2)]
      MONEY_COIN = 2
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"playerAttr")]
    public enum playerAttr
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"GOLD", Value=1)]
      GOLD = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"COIN", Value=2)]
      COIN = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"LEVEL", Value=3)]
      LEVEL = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EXP", Value=4)]
      EXP = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"FATIGUE", Value=5)]
      FATIGUE = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"VIPLEVEL", Value=6)]
      VIPLEVEL = 6
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"changeType")]
    public enum changeType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHANGE_GOLD", Value=1)]
      CHANGE_GOLD = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHANGE_COIN", Value=2)]
      CHANGE_COIN = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHANGE_PLAYER_EXP", Value=3)]
      CHANGE_PLAYER_EXP = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHANGE_PLAYER_LEVEL", Value=4)]
      CHANGE_PLAYER_LEVEL = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHANGE_MONSTER_EXP", Value=5)]
      CHANGE_MONSTER_EXP = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHANGE_MONSTER_LEVEL", Value=6)]
      CHANGE_MONSTER_LEVEL = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHANGE_FATIGUE", Value=7)]
      CHANGE_FATIGUE = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHANGE_FAV", Value=8)]
      CHANGE_FAV = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHANGE_GOLD_BUY", Value=8)]
      CHANGE_GOLD_BUY = 8
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"attr")]
    public enum attr
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"EMPTYATTR", Value=0)]
      EMPTYATTR = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"STRENGHT", Value=1)]
      STRENGHT = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"INTELLIGENCE", Value=2)]
      INTELLIGENCE = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SPEED", Value=3)]
      SPEED = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DEFENSE", Value=4)]
      DEFENSE = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"HEALTH", Value=5)]
      HEALTH = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DEFENSEWEAKEN", Value=101)]
      DEFENSEWEAKEN = 101,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CRITICAL", Value=102)]
      CRITICAL = 102,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CRITICALWEAKEN", Value=103)]
      CRITICALWEAKEN = 103,
            
      [global::ProtoBuf.ProtoEnum(Name=@"RECOVERY", Value=104)]
      RECOVERY = 104,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CRITICALDAMAGE", Value=105)]
      CRITICALDAMAGE = 105,
            
      [global::ProtoBuf.ProtoEnum(Name=@"HITRATE", Value=106)]
      HITRATE = 106,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CUREINCREASE", Value=107)]
      CUREINCREASE = 107,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DAMAGEREDUCE", Value=108)]
      DAMAGEREDUCE = 108,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DAMAGEINCREASE", Value=109)]
      DAMAGEINCREASE = 109
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"userCondition")]
    public enum userCondition
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"BATTLE", Value=1)]
      BATTLE = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NON_BATTLE", Value=2)]
      NON_BATTLE = 2
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"bindType")]
    public enum bindType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"NON_BIND", Value=1)]
      NON_BIND = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"USE_BIND", Value=2)]
      USE_BIND = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"TAKE_BIND", Value=3)]
      TAKE_BIND = 3
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"toolType")]
    public enum toolType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"COMMONTOOL", Value=1)]
      COMMONTOOL = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"FRAGMENTTOOL", Value=2)]
      FRAGMENTTOOL = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GEMTOOL", Value=3)]
      GEMTOOL = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"BOXTOOL", Value=4)]
      BOXTOOL = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"USETOOL", Value=5)]
      USETOOL = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EQUIPTOOL", Value=7)]
      EQUIPTOOL = 7
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"FragSubType")]
    public enum FragSubType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"FRAG_MONSTER", Value=1)]
      FRAG_MONSTER = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"FRAG_TOOL", Value=2)]
      FRAG_TOOL = 2
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"UseToolSubType")]
    public enum UseToolSubType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"USETOOLEXP", Value=1)]
      USETOOLEXP = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"USETOOLDOUBLEEXP", Value=2)]
      USETOOLDOUBLEEXP = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"USETOOLTRIPLEEXP", Value=3)]
      USETOOLTRIPLEEXP = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"USETOOLFATIGUE", Value=4)]
      USETOOLFATIGUE = 4
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"equipPart")]
    public enum equipPart
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"HELMET", Value=1)]
      HELMET = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"RING", Value=2)]
      RING = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"BELT", Value=3)]
      BELT = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CUIRASS", Value=4)]
      CUIRASS = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WEAPON1", Value=5)]
      WEAPON1 = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WEAPON2", Value=6)]
      WEAPON2 = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"LEGGUARD", Value=7)]
      LEGGUARD = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SHOES", Value=8)]
      SHOES = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GLOVE", Value=9)]
      GLOVE = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NECKLACE", Value=10)]
      NECKLACE = 10
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"equipQuality")]
    public enum equipQuality
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"WHITE", Value=1)]
      WHITE = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GREEN", Value=2)]
      GREEN = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"BLUE", Value=3)]
      BLUE = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PURPLE", Value=4)]
      PURPLE = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ORANGE", Value=5)]
      ORANGE = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"RED", Value=6)]
      RED = 6
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"shopType")]
    public enum shopType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"NORMALSHOP", Value=1)]
      NORMALSHOP = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCESHOP", Value=2)]
      ALLIANCESHOP = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OTHERSHOP", Value=3)]
      OTHERSHOP = 3
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"mailState")]
    public enum mailState
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"UNREAD", Value=1)]
      UNREAD = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"READ", Value=2)]
      READ = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"RECEIVE", Value=3)]
      RECEIVE = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OVERFLOW", Value=4)]
      OVERFLOW = 4
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"ImType")]
    public enum ImType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT", Value=1)]
      CHAT = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"LANTERN", Value=2)]
      LANTERN = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PROMPT", Value=3)]
      PROMPT = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NOTICE", Value=4)]
      NOTICE = 4
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"ImChannel")]
    public enum ImChannel
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"PERSON", Value=1)]
      PERSON = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WORLD", Value=2)]
      WORLD = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GUILD", Value=3)]
      GUILD = 3
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"ChapterBoxState")]
    public enum ChapterBoxState
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"INVALID", Value=-1)]
      INVALID = -1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"VALID", Value=0)]
      VALID = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OPEN", Value=1)]
      OPEN = 1
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"InstanceType")]
    public enum InstanceType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"INSTANCE_STORY", Value=1)]
      INSTANCE_STORY = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"INSTANCE_HOLE", Value=2)]
      INSTANCE_HOLE = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"INSTANCE_TOWER", Value=3)]
      INSTANCE_TOWER = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"INSTANCE_GUILD", Value=4)]
      INSTANCE_GUILD = 4
    }
  
}