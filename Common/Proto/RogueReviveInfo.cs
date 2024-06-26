// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueReviveInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueReviveInfo.proto</summary>
  public static partial class RogueReviveInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueReviveInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueReviveInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVSb2d1ZVJldml2ZUluZm8ucHJvdG8aEkl0ZW1Db3N0RGF0YS5wcm90byJ6",
            "Cg9Sb2d1ZVJldml2ZUluZm8SEwoLQ0lHQ1BNRktQQUIYCCADKA0SEwoLSUhE",
            "R0lMQ0lGS0oYDCABKA0SKAoRcm9ndWVfcmV2aXZlX2Nvc3QYBiABKAsyDS5J",
            "dGVtQ29zdERhdGESEwoLT0VDTk9ETE1BQ0kYDyABKA1CHqoCG0VnZ0xpbmsu",
            "RGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ItemCostDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueReviveInfo), global::EggLink.DanhengServer.Proto.RogueReviveInfo.Parser, new[]{ "CIGCPMFKPAB", "IHDGILCIFKJ", "RogueReviveCost", "OECNODLMACI" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueReviveInfo : pb::IMessage<RogueReviveInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueReviveInfo> _parser = new pb::MessageParser<RogueReviveInfo>(() => new RogueReviveInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueReviveInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueReviveInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueReviveInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueReviveInfo(RogueReviveInfo other) : this() {
      cIGCPMFKPAB_ = other.cIGCPMFKPAB_.Clone();
      iHDGILCIFKJ_ = other.iHDGILCIFKJ_;
      rogueReviveCost_ = other.rogueReviveCost_ != null ? other.rogueReviveCost_.Clone() : null;
      oECNODLMACI_ = other.oECNODLMACI_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueReviveInfo Clone() {
      return new RogueReviveInfo(this);
    }

    /// <summary>Field number for the "CIGCPMFKPAB" field.</summary>
    public const int CIGCPMFKPABFieldNumber = 8;
    private static readonly pb::FieldCodec<uint> _repeated_cIGCPMFKPAB_codec
        = pb::FieldCodec.ForUInt32(66);
    private readonly pbc::RepeatedField<uint> cIGCPMFKPAB_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> CIGCPMFKPAB {
      get { return cIGCPMFKPAB_; }
    }

    /// <summary>Field number for the "IHDGILCIFKJ" field.</summary>
    public const int IHDGILCIFKJFieldNumber = 12;
    private uint iHDGILCIFKJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint IHDGILCIFKJ {
      get { return iHDGILCIFKJ_; }
      set {
        iHDGILCIFKJ_ = value;
      }
    }

    /// <summary>Field number for the "rogue_revive_cost" field.</summary>
    public const int RogueReviveCostFieldNumber = 6;
    private global::EggLink.DanhengServer.Proto.ItemCostData rogueReviveCost_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemCostData RogueReviveCost {
      get { return rogueReviveCost_; }
      set {
        rogueReviveCost_ = value;
      }
    }

    /// <summary>Field number for the "OECNODLMACI" field.</summary>
    public const int OECNODLMACIFieldNumber = 15;
    private uint oECNODLMACI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OECNODLMACI {
      get { return oECNODLMACI_; }
      set {
        oECNODLMACI_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueReviveInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueReviveInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!cIGCPMFKPAB_.Equals(other.cIGCPMFKPAB_)) return false;
      if (IHDGILCIFKJ != other.IHDGILCIFKJ) return false;
      if (!object.Equals(RogueReviveCost, other.RogueReviveCost)) return false;
      if (OECNODLMACI != other.OECNODLMACI) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= cIGCPMFKPAB_.GetHashCode();
      if (IHDGILCIFKJ != 0) hash ^= IHDGILCIFKJ.GetHashCode();
      if (rogueReviveCost_ != null) hash ^= RogueReviveCost.GetHashCode();
      if (OECNODLMACI != 0) hash ^= OECNODLMACI.GetHashCode();
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
      if (rogueReviveCost_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(RogueReviveCost);
      }
      cIGCPMFKPAB_.WriteTo(output, _repeated_cIGCPMFKPAB_codec);
      if (IHDGILCIFKJ != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(IHDGILCIFKJ);
      }
      if (OECNODLMACI != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(OECNODLMACI);
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
      if (rogueReviveCost_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(RogueReviveCost);
      }
      cIGCPMFKPAB_.WriteTo(ref output, _repeated_cIGCPMFKPAB_codec);
      if (IHDGILCIFKJ != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(IHDGILCIFKJ);
      }
      if (OECNODLMACI != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(OECNODLMACI);
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
      size += cIGCPMFKPAB_.CalculateSize(_repeated_cIGCPMFKPAB_codec);
      if (IHDGILCIFKJ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(IHDGILCIFKJ);
      }
      if (rogueReviveCost_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueReviveCost);
      }
      if (OECNODLMACI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OECNODLMACI);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueReviveInfo other) {
      if (other == null) {
        return;
      }
      cIGCPMFKPAB_.Add(other.cIGCPMFKPAB_);
      if (other.IHDGILCIFKJ != 0) {
        IHDGILCIFKJ = other.IHDGILCIFKJ;
      }
      if (other.rogueReviveCost_ != null) {
        if (rogueReviveCost_ == null) {
          RogueReviveCost = new global::EggLink.DanhengServer.Proto.ItemCostData();
        }
        RogueReviveCost.MergeFrom(other.RogueReviveCost);
      }
      if (other.OECNODLMACI != 0) {
        OECNODLMACI = other.OECNODLMACI;
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
          case 50: {
            if (rogueReviveCost_ == null) {
              RogueReviveCost = new global::EggLink.DanhengServer.Proto.ItemCostData();
            }
            input.ReadMessage(RogueReviveCost);
            break;
          }
          case 66:
          case 64: {
            cIGCPMFKPAB_.AddEntriesFrom(input, _repeated_cIGCPMFKPAB_codec);
            break;
          }
          case 96: {
            IHDGILCIFKJ = input.ReadUInt32();
            break;
          }
          case 120: {
            OECNODLMACI = input.ReadUInt32();
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
          case 50: {
            if (rogueReviveCost_ == null) {
              RogueReviveCost = new global::EggLink.DanhengServer.Proto.ItemCostData();
            }
            input.ReadMessage(RogueReviveCost);
            break;
          }
          case 66:
          case 64: {
            cIGCPMFKPAB_.AddEntriesFrom(ref input, _repeated_cIGCPMFKPAB_codec);
            break;
          }
          case 96: {
            IHDGILCIFKJ = input.ReadUInt32();
            break;
          }
          case 120: {
            OECNODLMACI = input.ReadUInt32();
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
