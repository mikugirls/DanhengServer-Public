// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WolfBroGameData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from WolfBroGameData.proto</summary>
  public static partial class WolfBroGameDataReflection {

    #region Descriptor
    /// <summary>File descriptor for WolfBroGameData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WolfBroGameDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVXb2xmQnJvR2FtZURhdGEucHJvdG8aFVdvbGZCcm9HYW1lSW5mby5wcm90",
            "bxoMVmVjdG9yLnByb3RvIqEBCg9Xb2xmQnJvR2FtZURhdGESJQoLUEZQRURE",
            "RUZOSkwYBCABKAsyEC5Xb2xmQnJvR2FtZUluZm8SCgoCaWQYDiABKA0SEwoL",
            "TEZFSE5GT1BKQ0wYCiABKAgSEwoLRUdLRU1QS0hFSEUYAiABKAkSHAoLTUNK",
            "SktCSExBSk4YByADKAsyBy5WZWN0b3ISEwoLQ0hHR0pHSEJOQk0YDyABKA1C",
            "HqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.WolfBroGameInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.WolfBroGameData), global::EggLink.DanhengServer.Proto.WolfBroGameData.Parser, new[]{ "PFPEDDEFNJL", "Id", "LFEHNFOPJCL", "EGKEMPKHEHE", "MCJJKBHLAJN", "CHGGJGHBNBM" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class WolfBroGameData : pb::IMessage<WolfBroGameData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<WolfBroGameData> _parser = new pb::MessageParser<WolfBroGameData>(() => new WolfBroGameData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<WolfBroGameData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.WolfBroGameDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WolfBroGameData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WolfBroGameData(WolfBroGameData other) : this() {
      pFPEDDEFNJL_ = other.pFPEDDEFNJL_ != null ? other.pFPEDDEFNJL_.Clone() : null;
      id_ = other.id_;
      lFEHNFOPJCL_ = other.lFEHNFOPJCL_;
      eGKEMPKHEHE_ = other.eGKEMPKHEHE_;
      mCJJKBHLAJN_ = other.mCJJKBHLAJN_.Clone();
      cHGGJGHBNBM_ = other.cHGGJGHBNBM_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WolfBroGameData Clone() {
      return new WolfBroGameData(this);
    }

    /// <summary>Field number for the "PFPEDDEFNJL" field.</summary>
    public const int PFPEDDEFNJLFieldNumber = 4;
    private global::EggLink.DanhengServer.Proto.WolfBroGameInfo pFPEDDEFNJL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.WolfBroGameInfo PFPEDDEFNJL {
      get { return pFPEDDEFNJL_; }
      set {
        pFPEDDEFNJL_ = value;
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 14;
    private uint id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "LFEHNFOPJCL" field.</summary>
    public const int LFEHNFOPJCLFieldNumber = 10;
    private bool lFEHNFOPJCL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool LFEHNFOPJCL {
      get { return lFEHNFOPJCL_; }
      set {
        lFEHNFOPJCL_ = value;
      }
    }

    /// <summary>Field number for the "EGKEMPKHEHE" field.</summary>
    public const int EGKEMPKHEHEFieldNumber = 2;
    private string eGKEMPKHEHE_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string EGKEMPKHEHE {
      get { return eGKEMPKHEHE_; }
      set {
        eGKEMPKHEHE_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "MCJJKBHLAJN" field.</summary>
    public const int MCJJKBHLAJNFieldNumber = 7;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.Vector> _repeated_mCJJKBHLAJN_codec
        = pb::FieldCodec.ForMessage(58, global::EggLink.DanhengServer.Proto.Vector.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Vector> mCJJKBHLAJN_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Vector>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Vector> MCJJKBHLAJN {
      get { return mCJJKBHLAJN_; }
    }

    /// <summary>Field number for the "CHGGJGHBNBM" field.</summary>
    public const int CHGGJGHBNBMFieldNumber = 15;
    private uint cHGGJGHBNBM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CHGGJGHBNBM {
      get { return cHGGJGHBNBM_; }
      set {
        cHGGJGHBNBM_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as WolfBroGameData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(WolfBroGameData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(PFPEDDEFNJL, other.PFPEDDEFNJL)) return false;
      if (Id != other.Id) return false;
      if (LFEHNFOPJCL != other.LFEHNFOPJCL) return false;
      if (EGKEMPKHEHE != other.EGKEMPKHEHE) return false;
      if(!mCJJKBHLAJN_.Equals(other.mCJJKBHLAJN_)) return false;
      if (CHGGJGHBNBM != other.CHGGJGHBNBM) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (pFPEDDEFNJL_ != null) hash ^= PFPEDDEFNJL.GetHashCode();
      if (Id != 0) hash ^= Id.GetHashCode();
      if (LFEHNFOPJCL != false) hash ^= LFEHNFOPJCL.GetHashCode();
      if (EGKEMPKHEHE.Length != 0) hash ^= EGKEMPKHEHE.GetHashCode();
      hash ^= mCJJKBHLAJN_.GetHashCode();
      if (CHGGJGHBNBM != 0) hash ^= CHGGJGHBNBM.GetHashCode();
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
      if (EGKEMPKHEHE.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(EGKEMPKHEHE);
      }
      if (pFPEDDEFNJL_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(PFPEDDEFNJL);
      }
      mCJJKBHLAJN_.WriteTo(output, _repeated_mCJJKBHLAJN_codec);
      if (LFEHNFOPJCL != false) {
        output.WriteRawTag(80);
        output.WriteBool(LFEHNFOPJCL);
      }
      if (Id != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Id);
      }
      if (CHGGJGHBNBM != 0) {
        output.WriteRawTag(120);
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
      if (EGKEMPKHEHE.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(EGKEMPKHEHE);
      }
      if (pFPEDDEFNJL_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(PFPEDDEFNJL);
      }
      mCJJKBHLAJN_.WriteTo(ref output, _repeated_mCJJKBHLAJN_codec);
      if (LFEHNFOPJCL != false) {
        output.WriteRawTag(80);
        output.WriteBool(LFEHNFOPJCL);
      }
      if (Id != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Id);
      }
      if (CHGGJGHBNBM != 0) {
        output.WriteRawTag(120);
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
      if (pFPEDDEFNJL_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PFPEDDEFNJL);
      }
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
      }
      if (LFEHNFOPJCL != false) {
        size += 1 + 1;
      }
      if (EGKEMPKHEHE.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(EGKEMPKHEHE);
      }
      size += mCJJKBHLAJN_.CalculateSize(_repeated_mCJJKBHLAJN_codec);
      if (CHGGJGHBNBM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CHGGJGHBNBM);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(WolfBroGameData other) {
      if (other == null) {
        return;
      }
      if (other.pFPEDDEFNJL_ != null) {
        if (pFPEDDEFNJL_ == null) {
          PFPEDDEFNJL = new global::EggLink.DanhengServer.Proto.WolfBroGameInfo();
        }
        PFPEDDEFNJL.MergeFrom(other.PFPEDDEFNJL);
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.LFEHNFOPJCL != false) {
        LFEHNFOPJCL = other.LFEHNFOPJCL;
      }
      if (other.EGKEMPKHEHE.Length != 0) {
        EGKEMPKHEHE = other.EGKEMPKHEHE;
      }
      mCJJKBHLAJN_.Add(other.mCJJKBHLAJN_);
      if (other.CHGGJGHBNBM != 0) {
        CHGGJGHBNBM = other.CHGGJGHBNBM;
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
            EGKEMPKHEHE = input.ReadString();
            break;
          }
          case 34: {
            if (pFPEDDEFNJL_ == null) {
              PFPEDDEFNJL = new global::EggLink.DanhengServer.Proto.WolfBroGameInfo();
            }
            input.ReadMessage(PFPEDDEFNJL);
            break;
          }
          case 58: {
            mCJJKBHLAJN_.AddEntriesFrom(input, _repeated_mCJJKBHLAJN_codec);
            break;
          }
          case 80: {
            LFEHNFOPJCL = input.ReadBool();
            break;
          }
          case 112: {
            Id = input.ReadUInt32();
            break;
          }
          case 120: {
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
          case 18: {
            EGKEMPKHEHE = input.ReadString();
            break;
          }
          case 34: {
            if (pFPEDDEFNJL_ == null) {
              PFPEDDEFNJL = new global::EggLink.DanhengServer.Proto.WolfBroGameInfo();
            }
            input.ReadMessage(PFPEDDEFNJL);
            break;
          }
          case 58: {
            mCJJKBHLAJN_.AddEntriesFrom(ref input, _repeated_mCJJKBHLAJN_codec);
            break;
          }
          case 80: {
            LFEHNFOPJCL = input.ReadBool();
            break;
          }
          case 112: {
            Id = input.ReadUInt32();
            break;
          }
          case 120: {
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