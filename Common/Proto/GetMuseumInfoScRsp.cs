// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetMuseumInfoScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetMuseumInfoScRsp.proto</summary>
  public static partial class GetMuseumInfoScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetMuseumInfoScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetMuseumInfoScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhHZXRNdXNldW1JbmZvU2NSc3AucHJvdG8aEUtNSEJDREtOSktOLnByb3Rv",
            "GhFERUhOSEpGRExDRC5wcm90bxoRTk9GSlBHTU5JRU8ucHJvdG8aEUJMQ0tN",
            "SENPTktQLnByb3RvIuACChJHZXRNdXNldW1JbmZvU2NSc3ASEwoLT0VETUtO",
            "TEdCQ1AYCiABKA0SIQoLUE5ORUxQSU5CUEYYBiADKAsyDC5OT0ZKUEdNTklF",
            "TxITCgtITlBDUEtGUEhHQhgLIAEoDRITCgtFT0hNS0RQSUVOSRgMIAMoDRIT",
            "CgtCRVBMSEJQQkxJTxgEIAEoDRITCgtLREZNSEJKTEZPShgPIAEoDRITCgtI",
            "R0VBRUlDT0NFQxgOIAMoDRIhCgtEUElKQkRISE9MTxgNIAMoCzIMLktNSEJD",
            "REtOSktOEhMKC0pHQU9NTkVLR0RLGAcgASgNEgsKA2V4cBgJIAEoDRIhCgtP",
            "REJHTFBOSU5KTRgIIAEoCzIMLkRFSE5ISkZETENEEg0KBWxldmVsGAUgASgN",
            "EiEKC0RQRkNHR0NKRUNCGAIgASgLMgwuQkxDS01IQ09OS1ASDwoHcmV0Y29k",
            "ZRgDIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.KMHBCDKNJKNReflection.Descriptor, global::EggLink.DanhengServer.Proto.DEHNHJFDLCDReflection.Descriptor, global::EggLink.DanhengServer.Proto.NOFJPGMNIEOReflection.Descriptor, global::EggLink.DanhengServer.Proto.BLCKMHCONKPReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetMuseumInfoScRsp), global::EggLink.DanhengServer.Proto.GetMuseumInfoScRsp.Parser, new[]{ "OEDMKNLGBCP", "PNNELPINBPF", "HNPCPKFPHGB", "EOHMKDPIENI", "BEPLHBPBLIO", "KDFMHBJLFOJ", "HGEAEICOCEC", "DPIJBDHHOLO", "JGAOMNEKGDK", "Exp", "ODBGLPNINJM", "Level", "DPFCGGCJECB", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetMuseumInfoScRsp : pb::IMessage<GetMuseumInfoScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetMuseumInfoScRsp> _parser = new pb::MessageParser<GetMuseumInfoScRsp>(() => new GetMuseumInfoScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetMuseumInfoScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetMuseumInfoScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetMuseumInfoScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetMuseumInfoScRsp(GetMuseumInfoScRsp other) : this() {
      oEDMKNLGBCP_ = other.oEDMKNLGBCP_;
      pNNELPINBPF_ = other.pNNELPINBPF_.Clone();
      hNPCPKFPHGB_ = other.hNPCPKFPHGB_;
      eOHMKDPIENI_ = other.eOHMKDPIENI_.Clone();
      bEPLHBPBLIO_ = other.bEPLHBPBLIO_;
      kDFMHBJLFOJ_ = other.kDFMHBJLFOJ_;
      hGEAEICOCEC_ = other.hGEAEICOCEC_.Clone();
      dPIJBDHHOLO_ = other.dPIJBDHHOLO_.Clone();
      jGAOMNEKGDK_ = other.jGAOMNEKGDK_;
      exp_ = other.exp_;
      oDBGLPNINJM_ = other.oDBGLPNINJM_ != null ? other.oDBGLPNINJM_.Clone() : null;
      level_ = other.level_;
      dPFCGGCJECB_ = other.dPFCGGCJECB_ != null ? other.dPFCGGCJECB_.Clone() : null;
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetMuseumInfoScRsp Clone() {
      return new GetMuseumInfoScRsp(this);
    }

    /// <summary>Field number for the "OEDMKNLGBCP" field.</summary>
    public const int OEDMKNLGBCPFieldNumber = 10;
    private uint oEDMKNLGBCP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OEDMKNLGBCP {
      get { return oEDMKNLGBCP_; }
      set {
        oEDMKNLGBCP_ = value;
      }
    }

    /// <summary>Field number for the "PNNELPINBPF" field.</summary>
    public const int PNNELPINBPFFieldNumber = 6;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.NOFJPGMNIEO> _repeated_pNNELPINBPF_codec
        = pb::FieldCodec.ForMessage(50, global::EggLink.DanhengServer.Proto.NOFJPGMNIEO.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.NOFJPGMNIEO> pNNELPINBPF_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.NOFJPGMNIEO>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.NOFJPGMNIEO> PNNELPINBPF {
      get { return pNNELPINBPF_; }
    }

    /// <summary>Field number for the "HNPCPKFPHGB" field.</summary>
    public const int HNPCPKFPHGBFieldNumber = 11;
    private uint hNPCPKFPHGB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HNPCPKFPHGB {
      get { return hNPCPKFPHGB_; }
      set {
        hNPCPKFPHGB_ = value;
      }
    }

    /// <summary>Field number for the "EOHMKDPIENI" field.</summary>
    public const int EOHMKDPIENIFieldNumber = 12;
    private static readonly pb::FieldCodec<uint> _repeated_eOHMKDPIENI_codec
        = pb::FieldCodec.ForUInt32(98);
    private readonly pbc::RepeatedField<uint> eOHMKDPIENI_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> EOHMKDPIENI {
      get { return eOHMKDPIENI_; }
    }

    /// <summary>Field number for the "BEPLHBPBLIO" field.</summary>
    public const int BEPLHBPBLIOFieldNumber = 4;
    private uint bEPLHBPBLIO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BEPLHBPBLIO {
      get { return bEPLHBPBLIO_; }
      set {
        bEPLHBPBLIO_ = value;
      }
    }

    /// <summary>Field number for the "KDFMHBJLFOJ" field.</summary>
    public const int KDFMHBJLFOJFieldNumber = 15;
    private uint kDFMHBJLFOJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KDFMHBJLFOJ {
      get { return kDFMHBJLFOJ_; }
      set {
        kDFMHBJLFOJ_ = value;
      }
    }

    /// <summary>Field number for the "HGEAEICOCEC" field.</summary>
    public const int HGEAEICOCECFieldNumber = 14;
    private static readonly pb::FieldCodec<uint> _repeated_hGEAEICOCEC_codec
        = pb::FieldCodec.ForUInt32(114);
    private readonly pbc::RepeatedField<uint> hGEAEICOCEC_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> HGEAEICOCEC {
      get { return hGEAEICOCEC_; }
    }

    /// <summary>Field number for the "DPIJBDHHOLO" field.</summary>
    public const int DPIJBDHHOLOFieldNumber = 13;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.KMHBCDKNJKN> _repeated_dPIJBDHHOLO_codec
        = pb::FieldCodec.ForMessage(106, global::EggLink.DanhengServer.Proto.KMHBCDKNJKN.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.KMHBCDKNJKN> dPIJBDHHOLO_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.KMHBCDKNJKN>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.KMHBCDKNJKN> DPIJBDHHOLO {
      get { return dPIJBDHHOLO_; }
    }

    /// <summary>Field number for the "JGAOMNEKGDK" field.</summary>
    public const int JGAOMNEKGDKFieldNumber = 7;
    private uint jGAOMNEKGDK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint JGAOMNEKGDK {
      get { return jGAOMNEKGDK_; }
      set {
        jGAOMNEKGDK_ = value;
      }
    }

    /// <summary>Field number for the "exp" field.</summary>
    public const int ExpFieldNumber = 9;
    private uint exp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Exp {
      get { return exp_; }
      set {
        exp_ = value;
      }
    }

    /// <summary>Field number for the "ODBGLPNINJM" field.</summary>
    public const int ODBGLPNINJMFieldNumber = 8;
    private global::EggLink.DanhengServer.Proto.DEHNHJFDLCD oDBGLPNINJM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.DEHNHJFDLCD ODBGLPNINJM {
      get { return oDBGLPNINJM_; }
      set {
        oDBGLPNINJM_ = value;
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 5;
    private uint level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "DPFCGGCJECB" field.</summary>
    public const int DPFCGGCJECBFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.BLCKMHCONKP dPFCGGCJECB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.BLCKMHCONKP DPFCGGCJECB {
      get { return dPFCGGCJECB_; }
      set {
        dPFCGGCJECB_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 3;
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
      return Equals(other as GetMuseumInfoScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetMuseumInfoScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (OEDMKNLGBCP != other.OEDMKNLGBCP) return false;
      if(!pNNELPINBPF_.Equals(other.pNNELPINBPF_)) return false;
      if (HNPCPKFPHGB != other.HNPCPKFPHGB) return false;
      if(!eOHMKDPIENI_.Equals(other.eOHMKDPIENI_)) return false;
      if (BEPLHBPBLIO != other.BEPLHBPBLIO) return false;
      if (KDFMHBJLFOJ != other.KDFMHBJLFOJ) return false;
      if(!hGEAEICOCEC_.Equals(other.hGEAEICOCEC_)) return false;
      if(!dPIJBDHHOLO_.Equals(other.dPIJBDHHOLO_)) return false;
      if (JGAOMNEKGDK != other.JGAOMNEKGDK) return false;
      if (Exp != other.Exp) return false;
      if (!object.Equals(ODBGLPNINJM, other.ODBGLPNINJM)) return false;
      if (Level != other.Level) return false;
      if (!object.Equals(DPFCGGCJECB, other.DPFCGGCJECB)) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (OEDMKNLGBCP != 0) hash ^= OEDMKNLGBCP.GetHashCode();
      hash ^= pNNELPINBPF_.GetHashCode();
      if (HNPCPKFPHGB != 0) hash ^= HNPCPKFPHGB.GetHashCode();
      hash ^= eOHMKDPIENI_.GetHashCode();
      if (BEPLHBPBLIO != 0) hash ^= BEPLHBPBLIO.GetHashCode();
      if (KDFMHBJLFOJ != 0) hash ^= KDFMHBJLFOJ.GetHashCode();
      hash ^= hGEAEICOCEC_.GetHashCode();
      hash ^= dPIJBDHHOLO_.GetHashCode();
      if (JGAOMNEKGDK != 0) hash ^= JGAOMNEKGDK.GetHashCode();
      if (Exp != 0) hash ^= Exp.GetHashCode();
      if (oDBGLPNINJM_ != null) hash ^= ODBGLPNINJM.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      if (dPFCGGCJECB_ != null) hash ^= DPFCGGCJECB.GetHashCode();
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
      if (dPFCGGCJECB_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(DPFCGGCJECB);
      }
      if (Retcode != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Retcode);
      }
      if (BEPLHBPBLIO != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(BEPLHBPBLIO);
      }
      if (Level != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Level);
      }
      pNNELPINBPF_.WriteTo(output, _repeated_pNNELPINBPF_codec);
      if (JGAOMNEKGDK != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(JGAOMNEKGDK);
      }
      if (oDBGLPNINJM_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(ODBGLPNINJM);
      }
      if (Exp != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Exp);
      }
      if (OEDMKNLGBCP != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(OEDMKNLGBCP);
      }
      if (HNPCPKFPHGB != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(HNPCPKFPHGB);
      }
      eOHMKDPIENI_.WriteTo(output, _repeated_eOHMKDPIENI_codec);
      dPIJBDHHOLO_.WriteTo(output, _repeated_dPIJBDHHOLO_codec);
      hGEAEICOCEC_.WriteTo(output, _repeated_hGEAEICOCEC_codec);
      if (KDFMHBJLFOJ != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(KDFMHBJLFOJ);
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
      if (dPFCGGCJECB_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(DPFCGGCJECB);
      }
      if (Retcode != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Retcode);
      }
      if (BEPLHBPBLIO != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(BEPLHBPBLIO);
      }
      if (Level != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Level);
      }
      pNNELPINBPF_.WriteTo(ref output, _repeated_pNNELPINBPF_codec);
      if (JGAOMNEKGDK != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(JGAOMNEKGDK);
      }
      if (oDBGLPNINJM_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(ODBGLPNINJM);
      }
      if (Exp != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Exp);
      }
      if (OEDMKNLGBCP != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(OEDMKNLGBCP);
      }
      if (HNPCPKFPHGB != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(HNPCPKFPHGB);
      }
      eOHMKDPIENI_.WriteTo(ref output, _repeated_eOHMKDPIENI_codec);
      dPIJBDHHOLO_.WriteTo(ref output, _repeated_dPIJBDHHOLO_codec);
      hGEAEICOCEC_.WriteTo(ref output, _repeated_hGEAEICOCEC_codec);
      if (KDFMHBJLFOJ != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(KDFMHBJLFOJ);
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
      if (OEDMKNLGBCP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OEDMKNLGBCP);
      }
      size += pNNELPINBPF_.CalculateSize(_repeated_pNNELPINBPF_codec);
      if (HNPCPKFPHGB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HNPCPKFPHGB);
      }
      size += eOHMKDPIENI_.CalculateSize(_repeated_eOHMKDPIENI_codec);
      if (BEPLHBPBLIO != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BEPLHBPBLIO);
      }
      if (KDFMHBJLFOJ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KDFMHBJLFOJ);
      }
      size += hGEAEICOCEC_.CalculateSize(_repeated_hGEAEICOCEC_codec);
      size += dPIJBDHHOLO_.CalculateSize(_repeated_dPIJBDHHOLO_codec);
      if (JGAOMNEKGDK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(JGAOMNEKGDK);
      }
      if (Exp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Exp);
      }
      if (oDBGLPNINJM_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ODBGLPNINJM);
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
      }
      if (dPFCGGCJECB_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DPFCGGCJECB);
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
    public void MergeFrom(GetMuseumInfoScRsp other) {
      if (other == null) {
        return;
      }
      if (other.OEDMKNLGBCP != 0) {
        OEDMKNLGBCP = other.OEDMKNLGBCP;
      }
      pNNELPINBPF_.Add(other.pNNELPINBPF_);
      if (other.HNPCPKFPHGB != 0) {
        HNPCPKFPHGB = other.HNPCPKFPHGB;
      }
      eOHMKDPIENI_.Add(other.eOHMKDPIENI_);
      if (other.BEPLHBPBLIO != 0) {
        BEPLHBPBLIO = other.BEPLHBPBLIO;
      }
      if (other.KDFMHBJLFOJ != 0) {
        KDFMHBJLFOJ = other.KDFMHBJLFOJ;
      }
      hGEAEICOCEC_.Add(other.hGEAEICOCEC_);
      dPIJBDHHOLO_.Add(other.dPIJBDHHOLO_);
      if (other.JGAOMNEKGDK != 0) {
        JGAOMNEKGDK = other.JGAOMNEKGDK;
      }
      if (other.Exp != 0) {
        Exp = other.Exp;
      }
      if (other.oDBGLPNINJM_ != null) {
        if (oDBGLPNINJM_ == null) {
          ODBGLPNINJM = new global::EggLink.DanhengServer.Proto.DEHNHJFDLCD();
        }
        ODBGLPNINJM.MergeFrom(other.ODBGLPNINJM);
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      if (other.dPFCGGCJECB_ != null) {
        if (dPFCGGCJECB_ == null) {
          DPFCGGCJECB = new global::EggLink.DanhengServer.Proto.BLCKMHCONKP();
        }
        DPFCGGCJECB.MergeFrom(other.DPFCGGCJECB);
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
          case 18: {
            if (dPFCGGCJECB_ == null) {
              DPFCGGCJECB = new global::EggLink.DanhengServer.Proto.BLCKMHCONKP();
            }
            input.ReadMessage(DPFCGGCJECB);
            break;
          }
          case 24: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 32: {
            BEPLHBPBLIO = input.ReadUInt32();
            break;
          }
          case 40: {
            Level = input.ReadUInt32();
            break;
          }
          case 50: {
            pNNELPINBPF_.AddEntriesFrom(input, _repeated_pNNELPINBPF_codec);
            break;
          }
          case 56: {
            JGAOMNEKGDK = input.ReadUInt32();
            break;
          }
          case 66: {
            if (oDBGLPNINJM_ == null) {
              ODBGLPNINJM = new global::EggLink.DanhengServer.Proto.DEHNHJFDLCD();
            }
            input.ReadMessage(ODBGLPNINJM);
            break;
          }
          case 72: {
            Exp = input.ReadUInt32();
            break;
          }
          case 80: {
            OEDMKNLGBCP = input.ReadUInt32();
            break;
          }
          case 88: {
            HNPCPKFPHGB = input.ReadUInt32();
            break;
          }
          case 98:
          case 96: {
            eOHMKDPIENI_.AddEntriesFrom(input, _repeated_eOHMKDPIENI_codec);
            break;
          }
          case 106: {
            dPIJBDHHOLO_.AddEntriesFrom(input, _repeated_dPIJBDHHOLO_codec);
            break;
          }
          case 114:
          case 112: {
            hGEAEICOCEC_.AddEntriesFrom(input, _repeated_hGEAEICOCEC_codec);
            break;
          }
          case 120: {
            KDFMHBJLFOJ = input.ReadUInt32();
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
            if (dPFCGGCJECB_ == null) {
              DPFCGGCJECB = new global::EggLink.DanhengServer.Proto.BLCKMHCONKP();
            }
            input.ReadMessage(DPFCGGCJECB);
            break;
          }
          case 24: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 32: {
            BEPLHBPBLIO = input.ReadUInt32();
            break;
          }
          case 40: {
            Level = input.ReadUInt32();
            break;
          }
          case 50: {
            pNNELPINBPF_.AddEntriesFrom(ref input, _repeated_pNNELPINBPF_codec);
            break;
          }
          case 56: {
            JGAOMNEKGDK = input.ReadUInt32();
            break;
          }
          case 66: {
            if (oDBGLPNINJM_ == null) {
              ODBGLPNINJM = new global::EggLink.DanhengServer.Proto.DEHNHJFDLCD();
            }
            input.ReadMessage(ODBGLPNINJM);
            break;
          }
          case 72: {
            Exp = input.ReadUInt32();
            break;
          }
          case 80: {
            OEDMKNLGBCP = input.ReadUInt32();
            break;
          }
          case 88: {
            HNPCPKFPHGB = input.ReadUInt32();
            break;
          }
          case 98:
          case 96: {
            eOHMKDPIENI_.AddEntriesFrom(ref input, _repeated_eOHMKDPIENI_codec);
            break;
          }
          case 106: {
            dPIJBDHHOLO_.AddEntriesFrom(ref input, _repeated_dPIJBDHHOLO_codec);
            break;
          }
          case 114:
          case 112: {
            hGEAEICOCEC_.AddEntriesFrom(ref input, _repeated_hGEAEICOCEC_codec);
            break;
          }
          case 120: {
            KDFMHBJLFOJ = input.ReadUInt32();
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
