// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetMailScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetMailScRsp.proto</summary>
  public static partial class GetMailScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetMailScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetMailScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJHZXRNYWlsU2NSc3AucHJvdG8aEENsaWVudE1haWwucHJvdG8imAEKDEdl",
            "dE1haWxTY1JzcBIOCgZpc19lbmQYCiABKAgSJQoQbm90aWNlX21haWxfbGlz",
            "dBgCIAMoCzILLkNsaWVudE1haWwSHgoJbWFpbF9saXN0GA0gAygLMgsuQ2xp",
            "ZW50TWFpbBINCgVzdGFydBgDIAEoDRIPCgdyZXRjb2RlGAEgASgNEhEKCXRv",
            "dGFsX251bRgGIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3Rv",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ClientMailReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetMailScRsp), global::EggLink.DanhengServer.Proto.GetMailScRsp.Parser, new[]{ "IsEnd", "NoticeMailList", "MailList", "Start", "Retcode", "TotalNum" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetMailScRsp : pb::IMessage<GetMailScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetMailScRsp> _parser = new pb::MessageParser<GetMailScRsp>(() => new GetMailScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetMailScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetMailScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetMailScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetMailScRsp(GetMailScRsp other) : this() {
      isEnd_ = other.isEnd_;
      noticeMailList_ = other.noticeMailList_.Clone();
      mailList_ = other.mailList_.Clone();
      start_ = other.start_;
      retcode_ = other.retcode_;
      totalNum_ = other.totalNum_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetMailScRsp Clone() {
      return new GetMailScRsp(this);
    }

    /// <summary>Field number for the "is_end" field.</summary>
    public const int IsEndFieldNumber = 10;
    private bool isEnd_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsEnd {
      get { return isEnd_; }
      set {
        isEnd_ = value;
      }
    }

    /// <summary>Field number for the "notice_mail_list" field.</summary>
    public const int NoticeMailListFieldNumber = 2;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.ClientMail> _repeated_noticeMailList_codec
        = pb::FieldCodec.ForMessage(18, global::EggLink.DanhengServer.Proto.ClientMail.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ClientMail> noticeMailList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ClientMail>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ClientMail> NoticeMailList {
      get { return noticeMailList_; }
    }

    /// <summary>Field number for the "mail_list" field.</summary>
    public const int MailListFieldNumber = 13;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.ClientMail> _repeated_mailList_codec
        = pb::FieldCodec.ForMessage(106, global::EggLink.DanhengServer.Proto.ClientMail.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ClientMail> mailList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ClientMail>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ClientMail> MailList {
      get { return mailList_; }
    }

    /// <summary>Field number for the "start" field.</summary>
    public const int StartFieldNumber = 3;
    private uint start_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Start {
      get { return start_; }
      set {
        start_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 1;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "total_num" field.</summary>
    public const int TotalNumFieldNumber = 6;
    private uint totalNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TotalNum {
      get { return totalNum_; }
      set {
        totalNum_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetMailScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetMailScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsEnd != other.IsEnd) return false;
      if(!noticeMailList_.Equals(other.noticeMailList_)) return false;
      if(!mailList_.Equals(other.mailList_)) return false;
      if (Start != other.Start) return false;
      if (Retcode != other.Retcode) return false;
      if (TotalNum != other.TotalNum) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsEnd != false) hash ^= IsEnd.GetHashCode();
      hash ^= noticeMailList_.GetHashCode();
      hash ^= mailList_.GetHashCode();
      if (Start != 0) hash ^= Start.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (TotalNum != 0) hash ^= TotalNum.GetHashCode();
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
      if (Retcode != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Retcode);
      }
      noticeMailList_.WriteTo(output, _repeated_noticeMailList_codec);
      if (Start != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Start);
      }
      if (TotalNum != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(TotalNum);
      }
      if (IsEnd != false) {
        output.WriteRawTag(80);
        output.WriteBool(IsEnd);
      }
      mailList_.WriteTo(output, _repeated_mailList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Retcode != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Retcode);
      }
      noticeMailList_.WriteTo(ref output, _repeated_noticeMailList_codec);
      if (Start != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Start);
      }
      if (TotalNum != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(TotalNum);
      }
      if (IsEnd != false) {
        output.WriteRawTag(80);
        output.WriteBool(IsEnd);
      }
      mailList_.WriteTo(ref output, _repeated_mailList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (IsEnd != false) {
        size += 1 + 1;
      }
      size += noticeMailList_.CalculateSize(_repeated_noticeMailList_codec);
      size += mailList_.CalculateSize(_repeated_mailList_codec);
      if (Start != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Start);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (TotalNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TotalNum);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetMailScRsp other) {
      if (other == null) {
        return;
      }
      if (other.IsEnd != false) {
        IsEnd = other.IsEnd;
      }
      noticeMailList_.Add(other.noticeMailList_);
      mailList_.Add(other.mailList_);
      if (other.Start != 0) {
        Start = other.Start;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.TotalNum != 0) {
        TotalNum = other.TotalNum;
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
            Retcode = input.ReadUInt32();
            break;
          }
          case 18: {
            noticeMailList_.AddEntriesFrom(input, _repeated_noticeMailList_codec);
            break;
          }
          case 24: {
            Start = input.ReadUInt32();
            break;
          }
          case 48: {
            TotalNum = input.ReadUInt32();
            break;
          }
          case 80: {
            IsEnd = input.ReadBool();
            break;
          }
          case 106: {
            mailList_.AddEntriesFrom(input, _repeated_mailList_codec);
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
            Retcode = input.ReadUInt32();
            break;
          }
          case 18: {
            noticeMailList_.AddEntriesFrom(ref input, _repeated_noticeMailList_codec);
            break;
          }
          case 24: {
            Start = input.ReadUInt32();
            break;
          }
          case 48: {
            TotalNum = input.ReadUInt32();
            break;
          }
          case 80: {
            IsEnd = input.ReadBool();
            break;
          }
          case 106: {
            mailList_.AddEntriesFrom(ref input, _repeated_mailList_codec);
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
