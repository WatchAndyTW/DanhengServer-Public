// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AlleyPlacingGameScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from AlleyPlacingGameScRsp.proto</summary>
  public static partial class AlleyPlacingGameScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for AlleyPlacingGameScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AlleyPlacingGameScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtBbGxleVBsYWNpbmdHYW1lU2NSc3AucHJvdG8iuAEKFUFsbGV5UGxhY2lu",
            "Z0dhbWVTY1JzcBIQCghldmVudF9pZBgDIAEoDRITCgtMS01MSElHTktCQRgM",
            "IAEoDRITCgtBTEtBREpITUlKQhgNIAEoDRITCgtHR0RBREtFSUFIRRgIIAEo",
            "DRITCgtGS0lPRkxPTkVOSxgEIAEoDRIPCgdyZXRjb2RlGA4gASgNEhMKC0RG",
            "QUxDQU1CR0ZLGAkgASgNEhMKC0RHT0xMSFBJT0VIGAogASgNQh6qAhtFZ2dM",
            "aW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.AlleyPlacingGameScRsp), global::EggLink.DanhengServer.Proto.AlleyPlacingGameScRsp.Parser, new[]{ "EventId", "LKMLHIGNKBA", "ALKADJHMIJB", "GGDADKEIAHE", "FKIOFLONENK", "Retcode", "DFALCAMBGFK", "DGOLLHPIOEH" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class AlleyPlacingGameScRsp : pb::IMessage<AlleyPlacingGameScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AlleyPlacingGameScRsp> _parser = new pb::MessageParser<AlleyPlacingGameScRsp>(() => new AlleyPlacingGameScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AlleyPlacingGameScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.AlleyPlacingGameScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AlleyPlacingGameScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AlleyPlacingGameScRsp(AlleyPlacingGameScRsp other) : this() {
      eventId_ = other.eventId_;
      lKMLHIGNKBA_ = other.lKMLHIGNKBA_;
      aLKADJHMIJB_ = other.aLKADJHMIJB_;
      gGDADKEIAHE_ = other.gGDADKEIAHE_;
      fKIOFLONENK_ = other.fKIOFLONENK_;
      retcode_ = other.retcode_;
      dFALCAMBGFK_ = other.dFALCAMBGFK_;
      dGOLLHPIOEH_ = other.dGOLLHPIOEH_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AlleyPlacingGameScRsp Clone() {
      return new AlleyPlacingGameScRsp(this);
    }

    /// <summary>Field number for the "event_id" field.</summary>
    public const int EventIdFieldNumber = 3;
    private uint eventId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EventId {
      get { return eventId_; }
      set {
        eventId_ = value;
      }
    }

    /// <summary>Field number for the "LKMLHIGNKBA" field.</summary>
    public const int LKMLHIGNKBAFieldNumber = 12;
    private uint lKMLHIGNKBA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LKMLHIGNKBA {
      get { return lKMLHIGNKBA_; }
      set {
        lKMLHIGNKBA_ = value;
      }
    }

    /// <summary>Field number for the "ALKADJHMIJB" field.</summary>
    public const int ALKADJHMIJBFieldNumber = 13;
    private uint aLKADJHMIJB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ALKADJHMIJB {
      get { return aLKADJHMIJB_; }
      set {
        aLKADJHMIJB_ = value;
      }
    }

    /// <summary>Field number for the "GGDADKEIAHE" field.</summary>
    public const int GGDADKEIAHEFieldNumber = 8;
    private uint gGDADKEIAHE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GGDADKEIAHE {
      get { return gGDADKEIAHE_; }
      set {
        gGDADKEIAHE_ = value;
      }
    }

    /// <summary>Field number for the "FKIOFLONENK" field.</summary>
    public const int FKIOFLONENKFieldNumber = 4;
    private uint fKIOFLONENK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FKIOFLONENK {
      get { return fKIOFLONENK_; }
      set {
        fKIOFLONENK_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 14;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "DFALCAMBGFK" field.</summary>
    public const int DFALCAMBGFKFieldNumber = 9;
    private uint dFALCAMBGFK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DFALCAMBGFK {
      get { return dFALCAMBGFK_; }
      set {
        dFALCAMBGFK_ = value;
      }
    }

    /// <summary>Field number for the "DGOLLHPIOEH" field.</summary>
    public const int DGOLLHPIOEHFieldNumber = 10;
    private uint dGOLLHPIOEH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DGOLLHPIOEH {
      get { return dGOLLHPIOEH_; }
      set {
        dGOLLHPIOEH_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AlleyPlacingGameScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AlleyPlacingGameScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EventId != other.EventId) return false;
      if (LKMLHIGNKBA != other.LKMLHIGNKBA) return false;
      if (ALKADJHMIJB != other.ALKADJHMIJB) return false;
      if (GGDADKEIAHE != other.GGDADKEIAHE) return false;
      if (FKIOFLONENK != other.FKIOFLONENK) return false;
      if (Retcode != other.Retcode) return false;
      if (DFALCAMBGFK != other.DFALCAMBGFK) return false;
      if (DGOLLHPIOEH != other.DGOLLHPIOEH) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EventId != 0) hash ^= EventId.GetHashCode();
      if (LKMLHIGNKBA != 0) hash ^= LKMLHIGNKBA.GetHashCode();
      if (ALKADJHMIJB != 0) hash ^= ALKADJHMIJB.GetHashCode();
      if (GGDADKEIAHE != 0) hash ^= GGDADKEIAHE.GetHashCode();
      if (FKIOFLONENK != 0) hash ^= FKIOFLONENK.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (DFALCAMBGFK != 0) hash ^= DFALCAMBGFK.GetHashCode();
      if (DGOLLHPIOEH != 0) hash ^= DGOLLHPIOEH.GetHashCode();
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
      if (EventId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(EventId);
      }
      if (FKIOFLONENK != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(FKIOFLONENK);
      }
      if (GGDADKEIAHE != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(GGDADKEIAHE);
      }
      if (DFALCAMBGFK != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(DFALCAMBGFK);
      }
      if (DGOLLHPIOEH != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(DGOLLHPIOEH);
      }
      if (LKMLHIGNKBA != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(LKMLHIGNKBA);
      }
      if (ALKADJHMIJB != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(ALKADJHMIJB);
      }
      if (Retcode != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Retcode);
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
      if (EventId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(EventId);
      }
      if (FKIOFLONENK != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(FKIOFLONENK);
      }
      if (GGDADKEIAHE != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(GGDADKEIAHE);
      }
      if (DFALCAMBGFK != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(DFALCAMBGFK);
      }
      if (DGOLLHPIOEH != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(DGOLLHPIOEH);
      }
      if (LKMLHIGNKBA != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(LKMLHIGNKBA);
      }
      if (ALKADJHMIJB != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(ALKADJHMIJB);
      }
      if (Retcode != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Retcode);
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
      if (EventId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EventId);
      }
      if (LKMLHIGNKBA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LKMLHIGNKBA);
      }
      if (ALKADJHMIJB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ALKADJHMIJB);
      }
      if (GGDADKEIAHE != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GGDADKEIAHE);
      }
      if (FKIOFLONENK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FKIOFLONENK);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (DFALCAMBGFK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DFALCAMBGFK);
      }
      if (DGOLLHPIOEH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DGOLLHPIOEH);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AlleyPlacingGameScRsp other) {
      if (other == null) {
        return;
      }
      if (other.EventId != 0) {
        EventId = other.EventId;
      }
      if (other.LKMLHIGNKBA != 0) {
        LKMLHIGNKBA = other.LKMLHIGNKBA;
      }
      if (other.ALKADJHMIJB != 0) {
        ALKADJHMIJB = other.ALKADJHMIJB;
      }
      if (other.GGDADKEIAHE != 0) {
        GGDADKEIAHE = other.GGDADKEIAHE;
      }
      if (other.FKIOFLONENK != 0) {
        FKIOFLONENK = other.FKIOFLONENK;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.DFALCAMBGFK != 0) {
        DFALCAMBGFK = other.DFALCAMBGFK;
      }
      if (other.DGOLLHPIOEH != 0) {
        DGOLLHPIOEH = other.DGOLLHPIOEH;
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
          case 24: {
            EventId = input.ReadUInt32();
            break;
          }
          case 32: {
            FKIOFLONENK = input.ReadUInt32();
            break;
          }
          case 64: {
            GGDADKEIAHE = input.ReadUInt32();
            break;
          }
          case 72: {
            DFALCAMBGFK = input.ReadUInt32();
            break;
          }
          case 80: {
            DGOLLHPIOEH = input.ReadUInt32();
            break;
          }
          case 96: {
            LKMLHIGNKBA = input.ReadUInt32();
            break;
          }
          case 104: {
            ALKADJHMIJB = input.ReadUInt32();
            break;
          }
          case 112: {
            Retcode = input.ReadUInt32();
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
          case 24: {
            EventId = input.ReadUInt32();
            break;
          }
          case 32: {
            FKIOFLONENK = input.ReadUInt32();
            break;
          }
          case 64: {
            GGDADKEIAHE = input.ReadUInt32();
            break;
          }
          case 72: {
            DFALCAMBGFK = input.ReadUInt32();
            break;
          }
          case 80: {
            DGOLLHPIOEH = input.ReadUInt32();
            break;
          }
          case 96: {
            LKMLHIGNKBA = input.ReadUInt32();
            break;
          }
          case 104: {
            ALKADJHMIJB = input.ReadUInt32();
            break;
          }
          case 112: {
            Retcode = input.ReadUInt32();
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
