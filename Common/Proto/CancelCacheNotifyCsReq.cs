// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CancelCacheNotifyCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from CancelCacheNotifyCsReq.proto</summary>
  public static partial class CancelCacheNotifyCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for CancelCacheNotifyCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CancelCacheNotifyCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxDYW5jZWxDYWNoZU5vdGlmeUNzUmVxLnByb3RvGhVDYWNoZU5vdGlmeVR5",
            "cGUucHJvdG8iYgoWQ2FuY2VsQ2FjaGVOb3RpZnlDc1JlcRITCgtBSU1KSlBO",
            "TlBJSBgBIAMoDRIeCgR0eXBlGA8gASgOMhAuQ2FjaGVOb3RpZnlUeXBlEhMK",
            "C0RCT09IQU1QS0NOGAkgAygJQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIu",
            "UHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.CacheNotifyTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.CancelCacheNotifyCsReq), global::EggLink.DanhengServer.Proto.CancelCacheNotifyCsReq.Parser, new[]{ "AIMJJPNNPIH", "Type", "DBOOHAMPKCN" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class CancelCacheNotifyCsReq : pb::IMessage<CancelCacheNotifyCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CancelCacheNotifyCsReq> _parser = new pb::MessageParser<CancelCacheNotifyCsReq>(() => new CancelCacheNotifyCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CancelCacheNotifyCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.CancelCacheNotifyCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CancelCacheNotifyCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CancelCacheNotifyCsReq(CancelCacheNotifyCsReq other) : this() {
      aIMJJPNNPIH_ = other.aIMJJPNNPIH_.Clone();
      type_ = other.type_;
      dBOOHAMPKCN_ = other.dBOOHAMPKCN_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CancelCacheNotifyCsReq Clone() {
      return new CancelCacheNotifyCsReq(this);
    }

    /// <summary>Field number for the "AIMJJPNNPIH" field.</summary>
    public const int AIMJJPNNPIHFieldNumber = 1;
    private static readonly pb::FieldCodec<uint> _repeated_aIMJJPNNPIH_codec
        = pb::FieldCodec.ForUInt32(10);
    private readonly pbc::RepeatedField<uint> aIMJJPNNPIH_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> AIMJJPNNPIH {
      get { return aIMJJPNNPIH_; }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 15;
    private global::EggLink.DanhengServer.Proto.CacheNotifyType type_ = global::EggLink.DanhengServer.Proto.CacheNotifyType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.CacheNotifyType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "DBOOHAMPKCN" field.</summary>
    public const int DBOOHAMPKCNFieldNumber = 9;
    private static readonly pb::FieldCodec<string> _repeated_dBOOHAMPKCN_codec
        = pb::FieldCodec.ForString(74);
    private readonly pbc::RepeatedField<string> dBOOHAMPKCN_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> DBOOHAMPKCN {
      get { return dBOOHAMPKCN_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CancelCacheNotifyCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CancelCacheNotifyCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!aIMJJPNNPIH_.Equals(other.aIMJJPNNPIH_)) return false;
      if (Type != other.Type) return false;
      if(!dBOOHAMPKCN_.Equals(other.dBOOHAMPKCN_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= aIMJJPNNPIH_.GetHashCode();
      if (Type != global::EggLink.DanhengServer.Proto.CacheNotifyType.None) hash ^= Type.GetHashCode();
      hash ^= dBOOHAMPKCN_.GetHashCode();
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
      aIMJJPNNPIH_.WriteTo(output, _repeated_aIMJJPNNPIH_codec);
      dBOOHAMPKCN_.WriteTo(output, _repeated_dBOOHAMPKCN_codec);
      if (Type != global::EggLink.DanhengServer.Proto.CacheNotifyType.None) {
        output.WriteRawTag(120);
        output.WriteEnum((int) Type);
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
      aIMJJPNNPIH_.WriteTo(ref output, _repeated_aIMJJPNNPIH_codec);
      dBOOHAMPKCN_.WriteTo(ref output, _repeated_dBOOHAMPKCN_codec);
      if (Type != global::EggLink.DanhengServer.Proto.CacheNotifyType.None) {
        output.WriteRawTag(120);
        output.WriteEnum((int) Type);
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
      size += aIMJJPNNPIH_.CalculateSize(_repeated_aIMJJPNNPIH_codec);
      if (Type != global::EggLink.DanhengServer.Proto.CacheNotifyType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      size += dBOOHAMPKCN_.CalculateSize(_repeated_dBOOHAMPKCN_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CancelCacheNotifyCsReq other) {
      if (other == null) {
        return;
      }
      aIMJJPNNPIH_.Add(other.aIMJJPNNPIH_);
      if (other.Type != global::EggLink.DanhengServer.Proto.CacheNotifyType.None) {
        Type = other.Type;
      }
      dBOOHAMPKCN_.Add(other.dBOOHAMPKCN_);
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
          case 10:
          case 8: {
            aIMJJPNNPIH_.AddEntriesFrom(input, _repeated_aIMJJPNNPIH_codec);
            break;
          }
          case 74: {
            dBOOHAMPKCN_.AddEntriesFrom(input, _repeated_dBOOHAMPKCN_codec);
            break;
          }
          case 120: {
            Type = (global::EggLink.DanhengServer.Proto.CacheNotifyType) input.ReadEnum();
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
          case 10:
          case 8: {
            aIMJJPNNPIH_.AddEntriesFrom(ref input, _repeated_aIMJJPNNPIH_codec);
            break;
          }
          case 74: {
            dBOOHAMPKCN_.AddEntriesFrom(ref input, _repeated_dBOOHAMPKCN_codec);
            break;
          }
          case 120: {
            Type = (global::EggLink.DanhengServer.Proto.CacheNotifyType) input.ReadEnum();
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
