// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MJNBGFIHJBN.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from MJNBGFIHJBN.proto</summary>
  public static partial class MJNBGFIHJBNReflection {

    #region Descriptor
    /// <summary>File descriptor for MJNBGFIHJBN.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MJNBGFIHJBNReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFNSk5CR0ZJSEpCTi5wcm90byKHAQoLTUpOQkdGSUhKQk4SEwoLR0lKQ0xL",
            "UE5MQUQYDyABKA0SEwoLRUZDQVBNQURFRFAYDSADKA0SEQoJdW5pcXVlX2lk",
            "GAMgASgNEhEKCWl0ZW1fbGlzdBgKIAMoDRITCgtIQ0ZET0NLT0tQThgJIAEo",
            "CBITCgtLQUJHQU5MUFBGSBgCIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2Vy",
            "dmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.MJNBGFIHJBN), global::EggLink.DanhengServer.Proto.MJNBGFIHJBN.Parser, new[]{ "GIJCLKPNLAD", "EFCAPMADEDP", "UniqueId", "ItemList", "HCFDOCKOKPN", "KABGANLPPFH" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MJNBGFIHJBN : pb::IMessage<MJNBGFIHJBN>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MJNBGFIHJBN> _parser = new pb::MessageParser<MJNBGFIHJBN>(() => new MJNBGFIHJBN());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MJNBGFIHJBN> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.MJNBGFIHJBNReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MJNBGFIHJBN() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MJNBGFIHJBN(MJNBGFIHJBN other) : this() {
      gIJCLKPNLAD_ = other.gIJCLKPNLAD_;
      eFCAPMADEDP_ = other.eFCAPMADEDP_.Clone();
      uniqueId_ = other.uniqueId_;
      itemList_ = other.itemList_.Clone();
      hCFDOCKOKPN_ = other.hCFDOCKOKPN_;
      kABGANLPPFH_ = other.kABGANLPPFH_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MJNBGFIHJBN Clone() {
      return new MJNBGFIHJBN(this);
    }

    /// <summary>Field number for the "GIJCLKPNLAD" field.</summary>
    public const int GIJCLKPNLADFieldNumber = 15;
    private uint gIJCLKPNLAD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GIJCLKPNLAD {
      get { return gIJCLKPNLAD_; }
      set {
        gIJCLKPNLAD_ = value;
      }
    }

    /// <summary>Field number for the "EFCAPMADEDP" field.</summary>
    public const int EFCAPMADEDPFieldNumber = 13;
    private static readonly pb::FieldCodec<uint> _repeated_eFCAPMADEDP_codec
        = pb::FieldCodec.ForUInt32(106);
    private readonly pbc::RepeatedField<uint> eFCAPMADEDP_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> EFCAPMADEDP {
      get { return eFCAPMADEDP_; }
    }

    /// <summary>Field number for the "unique_id" field.</summary>
    public const int UniqueIdFieldNumber = 3;
    private uint uniqueId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint UniqueId {
      get { return uniqueId_; }
      set {
        uniqueId_ = value;
      }
    }

    /// <summary>Field number for the "item_list" field.</summary>
    public const int ItemListFieldNumber = 10;
    private static readonly pb::FieldCodec<uint> _repeated_itemList_codec
        = pb::FieldCodec.ForUInt32(82);
    private readonly pbc::RepeatedField<uint> itemList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ItemList {
      get { return itemList_; }
    }

    /// <summary>Field number for the "HCFDOCKOKPN" field.</summary>
    public const int HCFDOCKOKPNFieldNumber = 9;
    private bool hCFDOCKOKPN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HCFDOCKOKPN {
      get { return hCFDOCKOKPN_; }
      set {
        hCFDOCKOKPN_ = value;
      }
    }

    /// <summary>Field number for the "KABGANLPPFH" field.</summary>
    public const int KABGANLPPFHFieldNumber = 2;
    private uint kABGANLPPFH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KABGANLPPFH {
      get { return kABGANLPPFH_; }
      set {
        kABGANLPPFH_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MJNBGFIHJBN);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MJNBGFIHJBN other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GIJCLKPNLAD != other.GIJCLKPNLAD) return false;
      if(!eFCAPMADEDP_.Equals(other.eFCAPMADEDP_)) return false;
      if (UniqueId != other.UniqueId) return false;
      if(!itemList_.Equals(other.itemList_)) return false;
      if (HCFDOCKOKPN != other.HCFDOCKOKPN) return false;
      if (KABGANLPPFH != other.KABGANLPPFH) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GIJCLKPNLAD != 0) hash ^= GIJCLKPNLAD.GetHashCode();
      hash ^= eFCAPMADEDP_.GetHashCode();
      if (UniqueId != 0) hash ^= UniqueId.GetHashCode();
      hash ^= itemList_.GetHashCode();
      if (HCFDOCKOKPN != false) hash ^= HCFDOCKOKPN.GetHashCode();
      if (KABGANLPPFH != 0) hash ^= KABGANLPPFH.GetHashCode();
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
      if (KABGANLPPFH != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(KABGANLPPFH);
      }
      if (UniqueId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(UniqueId);
      }
      if (HCFDOCKOKPN != false) {
        output.WriteRawTag(72);
        output.WriteBool(HCFDOCKOKPN);
      }
      itemList_.WriteTo(output, _repeated_itemList_codec);
      eFCAPMADEDP_.WriteTo(output, _repeated_eFCAPMADEDP_codec);
      if (GIJCLKPNLAD != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(GIJCLKPNLAD);
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
      if (KABGANLPPFH != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(KABGANLPPFH);
      }
      if (UniqueId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(UniqueId);
      }
      if (HCFDOCKOKPN != false) {
        output.WriteRawTag(72);
        output.WriteBool(HCFDOCKOKPN);
      }
      itemList_.WriteTo(ref output, _repeated_itemList_codec);
      eFCAPMADEDP_.WriteTo(ref output, _repeated_eFCAPMADEDP_codec);
      if (GIJCLKPNLAD != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(GIJCLKPNLAD);
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
      if (GIJCLKPNLAD != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GIJCLKPNLAD);
      }
      size += eFCAPMADEDP_.CalculateSize(_repeated_eFCAPMADEDP_codec);
      if (UniqueId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(UniqueId);
      }
      size += itemList_.CalculateSize(_repeated_itemList_codec);
      if (HCFDOCKOKPN != false) {
        size += 1 + 1;
      }
      if (KABGANLPPFH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KABGANLPPFH);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MJNBGFIHJBN other) {
      if (other == null) {
        return;
      }
      if (other.GIJCLKPNLAD != 0) {
        GIJCLKPNLAD = other.GIJCLKPNLAD;
      }
      eFCAPMADEDP_.Add(other.eFCAPMADEDP_);
      if (other.UniqueId != 0) {
        UniqueId = other.UniqueId;
      }
      itemList_.Add(other.itemList_);
      if (other.HCFDOCKOKPN != false) {
        HCFDOCKOKPN = other.HCFDOCKOKPN;
      }
      if (other.KABGANLPPFH != 0) {
        KABGANLPPFH = other.KABGANLPPFH;
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
          case 16: {
            KABGANLPPFH = input.ReadUInt32();
            break;
          }
          case 24: {
            UniqueId = input.ReadUInt32();
            break;
          }
          case 72: {
            HCFDOCKOKPN = input.ReadBool();
            break;
          }
          case 82:
          case 80: {
            itemList_.AddEntriesFrom(input, _repeated_itemList_codec);
            break;
          }
          case 106:
          case 104: {
            eFCAPMADEDP_.AddEntriesFrom(input, _repeated_eFCAPMADEDP_codec);
            break;
          }
          case 120: {
            GIJCLKPNLAD = input.ReadUInt32();
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
            KABGANLPPFH = input.ReadUInt32();
            break;
          }
          case 24: {
            UniqueId = input.ReadUInt32();
            break;
          }
          case 72: {
            HCFDOCKOKPN = input.ReadBool();
            break;
          }
          case 82:
          case 80: {
            itemList_.AddEntriesFrom(ref input, _repeated_itemList_codec);
            break;
          }
          case 106:
          case 104: {
            eFCAPMADEDP_.AddEntriesFrom(ref input, _repeated_eFCAPMADEDP_codec);
            break;
          }
          case 120: {
            GIJCLKPNLAD = input.ReadUInt32();
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