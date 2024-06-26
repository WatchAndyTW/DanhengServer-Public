// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ComposeItemCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ComposeItemCsReq.proto</summary>
  public static partial class ComposeItemCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for ComposeItemCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ComposeItemCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZDb21wb3NlSXRlbUNzUmVxLnByb3RvGhJJdGVtQ29zdERhdGEucHJvdG8i",
            "WQoQQ29tcG9zZUl0ZW1Dc1JlcRINCgVjb3VudBgIIAEoDRIiCgtKSU1JTklO",
            "UE9DRhgDIAEoCzINLkl0ZW1Db3N0RGF0YRISCgpjb21wb3NlX2lkGAEgASgN",
            "Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ItemCostDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ComposeItemCsReq), global::EggLink.DanhengServer.Proto.ComposeItemCsReq.Parser, new[]{ "Count", "JIMININPOCF", "ComposeId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ComposeItemCsReq : pb::IMessage<ComposeItemCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ComposeItemCsReq> _parser = new pb::MessageParser<ComposeItemCsReq>(() => new ComposeItemCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ComposeItemCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ComposeItemCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ComposeItemCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ComposeItemCsReq(ComposeItemCsReq other) : this() {
      count_ = other.count_;
      jIMININPOCF_ = other.jIMININPOCF_ != null ? other.jIMININPOCF_.Clone() : null;
      composeId_ = other.composeId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ComposeItemCsReq Clone() {
      return new ComposeItemCsReq(this);
    }

    /// <summary>Field number for the "count" field.</summary>
    public const int CountFieldNumber = 8;
    private uint count_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Count {
      get { return count_; }
      set {
        count_ = value;
      }
    }

    /// <summary>Field number for the "JIMININPOCF" field.</summary>
    public const int JIMININPOCFFieldNumber = 3;
    private global::EggLink.DanhengServer.Proto.ItemCostData jIMININPOCF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemCostData JIMININPOCF {
      get { return jIMININPOCF_; }
      set {
        jIMININPOCF_ = value;
      }
    }

    /// <summary>Field number for the "compose_id" field.</summary>
    public const int ComposeIdFieldNumber = 1;
    private uint composeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ComposeId {
      get { return composeId_; }
      set {
        composeId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ComposeItemCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ComposeItemCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Count != other.Count) return false;
      if (!object.Equals(JIMININPOCF, other.JIMININPOCF)) return false;
      if (ComposeId != other.ComposeId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Count != 0) hash ^= Count.GetHashCode();
      if (jIMININPOCF_ != null) hash ^= JIMININPOCF.GetHashCode();
      if (ComposeId != 0) hash ^= ComposeId.GetHashCode();
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
      if (ComposeId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ComposeId);
      }
      if (jIMININPOCF_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(JIMININPOCF);
      }
      if (Count != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Count);
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
      if (ComposeId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ComposeId);
      }
      if (jIMININPOCF_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(JIMININPOCF);
      }
      if (Count != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Count);
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
      if (Count != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Count);
      }
      if (jIMININPOCF_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(JIMININPOCF);
      }
      if (ComposeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ComposeId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ComposeItemCsReq other) {
      if (other == null) {
        return;
      }
      if (other.Count != 0) {
        Count = other.Count;
      }
      if (other.jIMININPOCF_ != null) {
        if (jIMININPOCF_ == null) {
          JIMININPOCF = new global::EggLink.DanhengServer.Proto.ItemCostData();
        }
        JIMININPOCF.MergeFrom(other.JIMININPOCF);
      }
      if (other.ComposeId != 0) {
        ComposeId = other.ComposeId;
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
            ComposeId = input.ReadUInt32();
            break;
          }
          case 26: {
            if (jIMININPOCF_ == null) {
              JIMININPOCF = new global::EggLink.DanhengServer.Proto.ItemCostData();
            }
            input.ReadMessage(JIMININPOCF);
            break;
          }
          case 64: {
            Count = input.ReadUInt32();
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
            ComposeId = input.ReadUInt32();
            break;
          }
          case 26: {
            if (jIMININPOCF_ == null) {
              JIMININPOCF = new global::EggLink.DanhengServer.Proto.ItemCostData();
            }
            input.ReadMessage(JIMININPOCF);
            break;
          }
          case 64: {
            Count = input.ReadUInt32();
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
