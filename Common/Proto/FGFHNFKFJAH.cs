// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FGFHNFKFJAH.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from FGFHNFKFJAH.proto</summary>
  public static partial class FGFHNFKFJAHReflection {

    #region Descriptor
    /// <summary>File descriptor for FGFHNFKFJAH.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FGFHNFKFJAHReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFGR0ZITkZLRkpBSC5wcm90bxoRUE1HTUFOSkJKT0sucHJvdG8i2AEKC0ZH",
            "RkhORktGSkFIEhMKC0dCTkxESklQRUVLGAEgASgNEhMKC01PREFQSUdKTk5K",
            "GAUgASgNEhMKC0hGSkVCRUVORERIGAcgASgNEhMKC05ES09QRUpCR0FFGA8g",
            "ASgNEhMKC09ETE1PQ0RCSkhQGA0gASgNEhMKC0tPS0tHQURPQUdMGAwgASgN",
            "EhMKC0ZLQkxPR0VBRkpKGAIgASgNEiEKC01QQkZCSUtDRkpCGAQgASgLMgwu",
            "UE1HTUFOSkJKT0sSEwoLR0RITU1GRUxDREgYAyABKA1CHqoCG0VnZ0xpbmsu",
            "RGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.PMGMANJBJOKReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.FGFHNFKFJAH), global::EggLink.DanhengServer.Proto.FGFHNFKFJAH.Parser, new[]{ "GBNLDJIPEEK", "MODAPIGJNNJ", "HFJEBEENDDH", "NDKOPEJBGAE", "ODLMOCDBJHP", "KOKKGADOAGL", "FKBLOGEAFJJ", "MPBFBIKCFJB", "GDHMMFELCDH" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class FGFHNFKFJAH : pb::IMessage<FGFHNFKFJAH>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FGFHNFKFJAH> _parser = new pb::MessageParser<FGFHNFKFJAH>(() => new FGFHNFKFJAH());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FGFHNFKFJAH> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.FGFHNFKFJAHReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FGFHNFKFJAH() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FGFHNFKFJAH(FGFHNFKFJAH other) : this() {
      gBNLDJIPEEK_ = other.gBNLDJIPEEK_;
      mODAPIGJNNJ_ = other.mODAPIGJNNJ_;
      hFJEBEENDDH_ = other.hFJEBEENDDH_;
      nDKOPEJBGAE_ = other.nDKOPEJBGAE_;
      oDLMOCDBJHP_ = other.oDLMOCDBJHP_;
      kOKKGADOAGL_ = other.kOKKGADOAGL_;
      fKBLOGEAFJJ_ = other.fKBLOGEAFJJ_;
      mPBFBIKCFJB_ = other.mPBFBIKCFJB_ != null ? other.mPBFBIKCFJB_.Clone() : null;
      gDHMMFELCDH_ = other.gDHMMFELCDH_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FGFHNFKFJAH Clone() {
      return new FGFHNFKFJAH(this);
    }

    /// <summary>Field number for the "GBNLDJIPEEK" field.</summary>
    public const int GBNLDJIPEEKFieldNumber = 1;
    private uint gBNLDJIPEEK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GBNLDJIPEEK {
      get { return gBNLDJIPEEK_; }
      set {
        gBNLDJIPEEK_ = value;
      }
    }

    /// <summary>Field number for the "MODAPIGJNNJ" field.</summary>
    public const int MODAPIGJNNJFieldNumber = 5;
    private uint mODAPIGJNNJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MODAPIGJNNJ {
      get { return mODAPIGJNNJ_; }
      set {
        mODAPIGJNNJ_ = value;
      }
    }

    /// <summary>Field number for the "HFJEBEENDDH" field.</summary>
    public const int HFJEBEENDDHFieldNumber = 7;
    private uint hFJEBEENDDH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HFJEBEENDDH {
      get { return hFJEBEENDDH_; }
      set {
        hFJEBEENDDH_ = value;
      }
    }

    /// <summary>Field number for the "NDKOPEJBGAE" field.</summary>
    public const int NDKOPEJBGAEFieldNumber = 15;
    private uint nDKOPEJBGAE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NDKOPEJBGAE {
      get { return nDKOPEJBGAE_; }
      set {
        nDKOPEJBGAE_ = value;
      }
    }

    /// <summary>Field number for the "ODLMOCDBJHP" field.</summary>
    public const int ODLMOCDBJHPFieldNumber = 13;
    private uint oDLMOCDBJHP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ODLMOCDBJHP {
      get { return oDLMOCDBJHP_; }
      set {
        oDLMOCDBJHP_ = value;
      }
    }

    /// <summary>Field number for the "KOKKGADOAGL" field.</summary>
    public const int KOKKGADOAGLFieldNumber = 12;
    private uint kOKKGADOAGL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KOKKGADOAGL {
      get { return kOKKGADOAGL_; }
      set {
        kOKKGADOAGL_ = value;
      }
    }

    /// <summary>Field number for the "FKBLOGEAFJJ" field.</summary>
    public const int FKBLOGEAFJJFieldNumber = 2;
    private uint fKBLOGEAFJJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FKBLOGEAFJJ {
      get { return fKBLOGEAFJJ_; }
      set {
        fKBLOGEAFJJ_ = value;
      }
    }

    /// <summary>Field number for the "MPBFBIKCFJB" field.</summary>
    public const int MPBFBIKCFJBFieldNumber = 4;
    private global::EggLink.DanhengServer.Proto.PMGMANJBJOK mPBFBIKCFJB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.PMGMANJBJOK MPBFBIKCFJB {
      get { return mPBFBIKCFJB_; }
      set {
        mPBFBIKCFJB_ = value;
      }
    }

    /// <summary>Field number for the "GDHMMFELCDH" field.</summary>
    public const int GDHMMFELCDHFieldNumber = 3;
    private uint gDHMMFELCDH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GDHMMFELCDH {
      get { return gDHMMFELCDH_; }
      set {
        gDHMMFELCDH_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FGFHNFKFJAH);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FGFHNFKFJAH other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GBNLDJIPEEK != other.GBNLDJIPEEK) return false;
      if (MODAPIGJNNJ != other.MODAPIGJNNJ) return false;
      if (HFJEBEENDDH != other.HFJEBEENDDH) return false;
      if (NDKOPEJBGAE != other.NDKOPEJBGAE) return false;
      if (ODLMOCDBJHP != other.ODLMOCDBJHP) return false;
      if (KOKKGADOAGL != other.KOKKGADOAGL) return false;
      if (FKBLOGEAFJJ != other.FKBLOGEAFJJ) return false;
      if (!object.Equals(MPBFBIKCFJB, other.MPBFBIKCFJB)) return false;
      if (GDHMMFELCDH != other.GDHMMFELCDH) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GBNLDJIPEEK != 0) hash ^= GBNLDJIPEEK.GetHashCode();
      if (MODAPIGJNNJ != 0) hash ^= MODAPIGJNNJ.GetHashCode();
      if (HFJEBEENDDH != 0) hash ^= HFJEBEENDDH.GetHashCode();
      if (NDKOPEJBGAE != 0) hash ^= NDKOPEJBGAE.GetHashCode();
      if (ODLMOCDBJHP != 0) hash ^= ODLMOCDBJHP.GetHashCode();
      if (KOKKGADOAGL != 0) hash ^= KOKKGADOAGL.GetHashCode();
      if (FKBLOGEAFJJ != 0) hash ^= FKBLOGEAFJJ.GetHashCode();
      if (mPBFBIKCFJB_ != null) hash ^= MPBFBIKCFJB.GetHashCode();
      if (GDHMMFELCDH != 0) hash ^= GDHMMFELCDH.GetHashCode();
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
      if (GBNLDJIPEEK != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(GBNLDJIPEEK);
      }
      if (FKBLOGEAFJJ != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(FKBLOGEAFJJ);
      }
      if (GDHMMFELCDH != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(GDHMMFELCDH);
      }
      if (mPBFBIKCFJB_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(MPBFBIKCFJB);
      }
      if (MODAPIGJNNJ != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(MODAPIGJNNJ);
      }
      if (HFJEBEENDDH != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(HFJEBEENDDH);
      }
      if (KOKKGADOAGL != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(KOKKGADOAGL);
      }
      if (ODLMOCDBJHP != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(ODLMOCDBJHP);
      }
      if (NDKOPEJBGAE != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(NDKOPEJBGAE);
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
      if (GBNLDJIPEEK != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(GBNLDJIPEEK);
      }
      if (FKBLOGEAFJJ != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(FKBLOGEAFJJ);
      }
      if (GDHMMFELCDH != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(GDHMMFELCDH);
      }
      if (mPBFBIKCFJB_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(MPBFBIKCFJB);
      }
      if (MODAPIGJNNJ != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(MODAPIGJNNJ);
      }
      if (HFJEBEENDDH != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(HFJEBEENDDH);
      }
      if (KOKKGADOAGL != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(KOKKGADOAGL);
      }
      if (ODLMOCDBJHP != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(ODLMOCDBJHP);
      }
      if (NDKOPEJBGAE != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(NDKOPEJBGAE);
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
      if (GBNLDJIPEEK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GBNLDJIPEEK);
      }
      if (MODAPIGJNNJ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MODAPIGJNNJ);
      }
      if (HFJEBEENDDH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HFJEBEENDDH);
      }
      if (NDKOPEJBGAE != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NDKOPEJBGAE);
      }
      if (ODLMOCDBJHP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ODLMOCDBJHP);
      }
      if (KOKKGADOAGL != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KOKKGADOAGL);
      }
      if (FKBLOGEAFJJ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FKBLOGEAFJJ);
      }
      if (mPBFBIKCFJB_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MPBFBIKCFJB);
      }
      if (GDHMMFELCDH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GDHMMFELCDH);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FGFHNFKFJAH other) {
      if (other == null) {
        return;
      }
      if (other.GBNLDJIPEEK != 0) {
        GBNLDJIPEEK = other.GBNLDJIPEEK;
      }
      if (other.MODAPIGJNNJ != 0) {
        MODAPIGJNNJ = other.MODAPIGJNNJ;
      }
      if (other.HFJEBEENDDH != 0) {
        HFJEBEENDDH = other.HFJEBEENDDH;
      }
      if (other.NDKOPEJBGAE != 0) {
        NDKOPEJBGAE = other.NDKOPEJBGAE;
      }
      if (other.ODLMOCDBJHP != 0) {
        ODLMOCDBJHP = other.ODLMOCDBJHP;
      }
      if (other.KOKKGADOAGL != 0) {
        KOKKGADOAGL = other.KOKKGADOAGL;
      }
      if (other.FKBLOGEAFJJ != 0) {
        FKBLOGEAFJJ = other.FKBLOGEAFJJ;
      }
      if (other.mPBFBIKCFJB_ != null) {
        if (mPBFBIKCFJB_ == null) {
          MPBFBIKCFJB = new global::EggLink.DanhengServer.Proto.PMGMANJBJOK();
        }
        MPBFBIKCFJB.MergeFrom(other.MPBFBIKCFJB);
      }
      if (other.GDHMMFELCDH != 0) {
        GDHMMFELCDH = other.GDHMMFELCDH;
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
          case 8: {
            GBNLDJIPEEK = input.ReadUInt32();
            break;
          }
          case 16: {
            FKBLOGEAFJJ = input.ReadUInt32();
            break;
          }
          case 24: {
            GDHMMFELCDH = input.ReadUInt32();
            break;
          }
          case 34: {
            if (mPBFBIKCFJB_ == null) {
              MPBFBIKCFJB = new global::EggLink.DanhengServer.Proto.PMGMANJBJOK();
            }
            input.ReadMessage(MPBFBIKCFJB);
            break;
          }
          case 40: {
            MODAPIGJNNJ = input.ReadUInt32();
            break;
          }
          case 56: {
            HFJEBEENDDH = input.ReadUInt32();
            break;
          }
          case 96: {
            KOKKGADOAGL = input.ReadUInt32();
            break;
          }
          case 104: {
            ODLMOCDBJHP = input.ReadUInt32();
            break;
          }
          case 120: {
            NDKOPEJBGAE = input.ReadUInt32();
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
          case 8: {
            GBNLDJIPEEK = input.ReadUInt32();
            break;
          }
          case 16: {
            FKBLOGEAFJJ = input.ReadUInt32();
            break;
          }
          case 24: {
            GDHMMFELCDH = input.ReadUInt32();
            break;
          }
          case 34: {
            if (mPBFBIKCFJB_ == null) {
              MPBFBIKCFJB = new global::EggLink.DanhengServer.Proto.PMGMANJBJOK();
            }
            input.ReadMessage(MPBFBIKCFJB);
            break;
          }
          case 40: {
            MODAPIGJNNJ = input.ReadUInt32();
            break;
          }
          case 56: {
            HFJEBEENDDH = input.ReadUInt32();
            break;
          }
          case 96: {
            KOKKGADOAGL = input.ReadUInt32();
            break;
          }
          case 104: {
            ODLMOCDBJHP = input.ReadUInt32();
            break;
          }
          case 120: {
            NDKOPEJBGAE = input.ReadUInt32();
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
