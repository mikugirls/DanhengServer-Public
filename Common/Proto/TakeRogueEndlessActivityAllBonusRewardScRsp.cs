// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TakeRogueEndlessActivityAllBonusRewardScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from TakeRogueEndlessActivityAllBonusRewardScRsp.proto</summary>
  public static partial class TakeRogueEndlessActivityAllBonusRewardScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for TakeRogueEndlessActivityAllBonusRewardScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TakeRogueEndlessActivityAllBonusRewardScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjFUYWtlUm9ndWVFbmRsZXNzQWN0aXZpdHlBbGxCb251c1Jld2FyZFNjUnNw",
            "LnByb3RvGg5JdGVtTGlzdC5wcm90byKDAQorVGFrZVJvZ3VlRW5kbGVzc0Fj",
            "dGl2aXR5QWxsQm9udXNSZXdhcmRTY1JzcBIPCgdyZXRjb2RlGAcgASgNEhMK",
            "C0pOR0RES01PSURJGAggASgNEhMKC0dBRUlQTktHUEtNGA0gAygNEhkKBnJl",
            "d2FyZBgCIAEoCzIJLkl0ZW1MaXN0Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2",
            "ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ItemListReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.TakeRogueEndlessActivityAllBonusRewardScRsp), global::EggLink.DanhengServer.Proto.TakeRogueEndlessActivityAllBonusRewardScRsp.Parser, new[]{ "Retcode", "JNGDDKMOIDI", "GAEIPNKGPKM", "Reward" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class TakeRogueEndlessActivityAllBonusRewardScRsp : pb::IMessage<TakeRogueEndlessActivityAllBonusRewardScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TakeRogueEndlessActivityAllBonusRewardScRsp> _parser = new pb::MessageParser<TakeRogueEndlessActivityAllBonusRewardScRsp>(() => new TakeRogueEndlessActivityAllBonusRewardScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TakeRogueEndlessActivityAllBonusRewardScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.TakeRogueEndlessActivityAllBonusRewardScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TakeRogueEndlessActivityAllBonusRewardScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TakeRogueEndlessActivityAllBonusRewardScRsp(TakeRogueEndlessActivityAllBonusRewardScRsp other) : this() {
      retcode_ = other.retcode_;
      jNGDDKMOIDI_ = other.jNGDDKMOIDI_;
      gAEIPNKGPKM_ = other.gAEIPNKGPKM_.Clone();
      reward_ = other.reward_ != null ? other.reward_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TakeRogueEndlessActivityAllBonusRewardScRsp Clone() {
      return new TakeRogueEndlessActivityAllBonusRewardScRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 7;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "JNGDDKMOIDI" field.</summary>
    public const int JNGDDKMOIDIFieldNumber = 8;
    private uint jNGDDKMOIDI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint JNGDDKMOIDI {
      get { return jNGDDKMOIDI_; }
      set {
        jNGDDKMOIDI_ = value;
      }
    }

    /// <summary>Field number for the "GAEIPNKGPKM" field.</summary>
    public const int GAEIPNKGPKMFieldNumber = 13;
    private static readonly pb::FieldCodec<uint> _repeated_gAEIPNKGPKM_codec
        = pb::FieldCodec.ForUInt32(106);
    private readonly pbc::RepeatedField<uint> gAEIPNKGPKM_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> GAEIPNKGPKM {
      get { return gAEIPNKGPKM_; }
    }

    /// <summary>Field number for the "reward" field.</summary>
    public const int RewardFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.ItemList reward_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemList Reward {
      get { return reward_; }
      set {
        reward_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TakeRogueEndlessActivityAllBonusRewardScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TakeRogueEndlessActivityAllBonusRewardScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (JNGDDKMOIDI != other.JNGDDKMOIDI) return false;
      if(!gAEIPNKGPKM_.Equals(other.gAEIPNKGPKM_)) return false;
      if (!object.Equals(Reward, other.Reward)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (JNGDDKMOIDI != 0) hash ^= JNGDDKMOIDI.GetHashCode();
      hash ^= gAEIPNKGPKM_.GetHashCode();
      if (reward_ != null) hash ^= Reward.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (reward_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Reward);
      }
      if (Retcode != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Retcode);
      }
      if (JNGDDKMOIDI != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(JNGDDKMOIDI);
      }
      gAEIPNKGPKM_.WriteTo(output, _repeated_gAEIPNKGPKM_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (reward_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Reward);
      }
      if (Retcode != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Retcode);
      }
      if (JNGDDKMOIDI != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(JNGDDKMOIDI);
      }
      gAEIPNKGPKM_.WriteTo(ref output, _repeated_gAEIPNKGPKM_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (JNGDDKMOIDI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(JNGDDKMOIDI);
      }
      size += gAEIPNKGPKM_.CalculateSize(_repeated_gAEIPNKGPKM_codec);
      if (reward_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Reward);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TakeRogueEndlessActivityAllBonusRewardScRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.JNGDDKMOIDI != 0) {
        JNGDDKMOIDI = other.JNGDDKMOIDI;
      }
      gAEIPNKGPKM_.Add(other.gAEIPNKGPKM_);
      if (other.reward_ != null) {
        if (reward_ == null) {
          Reward = new global::EggLink.DanhengServer.Proto.ItemList();
        }
        Reward.MergeFrom(other.Reward);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 18: {
            if (reward_ == null) {
              Reward = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(Reward);
            break;
          }
          case 56: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 64: {
            JNGDDKMOIDI = input.ReadUInt32();
            break;
          }
          case 106:
          case 104: {
            gAEIPNKGPKM_.AddEntriesFrom(input, _repeated_gAEIPNKGPKM_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 18: {
            if (reward_ == null) {
              Reward = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(Reward);
            break;
          }
          case 56: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 64: {
            JNGDDKMOIDI = input.ReadUInt32();
            break;
          }
          case 106:
          case 104: {
            gAEIPNKGPKM_.AddEntriesFrom(ref input, _repeated_gAEIPNKGPKM_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
