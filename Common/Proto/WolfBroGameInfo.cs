// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WolfBroGameInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from WolfBroGameInfo.proto</summary>
  public static partial class WolfBroGameInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for WolfBroGameInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WolfBroGameInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVXb2xmQnJvR2FtZUluZm8ucHJvdG8aDFZlY3Rvci5wcm90bxoQTW90aW9u",
            "SW5mby5wcm90byJ2Cg9Xb2xmQnJvR2FtZUluZm8SEwoLQ0hHR0pHSEJOQk0Y",
            "DCABKA0SGwoGbW90aW9uGAYgASgLMgsuTW90aW9uSW5mbxITCgtMRkVITkZP",
            "UEpDTBgCIAEoCBIcCgtNQ0pKS0JITEFKThgEIAMoCzIHLlZlY3RvckIeqgIb",
            "RWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.VectorReflection.Descriptor, global::EggLink.DanhengServer.Proto.MotionInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.WolfBroGameInfo), global::EggLink.DanhengServer.Proto.WolfBroGameInfo.Parser, new[]{ "CHGGJGHBNBM", "Motion", "LFEHNFOPJCL", "MCJJKBHLAJN" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class WolfBroGameInfo : pb::IMessage<WolfBroGameInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<WolfBroGameInfo> _parser = new pb::MessageParser<WolfBroGameInfo>(() => new WolfBroGameInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<WolfBroGameInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.WolfBroGameInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WolfBroGameInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WolfBroGameInfo(WolfBroGameInfo other) : this() {
      cHGGJGHBNBM_ = other.cHGGJGHBNBM_;
      motion_ = other.motion_ != null ? other.motion_.Clone() : null;
      lFEHNFOPJCL_ = other.lFEHNFOPJCL_;
      mCJJKBHLAJN_ = other.mCJJKBHLAJN_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WolfBroGameInfo Clone() {
      return new WolfBroGameInfo(this);
    }

    /// <summary>Field number for the "CHGGJGHBNBM" field.</summary>
    public const int CHGGJGHBNBMFieldNumber = 12;
    private uint cHGGJGHBNBM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CHGGJGHBNBM {
      get { return cHGGJGHBNBM_; }
      set {
        cHGGJGHBNBM_ = value;
      }
    }

    /// <summary>Field number for the "motion" field.</summary>
    public const int MotionFieldNumber = 6;
    private global::EggLink.DanhengServer.Proto.MotionInfo motion_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.MotionInfo Motion {
      get { return motion_; }
      set {
        motion_ = value;
      }
    }

    /// <summary>Field number for the "LFEHNFOPJCL" field.</summary>
    public const int LFEHNFOPJCLFieldNumber = 2;
    private bool lFEHNFOPJCL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool LFEHNFOPJCL {
      get { return lFEHNFOPJCL_; }
      set {
        lFEHNFOPJCL_ = value;
      }
    }

    /// <summary>Field number for the "MCJJKBHLAJN" field.</summary>
    public const int MCJJKBHLAJNFieldNumber = 4;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.Vector> _repeated_mCJJKBHLAJN_codec
        = pb::FieldCodec.ForMessage(34, global::EggLink.DanhengServer.Proto.Vector.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Vector> mCJJKBHLAJN_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Vector>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Vector> MCJJKBHLAJN {
      get { return mCJJKBHLAJN_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as WolfBroGameInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(WolfBroGameInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CHGGJGHBNBM != other.CHGGJGHBNBM) return false;
      if (!object.Equals(Motion, other.Motion)) return false;
      if (LFEHNFOPJCL != other.LFEHNFOPJCL) return false;
      if(!mCJJKBHLAJN_.Equals(other.mCJJKBHLAJN_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CHGGJGHBNBM != 0) hash ^= CHGGJGHBNBM.GetHashCode();
      if (motion_ != null) hash ^= Motion.GetHashCode();
      if (LFEHNFOPJCL != false) hash ^= LFEHNFOPJCL.GetHashCode();
      hash ^= mCJJKBHLAJN_.GetHashCode();
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
      if (LFEHNFOPJCL != false) {
        output.WriteRawTag(16);
        output.WriteBool(LFEHNFOPJCL);
      }
      mCJJKBHLAJN_.WriteTo(output, _repeated_mCJJKBHLAJN_codec);
      if (motion_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(Motion);
      }
      if (CHGGJGHBNBM != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(CHGGJGHBNBM);
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
      if (LFEHNFOPJCL != false) {
        output.WriteRawTag(16);
        output.WriteBool(LFEHNFOPJCL);
      }
      mCJJKBHLAJN_.WriteTo(ref output, _repeated_mCJJKBHLAJN_codec);
      if (motion_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(Motion);
      }
      if (CHGGJGHBNBM != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(CHGGJGHBNBM);
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
      if (CHGGJGHBNBM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CHGGJGHBNBM);
      }
      if (motion_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Motion);
      }
      if (LFEHNFOPJCL != false) {
        size += 1 + 1;
      }
      size += mCJJKBHLAJN_.CalculateSize(_repeated_mCJJKBHLAJN_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(WolfBroGameInfo other) {
      if (other == null) {
        return;
      }
      if (other.CHGGJGHBNBM != 0) {
        CHGGJGHBNBM = other.CHGGJGHBNBM;
      }
      if (other.motion_ != null) {
        if (motion_ == null) {
          Motion = new global::EggLink.DanhengServer.Proto.MotionInfo();
        }
        Motion.MergeFrom(other.Motion);
      }
      if (other.LFEHNFOPJCL != false) {
        LFEHNFOPJCL = other.LFEHNFOPJCL;
      }
      mCJJKBHLAJN_.Add(other.mCJJKBHLAJN_);
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
          case 16: {
            LFEHNFOPJCL = input.ReadBool();
            break;
          }
          case 34: {
            mCJJKBHLAJN_.AddEntriesFrom(input, _repeated_mCJJKBHLAJN_codec);
            break;
          }
          case 50: {
            if (motion_ == null) {
              Motion = new global::EggLink.DanhengServer.Proto.MotionInfo();
            }
            input.ReadMessage(Motion);
            break;
          }
          case 96: {
            CHGGJGHBNBM = input.ReadUInt32();
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
          case 16: {
            LFEHNFOPJCL = input.ReadBool();
            break;
          }
          case 34: {
            mCJJKBHLAJN_.AddEntriesFrom(ref input, _repeated_mCJJKBHLAJN_codec);
            break;
          }
          case 50: {
            if (motion_ == null) {
              Motion = new global::EggLink.DanhengServer.Proto.MotionInfo();
            }
            input.ReadMessage(Motion);
            break;
          }
          case 96: {
            CHGGJGHBNBM = input.ReadUInt32();
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
