// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FinishChessRogueSubStoryCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from FinishChessRogueSubStoryCsReq.proto</summary>
  public static partial class FinishChessRogueSubStoryCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for FinishChessRogueSubStoryCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FinishChessRogueSubStoryCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNGaW5pc2hDaGVzc1JvZ3VlU3ViU3RvcnlDc1JlcS5wcm90byJrCh1GaW5p",
            "c2hDaGVzc1JvZ3VlU3ViU3RvcnlDc1JlcRIgChhjaGVzc19yb2d1ZV9zdWJf",
            "c3RvcnlfaWQYDiABKA0SEwoLT01CQU9IRE9IQUYYCiABKA0SEwoLQklMS0ZO",
            "QUxHTEEYDCABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.FinishChessRogueSubStoryCsReq), global::EggLink.DanhengServer.Proto.FinishChessRogueSubStoryCsReq.Parser, new[]{ "ChessRogueSubStoryId", "OMBAOHDOHAF", "BILKFNALGLA" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class FinishChessRogueSubStoryCsReq : pb::IMessage<FinishChessRogueSubStoryCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FinishChessRogueSubStoryCsReq> _parser = new pb::MessageParser<FinishChessRogueSubStoryCsReq>(() => new FinishChessRogueSubStoryCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FinishChessRogueSubStoryCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.FinishChessRogueSubStoryCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FinishChessRogueSubStoryCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FinishChessRogueSubStoryCsReq(FinishChessRogueSubStoryCsReq other) : this() {
      chessRogueSubStoryId_ = other.chessRogueSubStoryId_;
      oMBAOHDOHAF_ = other.oMBAOHDOHAF_;
      bILKFNALGLA_ = other.bILKFNALGLA_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FinishChessRogueSubStoryCsReq Clone() {
      return new FinishChessRogueSubStoryCsReq(this);
    }

    /// <summary>Field number for the "chess_rogue_sub_story_id" field.</summary>
    public const int ChessRogueSubStoryIdFieldNumber = 14;
    private uint chessRogueSubStoryId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChessRogueSubStoryId {
      get { return chessRogueSubStoryId_; }
      set {
        chessRogueSubStoryId_ = value;
      }
    }

    /// <summary>Field number for the "OMBAOHDOHAF" field.</summary>
    public const int OMBAOHDOHAFFieldNumber = 10;
    private uint oMBAOHDOHAF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OMBAOHDOHAF {
      get { return oMBAOHDOHAF_; }
      set {
        oMBAOHDOHAF_ = value;
      }
    }

    /// <summary>Field number for the "BILKFNALGLA" field.</summary>
    public const int BILKFNALGLAFieldNumber = 12;
    private uint bILKFNALGLA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BILKFNALGLA {
      get { return bILKFNALGLA_; }
      set {
        bILKFNALGLA_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FinishChessRogueSubStoryCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FinishChessRogueSubStoryCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ChessRogueSubStoryId != other.ChessRogueSubStoryId) return false;
      if (OMBAOHDOHAF != other.OMBAOHDOHAF) return false;
      if (BILKFNALGLA != other.BILKFNALGLA) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ChessRogueSubStoryId != 0) hash ^= ChessRogueSubStoryId.GetHashCode();
      if (OMBAOHDOHAF != 0) hash ^= OMBAOHDOHAF.GetHashCode();
      if (BILKFNALGLA != 0) hash ^= BILKFNALGLA.GetHashCode();
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
      if (OMBAOHDOHAF != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(OMBAOHDOHAF);
      }
      if (BILKFNALGLA != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(BILKFNALGLA);
      }
      if (ChessRogueSubStoryId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(ChessRogueSubStoryId);
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
      if (OMBAOHDOHAF != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(OMBAOHDOHAF);
      }
      if (BILKFNALGLA != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(BILKFNALGLA);
      }
      if (ChessRogueSubStoryId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(ChessRogueSubStoryId);
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
      if (ChessRogueSubStoryId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChessRogueSubStoryId);
      }
      if (OMBAOHDOHAF != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OMBAOHDOHAF);
      }
      if (BILKFNALGLA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BILKFNALGLA);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FinishChessRogueSubStoryCsReq other) {
      if (other == null) {
        return;
      }
      if (other.ChessRogueSubStoryId != 0) {
        ChessRogueSubStoryId = other.ChessRogueSubStoryId;
      }
      if (other.OMBAOHDOHAF != 0) {
        OMBAOHDOHAF = other.OMBAOHDOHAF;
      }
      if (other.BILKFNALGLA != 0) {
        BILKFNALGLA = other.BILKFNALGLA;
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
          case 80: {
            OMBAOHDOHAF = input.ReadUInt32();
            break;
          }
          case 96: {
            BILKFNALGLA = input.ReadUInt32();
            break;
          }
          case 112: {
            ChessRogueSubStoryId = input.ReadUInt32();
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
          case 80: {
            OMBAOHDOHAF = input.ReadUInt32();
            break;
          }
          case 96: {
            BILKFNALGLA = input.ReadUInt32();
            break;
          }
          case 112: {
            ChessRogueSubStoryId = input.ReadUInt32();
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
