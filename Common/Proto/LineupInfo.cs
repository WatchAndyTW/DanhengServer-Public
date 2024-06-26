// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: LineupInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from LineupInfo.proto</summary>
  public static partial class LineupInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for LineupInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LineupInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBMaW5ldXBJbmZvLnByb3RvGhJMaW5ldXBBdmF0YXIucHJvdG8aFUV4dHJh",
            "TGluZXVwVHlwZS5wcm90byKQAgoKTGluZXVwSW5mbxIQCghwbGFuZV9pZBgL",
            "IAEoDRITCgtESkRCS0ZORUtQRhgDIAEoDRIiCgthdmF0YXJfbGlzdBgPIAMo",
            "CzINLkxpbmV1cEF2YXRhchIMCgRuYW1lGAEgASgJEg0KBWluZGV4GAQgASgN",
            "EisKEWV4dHJhX2xpbmV1cF90eXBlGA0gASgOMhAuRXh0cmFMaW5ldXBUeXBl",
            "EhIKCmlzX3ZpcnR1YWwYCCABKAgSEwoLbGVhZGVyX3Nsb3QYByABKA0SEwoL",
            "SEtCSUlESkVOSUIYCiADKA0SEwoLUE9KT0hPSEtQUEEYDCABKAgSDgoGbWF4",
            "X21wGAYgASgNEgoKAm1wGAkgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2",
            "ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.LineupAvatarReflection.Descriptor, global::EggLink.DanhengServer.Proto.ExtraLineupTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.LineupInfo), global::EggLink.DanhengServer.Proto.LineupInfo.Parser, new[]{ "PlaneId", "DJDBKFNEKPF", "AvatarList", "Name", "Index", "ExtraLineupType", "IsVirtual", "LeaderSlot", "HKBIIDJENIB", "POJOHOHKPPA", "MaxMp", "Mp" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class LineupInfo : pb::IMessage<LineupInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LineupInfo> _parser = new pb::MessageParser<LineupInfo>(() => new LineupInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LineupInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.LineupInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LineupInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LineupInfo(LineupInfo other) : this() {
      planeId_ = other.planeId_;
      dJDBKFNEKPF_ = other.dJDBKFNEKPF_;
      avatarList_ = other.avatarList_.Clone();
      name_ = other.name_;
      index_ = other.index_;
      extraLineupType_ = other.extraLineupType_;
      isVirtual_ = other.isVirtual_;
      leaderSlot_ = other.leaderSlot_;
      hKBIIDJENIB_ = other.hKBIIDJENIB_.Clone();
      pOJOHOHKPPA_ = other.pOJOHOHKPPA_;
      maxMp_ = other.maxMp_;
      mp_ = other.mp_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LineupInfo Clone() {
      return new LineupInfo(this);
    }

    /// <summary>Field number for the "plane_id" field.</summary>
    public const int PlaneIdFieldNumber = 11;
    private uint planeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PlaneId {
      get { return planeId_; }
      set {
        planeId_ = value;
      }
    }

    /// <summary>Field number for the "DJDBKFNEKPF" field.</summary>
    public const int DJDBKFNEKPFFieldNumber = 3;
    private uint dJDBKFNEKPF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DJDBKFNEKPF {
      get { return dJDBKFNEKPF_; }
      set {
        dJDBKFNEKPF_ = value;
      }
    }

    /// <summary>Field number for the "avatar_list" field.</summary>
    public const int AvatarListFieldNumber = 15;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.LineupAvatar> _repeated_avatarList_codec
        = pb::FieldCodec.ForMessage(122, global::EggLink.DanhengServer.Proto.LineupAvatar.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.LineupAvatar> avatarList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.LineupAvatar>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.LineupAvatar> AvatarList {
      get { return avatarList_; }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "index" field.</summary>
    public const int IndexFieldNumber = 4;
    private uint index_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Index {
      get { return index_; }
      set {
        index_ = value;
      }
    }

    /// <summary>Field number for the "extra_lineup_type" field.</summary>
    public const int ExtraLineupTypeFieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.ExtraLineupType extraLineupType_ = global::EggLink.DanhengServer.Proto.ExtraLineupType.LineupNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ExtraLineupType ExtraLineupType {
      get { return extraLineupType_; }
      set {
        extraLineupType_ = value;
      }
    }

    /// <summary>Field number for the "is_virtual" field.</summary>
    public const int IsVirtualFieldNumber = 8;
    private bool isVirtual_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsVirtual {
      get { return isVirtual_; }
      set {
        isVirtual_ = value;
      }
    }

    /// <summary>Field number for the "leader_slot" field.</summary>
    public const int LeaderSlotFieldNumber = 7;
    private uint leaderSlot_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LeaderSlot {
      get { return leaderSlot_; }
      set {
        leaderSlot_ = value;
      }
    }

    /// <summary>Field number for the "HKBIIDJENIB" field.</summary>
    public const int HKBIIDJENIBFieldNumber = 10;
    private static readonly pb::FieldCodec<uint> _repeated_hKBIIDJENIB_codec
        = pb::FieldCodec.ForUInt32(82);
    private readonly pbc::RepeatedField<uint> hKBIIDJENIB_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> HKBIIDJENIB {
      get { return hKBIIDJENIB_; }
    }

    /// <summary>Field number for the "POJOHOHKPPA" field.</summary>
    public const int POJOHOHKPPAFieldNumber = 12;
    private bool pOJOHOHKPPA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool POJOHOHKPPA {
      get { return pOJOHOHKPPA_; }
      set {
        pOJOHOHKPPA_ = value;
      }
    }

    /// <summary>Field number for the "max_mp" field.</summary>
    public const int MaxMpFieldNumber = 6;
    private uint maxMp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MaxMp {
      get { return maxMp_; }
      set {
        maxMp_ = value;
      }
    }

    /// <summary>Field number for the "mp" field.</summary>
    public const int MpFieldNumber = 9;
    private uint mp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Mp {
      get { return mp_; }
      set {
        mp_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LineupInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LineupInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PlaneId != other.PlaneId) return false;
      if (DJDBKFNEKPF != other.DJDBKFNEKPF) return false;
      if(!avatarList_.Equals(other.avatarList_)) return false;
      if (Name != other.Name) return false;
      if (Index != other.Index) return false;
      if (ExtraLineupType != other.ExtraLineupType) return false;
      if (IsVirtual != other.IsVirtual) return false;
      if (LeaderSlot != other.LeaderSlot) return false;
      if(!hKBIIDJENIB_.Equals(other.hKBIIDJENIB_)) return false;
      if (POJOHOHKPPA != other.POJOHOHKPPA) return false;
      if (MaxMp != other.MaxMp) return false;
      if (Mp != other.Mp) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PlaneId != 0) hash ^= PlaneId.GetHashCode();
      if (DJDBKFNEKPF != 0) hash ^= DJDBKFNEKPF.GetHashCode();
      hash ^= avatarList_.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Index != 0) hash ^= Index.GetHashCode();
      if (ExtraLineupType != global::EggLink.DanhengServer.Proto.ExtraLineupType.LineupNone) hash ^= ExtraLineupType.GetHashCode();
      if (IsVirtual != false) hash ^= IsVirtual.GetHashCode();
      if (LeaderSlot != 0) hash ^= LeaderSlot.GetHashCode();
      hash ^= hKBIIDJENIB_.GetHashCode();
      if (POJOHOHKPPA != false) hash ^= POJOHOHKPPA.GetHashCode();
      if (MaxMp != 0) hash ^= MaxMp.GetHashCode();
      if (Mp != 0) hash ^= Mp.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (DJDBKFNEKPF != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(DJDBKFNEKPF);
      }
      if (Index != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Index);
      }
      if (MaxMp != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(MaxMp);
      }
      if (LeaderSlot != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(LeaderSlot);
      }
      if (IsVirtual != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsVirtual);
      }
      if (Mp != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Mp);
      }
      hKBIIDJENIB_.WriteTo(output, _repeated_hKBIIDJENIB_codec);
      if (PlaneId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(PlaneId);
      }
      if (POJOHOHKPPA != false) {
        output.WriteRawTag(96);
        output.WriteBool(POJOHOHKPPA);
      }
      if (ExtraLineupType != global::EggLink.DanhengServer.Proto.ExtraLineupType.LineupNone) {
        output.WriteRawTag(104);
        output.WriteEnum((int) ExtraLineupType);
      }
      avatarList_.WriteTo(output, _repeated_avatarList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (DJDBKFNEKPF != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(DJDBKFNEKPF);
      }
      if (Index != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Index);
      }
      if (MaxMp != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(MaxMp);
      }
      if (LeaderSlot != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(LeaderSlot);
      }
      if (IsVirtual != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsVirtual);
      }
      if (Mp != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Mp);
      }
      hKBIIDJENIB_.WriteTo(ref output, _repeated_hKBIIDJENIB_codec);
      if (PlaneId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(PlaneId);
      }
      if (POJOHOHKPPA != false) {
        output.WriteRawTag(96);
        output.WriteBool(POJOHOHKPPA);
      }
      if (ExtraLineupType != global::EggLink.DanhengServer.Proto.ExtraLineupType.LineupNone) {
        output.WriteRawTag(104);
        output.WriteEnum((int) ExtraLineupType);
      }
      avatarList_.WriteTo(ref output, _repeated_avatarList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (PlaneId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PlaneId);
      }
      if (DJDBKFNEKPF != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DJDBKFNEKPF);
      }
      size += avatarList_.CalculateSize(_repeated_avatarList_codec);
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Index != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Index);
      }
      if (ExtraLineupType != global::EggLink.DanhengServer.Proto.ExtraLineupType.LineupNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ExtraLineupType);
      }
      if (IsVirtual != false) {
        size += 1 + 1;
      }
      if (LeaderSlot != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LeaderSlot);
      }
      size += hKBIIDJENIB_.CalculateSize(_repeated_hKBIIDJENIB_codec);
      if (POJOHOHKPPA != false) {
        size += 1 + 1;
      }
      if (MaxMp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaxMp);
      }
      if (Mp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Mp);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(LineupInfo other) {
      if (other == null) {
        return;
      }
      if (other.PlaneId != 0) {
        PlaneId = other.PlaneId;
      }
      if (other.DJDBKFNEKPF != 0) {
        DJDBKFNEKPF = other.DJDBKFNEKPF;
      }
      avatarList_.Add(other.avatarList_);
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Index != 0) {
        Index = other.Index;
      }
      if (other.ExtraLineupType != global::EggLink.DanhengServer.Proto.ExtraLineupType.LineupNone) {
        ExtraLineupType = other.ExtraLineupType;
      }
      if (other.IsVirtual != false) {
        IsVirtual = other.IsVirtual;
      }
      if (other.LeaderSlot != 0) {
        LeaderSlot = other.LeaderSlot;
      }
      hKBIIDJENIB_.Add(other.hKBIIDJENIB_);
      if (other.POJOHOHKPPA != false) {
        POJOHOHKPPA = other.POJOHOHKPPA;
      }
      if (other.MaxMp != 0) {
        MaxMp = other.MaxMp;
      }
      if (other.Mp != 0) {
        Mp = other.Mp;
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
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 24: {
            DJDBKFNEKPF = input.ReadUInt32();
            break;
          }
          case 32: {
            Index = input.ReadUInt32();
            break;
          }
          case 48: {
            MaxMp = input.ReadUInt32();
            break;
          }
          case 56: {
            LeaderSlot = input.ReadUInt32();
            break;
          }
          case 64: {
            IsVirtual = input.ReadBool();
            break;
          }
          case 72: {
            Mp = input.ReadUInt32();
            break;
          }
          case 82:
          case 80: {
            hKBIIDJENIB_.AddEntriesFrom(input, _repeated_hKBIIDJENIB_codec);
            break;
          }
          case 88: {
            PlaneId = input.ReadUInt32();
            break;
          }
          case 96: {
            POJOHOHKPPA = input.ReadBool();
            break;
          }
          case 104: {
            ExtraLineupType = (global::EggLink.DanhengServer.Proto.ExtraLineupType) input.ReadEnum();
            break;
          }
          case 122: {
            avatarList_.AddEntriesFrom(input, _repeated_avatarList_codec);
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
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 24: {
            DJDBKFNEKPF = input.ReadUInt32();
            break;
          }
          case 32: {
            Index = input.ReadUInt32();
            break;
          }
          case 48: {
            MaxMp = input.ReadUInt32();
            break;
          }
          case 56: {
            LeaderSlot = input.ReadUInt32();
            break;
          }
          case 64: {
            IsVirtual = input.ReadBool();
            break;
          }
          case 72: {
            Mp = input.ReadUInt32();
            break;
          }
          case 82:
          case 80: {
            hKBIIDJENIB_.AddEntriesFrom(ref input, _repeated_hKBIIDJENIB_codec);
            break;
          }
          case 88: {
            PlaneId = input.ReadUInt32();
            break;
          }
          case 96: {
            POJOHOHKPPA = input.ReadBool();
            break;
          }
          case 104: {
            ExtraLineupType = (global::EggLink.DanhengServer.Proto.ExtraLineupType) input.ReadEnum();
            break;
          }
          case 122: {
            avatarList_.AddEntriesFrom(ref input, _repeated_avatarList_codec);
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
