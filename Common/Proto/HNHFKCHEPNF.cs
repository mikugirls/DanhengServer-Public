// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HNHFKCHEPNF.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from HNHFKCHEPNF.proto</summary>
  public static partial class HNHFKCHEPNFReflection {

    #region Descriptor
    /// <summary>File descriptor for HNHFKCHEPNF.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HNHFKCHEPNFReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFITkhGS0NIRVBORi5wcm90byJICgtITkhGS0NIRVBORhITCgtJTVBFTUpK",
            "SE5OQhgCIAMoDRITCgtOT0hQUElQTFBKRhgFIAEoDRIPCgdpc19kb25lGAgg",
            "ASgIQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.HNHFKCHEPNF), global::EggLink.DanhengServer.Proto.HNHFKCHEPNF.Parser, new[]{ "IMPEMJJHNNB", "NOHPPIPLPJF", "IsDone" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class HNHFKCHEPNF : pb::IMessage<HNHFKCHEPNF>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HNHFKCHEPNF> _parser = new pb::MessageParser<HNHFKCHEPNF>(() => new HNHFKCHEPNF());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HNHFKCHEPNF> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.HNHFKCHEPNFReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HNHFKCHEPNF() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HNHFKCHEPNF(HNHFKCHEPNF other) : this() {
      iMPEMJJHNNB_ = other.iMPEMJJHNNB_.Clone();
      nOHPPIPLPJF_ = other.nOHPPIPLPJF_;
      isDone_ = other.isDone_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HNHFKCHEPNF Clone() {
      return new HNHFKCHEPNF(this);
    }

    /// <summary>Field number for the "IMPEMJJHNNB" field.</summary>
    public const int IMPEMJJHNNBFieldNumber = 2;
    private static readonly pb::FieldCodec<uint> _repeated_iMPEMJJHNNB_codec
        = pb::FieldCodec.ForUInt32(18);
    private readonly pbc::RepeatedField<uint> iMPEMJJHNNB_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> IMPEMJJHNNB {
      get { return iMPEMJJHNNB_; }
    }

    /// <summary>Field number for the "NOHPPIPLPJF" field.</summary>
    public const int NOHPPIPLPJFFieldNumber = 5;
    private uint nOHPPIPLPJF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NOHPPIPLPJF {
      get { return nOHPPIPLPJF_; }
      set {
        nOHPPIPLPJF_ = value;
      }
    }

    /// <summary>Field number for the "is_done" field.</summary>
    public const int IsDoneFieldNumber = 8;
    private bool isDone_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsDone {
      get { return isDone_; }
      set {
        isDone_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HNHFKCHEPNF);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HNHFKCHEPNF other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!iMPEMJJHNNB_.Equals(other.iMPEMJJHNNB_)) return false;
      if (NOHPPIPLPJF != other.NOHPPIPLPJF) return false;
      if (IsDone != other.IsDone) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= iMPEMJJHNNB_.GetHashCode();
      if (NOHPPIPLPJF != 0) hash ^= NOHPPIPLPJF.GetHashCode();
      if (IsDone != false) hash ^= IsDone.GetHashCode();
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
      iMPEMJJHNNB_.WriteTo(output, _repeated_iMPEMJJHNNB_codec);
      if (NOHPPIPLPJF != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(NOHPPIPLPJF);
      }
      if (IsDone != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsDone);
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
      iMPEMJJHNNB_.WriteTo(ref output, _repeated_iMPEMJJHNNB_codec);
      if (NOHPPIPLPJF != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(NOHPPIPLPJF);
      }
      if (IsDone != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsDone);
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
      size += iMPEMJJHNNB_.CalculateSize(_repeated_iMPEMJJHNNB_codec);
      if (NOHPPIPLPJF != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NOHPPIPLPJF);
      }
      if (IsDone != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HNHFKCHEPNF other) {
      if (other == null) {
        return;
      }
      iMPEMJJHNNB_.Add(other.iMPEMJJHNNB_);
      if (other.NOHPPIPLPJF != 0) {
        NOHPPIPLPJF = other.NOHPPIPLPJF;
      }
      if (other.IsDone != false) {
        IsDone = other.IsDone;
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
          case 18:
          case 16: {
            iMPEMJJHNNB_.AddEntriesFrom(input, _repeated_iMPEMJJHNNB_codec);
            break;
          }
          case 40: {
            NOHPPIPLPJF = input.ReadUInt32();
            break;
          }
          case 64: {
            IsDone = input.ReadBool();
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
          case 18:
          case 16: {
            iMPEMJJHNNB_.AddEntriesFrom(ref input, _repeated_iMPEMJJHNNB_codec);
            break;
          }
          case 40: {
            NOHPPIPLPJF = input.ReadUInt32();
            break;
          }
          case 64: {
            IsDone = input.ReadBool();
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
