// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: UpdateTrackMainMissionIdScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from UpdateTrackMainMissionIdScRsp.proto</summary>
  public static partial class UpdateTrackMainMissionIdScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for UpdateTrackMainMissionIdScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UpdateTrackMainMissionIdScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNVcGRhdGVUcmFja01haW5NaXNzaW9uSWRTY1JzcC5wcm90byJaCh1VcGRh",
            "dGVUcmFja01haW5NaXNzaW9uSWRTY1JzcBITCgtFQU9KQUtETEZPQxgDIAEo",
            "DRITCgtFS01PTkFDQkRLSxgEIAEoDRIPCgdyZXRjb2RlGAYgASgNQh6qAhtF",
            "Z2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.UpdateTrackMainMissionIdScRsp), global::EggLink.DanhengServer.Proto.UpdateTrackMainMissionIdScRsp.Parser, new[]{ "EAOJAKDLFOC", "EKMONACBDKK", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class UpdateTrackMainMissionIdScRsp : pb::IMessage<UpdateTrackMainMissionIdScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UpdateTrackMainMissionIdScRsp> _parser = new pb::MessageParser<UpdateTrackMainMissionIdScRsp>(() => new UpdateTrackMainMissionIdScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<UpdateTrackMainMissionIdScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.UpdateTrackMainMissionIdScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UpdateTrackMainMissionIdScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UpdateTrackMainMissionIdScRsp(UpdateTrackMainMissionIdScRsp other) : this() {
      eAOJAKDLFOC_ = other.eAOJAKDLFOC_;
      eKMONACBDKK_ = other.eKMONACBDKK_;
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UpdateTrackMainMissionIdScRsp Clone() {
      return new UpdateTrackMainMissionIdScRsp(this);
    }

    /// <summary>Field number for the "EAOJAKDLFOC" field.</summary>
    public const int EAOJAKDLFOCFieldNumber = 3;
    private uint eAOJAKDLFOC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EAOJAKDLFOC {
      get { return eAOJAKDLFOC_; }
      set {
        eAOJAKDLFOC_ = value;
      }
    }

    /// <summary>Field number for the "EKMONACBDKK" field.</summary>
    public const int EKMONACBDKKFieldNumber = 4;
    private uint eKMONACBDKK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EKMONACBDKK {
      get { return eKMONACBDKK_; }
      set {
        eKMONACBDKK_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 6;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as UpdateTrackMainMissionIdScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(UpdateTrackMainMissionIdScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EAOJAKDLFOC != other.EAOJAKDLFOC) return false;
      if (EKMONACBDKK != other.EKMONACBDKK) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EAOJAKDLFOC != 0) hash ^= EAOJAKDLFOC.GetHashCode();
      if (EKMONACBDKK != 0) hash ^= EKMONACBDKK.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
      if (EAOJAKDLFOC != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(EAOJAKDLFOC);
      }
      if (EKMONACBDKK != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(EKMONACBDKK);
      }
      if (Retcode != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Retcode);
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
      if (EAOJAKDLFOC != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(EAOJAKDLFOC);
      }
      if (EKMONACBDKK != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(EKMONACBDKK);
      }
      if (Retcode != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Retcode);
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
      if (EAOJAKDLFOC != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EAOJAKDLFOC);
      }
      if (EKMONACBDKK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EKMONACBDKK);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(UpdateTrackMainMissionIdScRsp other) {
      if (other == null) {
        return;
      }
      if (other.EAOJAKDLFOC != 0) {
        EAOJAKDLFOC = other.EAOJAKDLFOC;
      }
      if (other.EKMONACBDKK != 0) {
        EKMONACBDKK = other.EKMONACBDKK;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
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
          case 24: {
            EAOJAKDLFOC = input.ReadUInt32();
            break;
          }
          case 32: {
            EKMONACBDKK = input.ReadUInt32();
            break;
          }
          case 48: {
            Retcode = input.ReadUInt32();
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
          case 24: {
            EAOJAKDLFOC = input.ReadUInt32();
            break;
          }
          case 32: {
            EKMONACBDKK = input.ReadUInt32();
            break;
          }
          case 48: {
            Retcode = input.ReadUInt32();
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
