//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: HP.proto
namespace PB
{
    [global::ProtoBuf.ProtoContract(Name=@"sys")]
    public enum sys
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"DATA_WRAPPER", Value=1)]
      DATA_WRAPPER = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"KEY_EXCHANGE", Value=2)]
      KEY_EXCHANGE = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"HEART_BEAT", Value=3)]
      HEART_BEAT = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ERROR_CODE", Value=4)]
      ERROR_CODE = 4
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"code")]
    public enum code
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"LOGIN_C", Value=1000)]
      LOGIN_C = 1000,
            
      [global::ProtoBuf.ProtoEnum(Name=@"LOGIN_S", Value=1001)]
      LOGIN_S = 1001
    }
  
}