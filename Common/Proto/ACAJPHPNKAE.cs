// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ACAJPHPNKAE.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ACAJPHPNKAE.proto</summary>
  public static partial class ACAJPHPNKAEReflection {

    #region Descriptor
    /// <summary>File descriptor for ACAJPHPNKAE.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ACAJPHPNKAEReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFBQ0FKUEhQTktBRS5wcm90bxoRREpDQktMRkFHREkucHJvdG8aEUNOTU9Q",
            "UEFOTEdDLnByb3RvInYKC0FDQUpQSFBOS0FFEiEKC0lLT0hFTUZIQ0pPGAgg",
            "ASgLMgwuQ05NT1BQQU5MR0MSIQoLTkdHSkxET0xCRk8YCyABKAsyDC5ESkNC",
            "S0xGQUdESRIhCgtDTURKRkJGQ0VESRgOIAMoCzIMLkNOTU9QUEFOTEdDQh6q",
            "AhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.DJCBKLFAGDIReflection.Descriptor, global::EggLink.DanhengServer.Proto.CNMOPPANLGCReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ACAJPHPNKAE), global::EggLink.DanhengServer.Proto.ACAJPHPNKAE.Parser, new[]{ "IKOHEMFHCJO", "NGGJLDOLBFO", "CMDJFBFCEDI" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ACAJPHPNKAE : pb::IMessage<ACAJPHPNKAE>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ACAJPHPNKAE> _parser = new pb::MessageParser<ACAJPHPNKAE>(() => new ACAJPHPNKAE());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ACAJPHPNKAE> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ACAJPHPNKAEReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ACAJPHPNKAE() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ACAJPHPNKAE(ACAJPHPNKAE other) : this() {
      iKOHEMFHCJO_ = other.iKOHEMFHCJO_ != null ? other.iKOHEMFHCJO_.Clone() : null;
      nGGJLDOLBFO_ = other.nGGJLDOLBFO_ != null ? other.nGGJLDOLBFO_.Clone() : null;
      cMDJFBFCEDI_ = other.cMDJFBFCEDI_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ACAJPHPNKAE Clone() {
      return new ACAJPHPNKAE(this);
    }

    /// <summary>Field number for the "IKOHEMFHCJO" field.</summary>
    public const int IKOHEMFHCJOFieldNumber = 8;
    private global::EggLink.DanhengServer.Proto.CNMOPPANLGC iKOHEMFHCJO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.CNMOPPANLGC IKOHEMFHCJO {
      get { return iKOHEMFHCJO_; }
      set {
        iKOHEMFHCJO_ = value;
      }
    }

    /// <summary>Field number for the "NGGJLDOLBFO" field.</summary>
    public const int NGGJLDOLBFOFieldNumber = 11;
    private global::EggLink.DanhengServer.Proto.DJCBKLFAGDI nGGJLDOLBFO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.DJCBKLFAGDI NGGJLDOLBFO {
      get { return nGGJLDOLBFO_; }
      set {
        nGGJLDOLBFO_ = value;
      }
    }

    /// <summary>Field number for the "CMDJFBFCEDI" field.</summary>
    public const int CMDJFBFCEDIFieldNumber = 14;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.CNMOPPANLGC> _repeated_cMDJFBFCEDI_codec
        = pb::FieldCodec.ForMessage(114, global::EggLink.DanhengServer.Proto.CNMOPPANLGC.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.CNMOPPANLGC> cMDJFBFCEDI_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.CNMOPPANLGC>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.CNMOPPANLGC> CMDJFBFCEDI {
      get { return cMDJFBFCEDI_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ACAJPHPNKAE);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ACAJPHPNKAE other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(IKOHEMFHCJO, other.IKOHEMFHCJO)) return false;
      if (!object.Equals(NGGJLDOLBFO, other.NGGJLDOLBFO)) return false;
      if(!cMDJFBFCEDI_.Equals(other.cMDJFBFCEDI_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (iKOHEMFHCJO_ != null) hash ^= IKOHEMFHCJO.GetHashCode();
      if (nGGJLDOLBFO_ != null) hash ^= NGGJLDOLBFO.GetHashCode();
      hash ^= cMDJFBFCEDI_.GetHashCode();
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
      if (iKOHEMFHCJO_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(IKOHEMFHCJO);
      }
      if (nGGJLDOLBFO_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(NGGJLDOLBFO);
      }
      cMDJFBFCEDI_.WriteTo(output, _repeated_cMDJFBFCEDI_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (iKOHEMFHCJO_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(IKOHEMFHCJO);
      }
      if (nGGJLDOLBFO_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(NGGJLDOLBFO);
      }
      cMDJFBFCEDI_.WriteTo(ref output, _repeated_cMDJFBFCEDI_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (iKOHEMFHCJO_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(IKOHEMFHCJO);
      }
      if (nGGJLDOLBFO_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(NGGJLDOLBFO);
      }
      size += cMDJFBFCEDI_.CalculateSize(_repeated_cMDJFBFCEDI_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ACAJPHPNKAE other) {
      if (other == null) {
        return;
      }
      if (other.iKOHEMFHCJO_ != null) {
        if (iKOHEMFHCJO_ == null) {
          IKOHEMFHCJO = new global::EggLink.DanhengServer.Proto.CNMOPPANLGC();
        }
        IKOHEMFHCJO.MergeFrom(other.IKOHEMFHCJO);
      }
      if (other.nGGJLDOLBFO_ != null) {
        if (nGGJLDOLBFO_ == null) {
          NGGJLDOLBFO = new global::EggLink.DanhengServer.Proto.DJCBKLFAGDI();
        }
        NGGJLDOLBFO.MergeFrom(other.NGGJLDOLBFO);
      }
      cMDJFBFCEDI_.Add(other.cMDJFBFCEDI_);
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
          case 66: {
            if (iKOHEMFHCJO_ == null) {
              IKOHEMFHCJO = new global::EggLink.DanhengServer.Proto.CNMOPPANLGC();
            }
            input.ReadMessage(IKOHEMFHCJO);
            break;
          }
          case 90: {
            if (nGGJLDOLBFO_ == null) {
              NGGJLDOLBFO = new global::EggLink.DanhengServer.Proto.DJCBKLFAGDI();
            }
            input.ReadMessage(NGGJLDOLBFO);
            break;
          }
          case 114: {
            cMDJFBFCEDI_.AddEntriesFrom(input, _repeated_cMDJFBFCEDI_codec);
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
          case 66: {
            if (iKOHEMFHCJO_ == null) {
              IKOHEMFHCJO = new global::EggLink.DanhengServer.Proto.CNMOPPANLGC();
            }
            input.ReadMessage(IKOHEMFHCJO);
            break;
          }
          case 90: {
            if (nGGJLDOLBFO_ == null) {
              NGGJLDOLBFO = new global::EggLink.DanhengServer.Proto.DJCBKLFAGDI();
            }
            input.ReadMessage(NGGJLDOLBFO);
            break;
          }
          case 114: {
            cMDJFBFCEDI_.AddEntriesFrom(ref input, _repeated_cMDJFBFCEDI_codec);
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
