// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessRogueGameInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChessRogueGameInfo.proto</summary>
  public static partial class ChessRogueGameInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessRogueGameInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessRogueGameInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhDaGVzc1JvZ3VlR2FtZUluZm8ucHJvdG8aHENoZXNzUm9ndWVHYW1lQWVv",
            "bkluZm8ucHJvdG8aHENoZXNzUm9ndWVHYW1lSXRlbUluZm8ucHJvdG8aI0No",
            "ZXNzUm9ndWVEaWZmaWN1bHR5TGV2ZWxJbmZvLnByb3RvGhtDaGVzc1JvZ3Vl",
            "TWlyYWNsZUluZm8ucHJvdG8aGENoZXNzUm9ndWVCdWZmSW5mby5wcm90byK0",
            "AgoSQ2hlc3NSb2d1ZUdhbWVJbmZvEi4KD3JvZ3VlX2J1ZmZfaW5mbxgGIAEo",
            "CzITLkNoZXNzUm9ndWVCdWZmSW5mb0gAEjMKEWdhbWVfbWlyYWNsZV9pbmZv",
            "GAogASgLMhYuQ2hlc3NSb2d1ZU1pcmFjbGVJbmZvSAASMQoOZ2FtZV9pdGVt",
            "X2luZm8YCyABKAsyFy5DaGVzc1JvZ3VlR2FtZUl0ZW1JbmZvSAASMgoPcm9n",
            "dWVfYWVvbl9pbmZvGAMgASgLMhcuQ2hlc3NSb2d1ZUdhbWVBZW9uSW5mb0gA",
            "Ej8KFXJvZ3VlX2RpZmZpY3VsdHlfaW5mbxgMIAEoCzIeLkNoZXNzUm9ndWVE",
            "aWZmaWN1bHR5TGV2ZWxJbmZvSABCEQoPcm9ndWVfZ2FtZV9pdGVtQh6qAhtF",
            "Z2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ChessRogueGameAeonInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueGameItemInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueDifficultyLevelInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueMiracleInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueBuffInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChessRogueGameInfo), global::EggLink.DanhengServer.Proto.ChessRogueGameInfo.Parser, new[]{ "RogueBuffInfo", "GameMiracleInfo", "GameItemInfo", "RogueAeonInfo", "RogueDifficultyInfo" }, new[]{ "RogueGameItem" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ChessRogueGameInfo : pb::IMessage<ChessRogueGameInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChessRogueGameInfo> _parser = new pb::MessageParser<ChessRogueGameInfo>(() => new ChessRogueGameInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChessRogueGameInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChessRogueGameInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueGameInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueGameInfo(ChessRogueGameInfo other) : this() {
      switch (other.RogueGameItemCase) {
        case RogueGameItemOneofCase.RogueBuffInfo:
          RogueBuffInfo = other.RogueBuffInfo.Clone();
          break;
        case RogueGameItemOneofCase.GameMiracleInfo:
          GameMiracleInfo = other.GameMiracleInfo.Clone();
          break;
        case RogueGameItemOneofCase.GameItemInfo:
          GameItemInfo = other.GameItemInfo.Clone();
          break;
        case RogueGameItemOneofCase.RogueAeonInfo:
          RogueAeonInfo = other.RogueAeonInfo.Clone();
          break;
        case RogueGameItemOneofCase.RogueDifficultyInfo:
          RogueDifficultyInfo = other.RogueDifficultyInfo.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueGameInfo Clone() {
      return new ChessRogueGameInfo(this);
    }

    /// <summary>Field number for the "rogue_buff_info" field.</summary>
    public const int RogueBuffInfoFieldNumber = 6;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueBuffInfo RogueBuffInfo {
      get { return rogueGameItemCase_ == RogueGameItemOneofCase.RogueBuffInfo ? (global::EggLink.DanhengServer.Proto.ChessRogueBuffInfo) rogueGameItem_ : null; }
      set {
        rogueGameItem_ = value;
        rogueGameItemCase_ = value == null ? RogueGameItemOneofCase.None : RogueGameItemOneofCase.RogueBuffInfo;
      }
    }

    /// <summary>Field number for the "game_miracle_info" field.</summary>
    public const int GameMiracleInfoFieldNumber = 10;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueMiracleInfo GameMiracleInfo {
      get { return rogueGameItemCase_ == RogueGameItemOneofCase.GameMiracleInfo ? (global::EggLink.DanhengServer.Proto.ChessRogueMiracleInfo) rogueGameItem_ : null; }
      set {
        rogueGameItem_ = value;
        rogueGameItemCase_ = value == null ? RogueGameItemOneofCase.None : RogueGameItemOneofCase.GameMiracleInfo;
      }
    }

    /// <summary>Field number for the "game_item_info" field.</summary>
    public const int GameItemInfoFieldNumber = 11;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueGameItemInfo GameItemInfo {
      get { return rogueGameItemCase_ == RogueGameItemOneofCase.GameItemInfo ? (global::EggLink.DanhengServer.Proto.ChessRogueGameItemInfo) rogueGameItem_ : null; }
      set {
        rogueGameItem_ = value;
        rogueGameItemCase_ = value == null ? RogueGameItemOneofCase.None : RogueGameItemOneofCase.GameItemInfo;
      }
    }

    /// <summary>Field number for the "rogue_aeon_info" field.</summary>
    public const int RogueAeonInfoFieldNumber = 3;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueGameAeonInfo RogueAeonInfo {
      get { return rogueGameItemCase_ == RogueGameItemOneofCase.RogueAeonInfo ? (global::EggLink.DanhengServer.Proto.ChessRogueGameAeonInfo) rogueGameItem_ : null; }
      set {
        rogueGameItem_ = value;
        rogueGameItemCase_ = value == null ? RogueGameItemOneofCase.None : RogueGameItemOneofCase.RogueAeonInfo;
      }
    }

    /// <summary>Field number for the "rogue_difficulty_info" field.</summary>
    public const int RogueDifficultyInfoFieldNumber = 12;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueDifficultyLevelInfo RogueDifficultyInfo {
      get { return rogueGameItemCase_ == RogueGameItemOneofCase.RogueDifficultyInfo ? (global::EggLink.DanhengServer.Proto.ChessRogueDifficultyLevelInfo) rogueGameItem_ : null; }
      set {
        rogueGameItem_ = value;
        rogueGameItemCase_ = value == null ? RogueGameItemOneofCase.None : RogueGameItemOneofCase.RogueDifficultyInfo;
      }
    }

    private object rogueGameItem_;
    /// <summary>Enum of possible cases for the "rogue_game_item" oneof.</summary>
    public enum RogueGameItemOneofCase {
      None = 0,
      RogueBuffInfo = 6,
      GameMiracleInfo = 10,
      GameItemInfo = 11,
      RogueAeonInfo = 3,
      RogueDifficultyInfo = 12,
    }
    private RogueGameItemOneofCase rogueGameItemCase_ = RogueGameItemOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueGameItemOneofCase RogueGameItemCase {
      get { return rogueGameItemCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearRogueGameItem() {
      rogueGameItemCase_ = RogueGameItemOneofCase.None;
      rogueGameItem_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChessRogueGameInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChessRogueGameInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(RogueBuffInfo, other.RogueBuffInfo)) return false;
      if (!object.Equals(GameMiracleInfo, other.GameMiracleInfo)) return false;
      if (!object.Equals(GameItemInfo, other.GameItemInfo)) return false;
      if (!object.Equals(RogueAeonInfo, other.RogueAeonInfo)) return false;
      if (!object.Equals(RogueDifficultyInfo, other.RogueDifficultyInfo)) return false;
      if (RogueGameItemCase != other.RogueGameItemCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (rogueGameItemCase_ == RogueGameItemOneofCase.RogueBuffInfo) hash ^= RogueBuffInfo.GetHashCode();
      if (rogueGameItemCase_ == RogueGameItemOneofCase.GameMiracleInfo) hash ^= GameMiracleInfo.GetHashCode();
      if (rogueGameItemCase_ == RogueGameItemOneofCase.GameItemInfo) hash ^= GameItemInfo.GetHashCode();
      if (rogueGameItemCase_ == RogueGameItemOneofCase.RogueAeonInfo) hash ^= RogueAeonInfo.GetHashCode();
      if (rogueGameItemCase_ == RogueGameItemOneofCase.RogueDifficultyInfo) hash ^= RogueDifficultyInfo.GetHashCode();
      hash ^= (int) rogueGameItemCase_;
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
      if (rogueGameItemCase_ == RogueGameItemOneofCase.RogueAeonInfo) {
        output.WriteRawTag(26);
        output.WriteMessage(RogueAeonInfo);
      }
      if (rogueGameItemCase_ == RogueGameItemOneofCase.RogueBuffInfo) {
        output.WriteRawTag(50);
        output.WriteMessage(RogueBuffInfo);
      }
      if (rogueGameItemCase_ == RogueGameItemOneofCase.GameMiracleInfo) {
        output.WriteRawTag(82);
        output.WriteMessage(GameMiracleInfo);
      }
      if (rogueGameItemCase_ == RogueGameItemOneofCase.GameItemInfo) {
        output.WriteRawTag(90);
        output.WriteMessage(GameItemInfo);
      }
      if (rogueGameItemCase_ == RogueGameItemOneofCase.RogueDifficultyInfo) {
        output.WriteRawTag(98);
        output.WriteMessage(RogueDifficultyInfo);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (rogueGameItemCase_ == RogueGameItemOneofCase.RogueAeonInfo) {
        output.WriteRawTag(26);
        output.WriteMessage(RogueAeonInfo);
      }
      if (rogueGameItemCase_ == RogueGameItemOneofCase.RogueBuffInfo) {
        output.WriteRawTag(50);
        output.WriteMessage(RogueBuffInfo);
      }
      if (rogueGameItemCase_ == RogueGameItemOneofCase.GameMiracleInfo) {
        output.WriteRawTag(82);
        output.WriteMessage(GameMiracleInfo);
      }
      if (rogueGameItemCase_ == RogueGameItemOneofCase.GameItemInfo) {
        output.WriteRawTag(90);
        output.WriteMessage(GameItemInfo);
      }
      if (rogueGameItemCase_ == RogueGameItemOneofCase.RogueDifficultyInfo) {
        output.WriteRawTag(98);
        output.WriteMessage(RogueDifficultyInfo);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (rogueGameItemCase_ == RogueGameItemOneofCase.RogueBuffInfo) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueBuffInfo);
      }
      if (rogueGameItemCase_ == RogueGameItemOneofCase.GameMiracleInfo) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GameMiracleInfo);
      }
      if (rogueGameItemCase_ == RogueGameItemOneofCase.GameItemInfo) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GameItemInfo);
      }
      if (rogueGameItemCase_ == RogueGameItemOneofCase.RogueAeonInfo) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueAeonInfo);
      }
      if (rogueGameItemCase_ == RogueGameItemOneofCase.RogueDifficultyInfo) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueDifficultyInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChessRogueGameInfo other) {
      if (other == null) {
        return;
      }
      switch (other.RogueGameItemCase) {
        case RogueGameItemOneofCase.RogueBuffInfo:
          if (RogueBuffInfo == null) {
            RogueBuffInfo = new global::EggLink.DanhengServer.Proto.ChessRogueBuffInfo();
          }
          RogueBuffInfo.MergeFrom(other.RogueBuffInfo);
          break;
        case RogueGameItemOneofCase.GameMiracleInfo:
          if (GameMiracleInfo == null) {
            GameMiracleInfo = new global::EggLink.DanhengServer.Proto.ChessRogueMiracleInfo();
          }
          GameMiracleInfo.MergeFrom(other.GameMiracleInfo);
          break;
        case RogueGameItemOneofCase.GameItemInfo:
          if (GameItemInfo == null) {
            GameItemInfo = new global::EggLink.DanhengServer.Proto.ChessRogueGameItemInfo();
          }
          GameItemInfo.MergeFrom(other.GameItemInfo);
          break;
        case RogueGameItemOneofCase.RogueAeonInfo:
          if (RogueAeonInfo == null) {
            RogueAeonInfo = new global::EggLink.DanhengServer.Proto.ChessRogueGameAeonInfo();
          }
          RogueAeonInfo.MergeFrom(other.RogueAeonInfo);
          break;
        case RogueGameItemOneofCase.RogueDifficultyInfo:
          if (RogueDifficultyInfo == null) {
            RogueDifficultyInfo = new global::EggLink.DanhengServer.Proto.ChessRogueDifficultyLevelInfo();
          }
          RogueDifficultyInfo.MergeFrom(other.RogueDifficultyInfo);
          break;
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
          case 26: {
            global::EggLink.DanhengServer.Proto.ChessRogueGameAeonInfo subBuilder = new global::EggLink.DanhengServer.Proto.ChessRogueGameAeonInfo();
            if (rogueGameItemCase_ == RogueGameItemOneofCase.RogueAeonInfo) {
              subBuilder.MergeFrom(RogueAeonInfo);
            }
            input.ReadMessage(subBuilder);
            RogueAeonInfo = subBuilder;
            break;
          }
          case 50: {
            global::EggLink.DanhengServer.Proto.ChessRogueBuffInfo subBuilder = new global::EggLink.DanhengServer.Proto.ChessRogueBuffInfo();
            if (rogueGameItemCase_ == RogueGameItemOneofCase.RogueBuffInfo) {
              subBuilder.MergeFrom(RogueBuffInfo);
            }
            input.ReadMessage(subBuilder);
            RogueBuffInfo = subBuilder;
            break;
          }
          case 82: {
            global::EggLink.DanhengServer.Proto.ChessRogueMiracleInfo subBuilder = new global::EggLink.DanhengServer.Proto.ChessRogueMiracleInfo();
            if (rogueGameItemCase_ == RogueGameItemOneofCase.GameMiracleInfo) {
              subBuilder.MergeFrom(GameMiracleInfo);
            }
            input.ReadMessage(subBuilder);
            GameMiracleInfo = subBuilder;
            break;
          }
          case 90: {
            global::EggLink.DanhengServer.Proto.ChessRogueGameItemInfo subBuilder = new global::EggLink.DanhengServer.Proto.ChessRogueGameItemInfo();
            if (rogueGameItemCase_ == RogueGameItemOneofCase.GameItemInfo) {
              subBuilder.MergeFrom(GameItemInfo);
            }
            input.ReadMessage(subBuilder);
            GameItemInfo = subBuilder;
            break;
          }
          case 98: {
            global::EggLink.DanhengServer.Proto.ChessRogueDifficultyLevelInfo subBuilder = new global::EggLink.DanhengServer.Proto.ChessRogueDifficultyLevelInfo();
            if (rogueGameItemCase_ == RogueGameItemOneofCase.RogueDifficultyInfo) {
              subBuilder.MergeFrom(RogueDifficultyInfo);
            }
            input.ReadMessage(subBuilder);
            RogueDifficultyInfo = subBuilder;
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
          case 26: {
            global::EggLink.DanhengServer.Proto.ChessRogueGameAeonInfo subBuilder = new global::EggLink.DanhengServer.Proto.ChessRogueGameAeonInfo();
            if (rogueGameItemCase_ == RogueGameItemOneofCase.RogueAeonInfo) {
              subBuilder.MergeFrom(RogueAeonInfo);
            }
            input.ReadMessage(subBuilder);
            RogueAeonInfo = subBuilder;
            break;
          }
          case 50: {
            global::EggLink.DanhengServer.Proto.ChessRogueBuffInfo subBuilder = new global::EggLink.DanhengServer.Proto.ChessRogueBuffInfo();
            if (rogueGameItemCase_ == RogueGameItemOneofCase.RogueBuffInfo) {
              subBuilder.MergeFrom(RogueBuffInfo);
            }
            input.ReadMessage(subBuilder);
            RogueBuffInfo = subBuilder;
            break;
          }
          case 82: {
            global::EggLink.DanhengServer.Proto.ChessRogueMiracleInfo subBuilder = new global::EggLink.DanhengServer.Proto.ChessRogueMiracleInfo();
            if (rogueGameItemCase_ == RogueGameItemOneofCase.GameMiracleInfo) {
              subBuilder.MergeFrom(GameMiracleInfo);
            }
            input.ReadMessage(subBuilder);
            GameMiracleInfo = subBuilder;
            break;
          }
          case 90: {
            global::EggLink.DanhengServer.Proto.ChessRogueGameItemInfo subBuilder = new global::EggLink.DanhengServer.Proto.ChessRogueGameItemInfo();
            if (rogueGameItemCase_ == RogueGameItemOneofCase.GameItemInfo) {
              subBuilder.MergeFrom(GameItemInfo);
            }
            input.ReadMessage(subBuilder);
            GameItemInfo = subBuilder;
            break;
          }
          case 98: {
            global::EggLink.DanhengServer.Proto.ChessRogueDifficultyLevelInfo subBuilder = new global::EggLink.DanhengServer.Proto.ChessRogueDifficultyLevelInfo();
            if (rogueGameItemCase_ == RogueGameItemOneofCase.RogueDifficultyInfo) {
              subBuilder.MergeFrom(RogueDifficultyInfo);
            }
            input.ReadMessage(subBuilder);
            RogueDifficultyInfo = subBuilder;
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