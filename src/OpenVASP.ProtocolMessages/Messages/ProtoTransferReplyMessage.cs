// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ProtoTransferReplyMessage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OpenVASP.ProtocolMessages.Messages {

  /// <summary>Holder for reflection information generated from ProtoTransferReplyMessage.proto</summary>
  public static partial class ProtoTransferReplyMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for ProtoTransferReplyMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProtoTransferReplyMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9Qcm90b1RyYW5zZmVyUmVwbHlNZXNzYWdlLnByb3RvEhFwcm90b2J1Zl9v",
            "cGVudmFzcBoTUHJvdG9WYXNwSW5mby5wcm90bxoSUHJvdG9NZXNzYWdlLnBy",
            "b3RvGhVQcm90b09yaWdpbmF0b3IucHJvdG8aFlByb3RvQmVuZWZpY2lhcnku",
            "cHJvdG8aGFByb3RvVHJhbnNmZXJSZXBseS5wcm90byK9AgoZUHJvdG9UcmFu",
            "c2ZlclJlcGx5TWVzc2FnZRIwCgdtZXNzYWdlGAEgASgLMh8ucHJvdG9idWZf",
            "b3BlbnZhc3AuUHJvdG9NZXNzYWdlEjYKCm9yaWdpbmF0b3IYAiABKAsyIi5w",
            "cm90b2J1Zl9vcGVudmFzcC5Qcm90b09yaWdpbmF0b3ISOAoLYmVuZWZpY2lh",
            "cnkYAyABKAsyIy5wcm90b2J1Zl9vcGVudmFzcC5Qcm90b0JlbmVmaWNpYXJ5",
            "EjcKCHRyYW5zZmVyGAQgASgLMiUucHJvdG9idWZfb3BlbnZhc3AuUHJvdG9U",
            "cmFuc2ZlclJlcGx5Eg8KB2NvbW1lbnQYBSABKAkSMgoIVmFzcEluZm8YBiAB",
            "KAsyIC5wcm90b2J1Zl9vcGVudmFzcC5Qcm90b1Zhc3BJbmZvQiWqAiJPcGVu",
            "VkFTUC5Qcm90b2NvbE1lc3NhZ2VzLk1lc3NhZ2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OpenVASP.ProtocolMessages.Messages.ProtoVaspInfoReflection.Descriptor, global::OpenVASP.ProtocolMessages.Messages.ProtoMessageReflection.Descriptor, global::OpenVASP.ProtocolMessages.Messages.ProtoOriginatorReflection.Descriptor, global::OpenVASP.ProtocolMessages.Messages.ProtoBeneficiaryReflection.Descriptor, global::OpenVASP.ProtocolMessages.Messages.ProtoTransferReplyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OpenVASP.ProtocolMessages.Messages.ProtoTransferReplyMessage), global::OpenVASP.ProtocolMessages.Messages.ProtoTransferReplyMessage.Parser, new[]{ "Message", "Originator", "Beneficiary", "Transfer", "Comment", "VaspInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ProtoTransferReplyMessage : pb::IMessage<ProtoTransferReplyMessage> {
    private static readonly pb::MessageParser<ProtoTransferReplyMessage> _parser = new pb::MessageParser<ProtoTransferReplyMessage>(() => new ProtoTransferReplyMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ProtoTransferReplyMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OpenVASP.ProtocolMessages.Messages.ProtoTransferReplyMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProtoTransferReplyMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProtoTransferReplyMessage(ProtoTransferReplyMessage other) : this() {
      message_ = other.message_ != null ? other.message_.Clone() : null;
      originator_ = other.originator_ != null ? other.originator_.Clone() : null;
      beneficiary_ = other.beneficiary_ != null ? other.beneficiary_.Clone() : null;
      transfer_ = other.transfer_ != null ? other.transfer_.Clone() : null;
      comment_ = other.comment_;
      vaspInfo_ = other.vaspInfo_ != null ? other.vaspInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProtoTransferReplyMessage Clone() {
      return new ProtoTransferReplyMessage(this);
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 1;
    private global::OpenVASP.ProtocolMessages.Messages.ProtoMessage message_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::OpenVASP.ProtocolMessages.Messages.ProtoMessage Message {
      get { return message_; }
      set {
        message_ = value;
      }
    }

    /// <summary>Field number for the "originator" field.</summary>
    public const int OriginatorFieldNumber = 2;
    private global::OpenVASP.ProtocolMessages.Messages.ProtoOriginator originator_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::OpenVASP.ProtocolMessages.Messages.ProtoOriginator Originator {
      get { return originator_; }
      set {
        originator_ = value;
      }
    }

    /// <summary>Field number for the "beneficiary" field.</summary>
    public const int BeneficiaryFieldNumber = 3;
    private global::OpenVASP.ProtocolMessages.Messages.ProtoBeneficiary beneficiary_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::OpenVASP.ProtocolMessages.Messages.ProtoBeneficiary Beneficiary {
      get { return beneficiary_; }
      set {
        beneficiary_ = value;
      }
    }

    /// <summary>Field number for the "transfer" field.</summary>
    public const int TransferFieldNumber = 4;
    private global::OpenVASP.ProtocolMessages.Messages.ProtoTransferReply transfer_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::OpenVASP.ProtocolMessages.Messages.ProtoTransferReply Transfer {
      get { return transfer_; }
      set {
        transfer_ = value;
      }
    }

    /// <summary>Field number for the "comment" field.</summary>
    public const int CommentFieldNumber = 5;
    private string comment_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Comment {
      get { return comment_; }
      set {
        comment_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "VaspInfo" field.</summary>
    public const int VaspInfoFieldNumber = 6;
    private global::OpenVASP.ProtocolMessages.Messages.ProtoVaspInfo vaspInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::OpenVASP.ProtocolMessages.Messages.ProtoVaspInfo VaspInfo {
      get { return vaspInfo_; }
      set {
        vaspInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ProtoTransferReplyMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ProtoTransferReplyMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Message, other.Message)) return false;
      if (!object.Equals(Originator, other.Originator)) return false;
      if (!object.Equals(Beneficiary, other.Beneficiary)) return false;
      if (!object.Equals(Transfer, other.Transfer)) return false;
      if (Comment != other.Comment) return false;
      if (!object.Equals(VaspInfo, other.VaspInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (message_ != null) hash ^= Message.GetHashCode();
      if (originator_ != null) hash ^= Originator.GetHashCode();
      if (beneficiary_ != null) hash ^= Beneficiary.GetHashCode();
      if (transfer_ != null) hash ^= Transfer.GetHashCode();
      if (Comment.Length != 0) hash ^= Comment.GetHashCode();
      if (vaspInfo_ != null) hash ^= VaspInfo.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (message_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Message);
      }
      if (originator_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Originator);
      }
      if (beneficiary_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Beneficiary);
      }
      if (transfer_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Transfer);
      }
      if (Comment.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Comment);
      }
      if (vaspInfo_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(VaspInfo);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (message_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Message);
      }
      if (originator_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Originator);
      }
      if (beneficiary_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Beneficiary);
      }
      if (transfer_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Transfer);
      }
      if (Comment.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Comment);
      }
      if (vaspInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(VaspInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ProtoTransferReplyMessage other) {
      if (other == null) {
        return;
      }
      if (other.message_ != null) {
        if (message_ == null) {
          Message = new global::OpenVASP.ProtocolMessages.Messages.ProtoMessage();
        }
        Message.MergeFrom(other.Message);
      }
      if (other.originator_ != null) {
        if (originator_ == null) {
          Originator = new global::OpenVASP.ProtocolMessages.Messages.ProtoOriginator();
        }
        Originator.MergeFrom(other.Originator);
      }
      if (other.beneficiary_ != null) {
        if (beneficiary_ == null) {
          Beneficiary = new global::OpenVASP.ProtocolMessages.Messages.ProtoBeneficiary();
        }
        Beneficiary.MergeFrom(other.Beneficiary);
      }
      if (other.transfer_ != null) {
        if (transfer_ == null) {
          Transfer = new global::OpenVASP.ProtocolMessages.Messages.ProtoTransferReply();
        }
        Transfer.MergeFrom(other.Transfer);
      }
      if (other.Comment.Length != 0) {
        Comment = other.Comment;
      }
      if (other.vaspInfo_ != null) {
        if (vaspInfo_ == null) {
          VaspInfo = new global::OpenVASP.ProtocolMessages.Messages.ProtoVaspInfo();
        }
        VaspInfo.MergeFrom(other.VaspInfo);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (message_ == null) {
              Message = new global::OpenVASP.ProtocolMessages.Messages.ProtoMessage();
            }
            input.ReadMessage(Message);
            break;
          }
          case 18: {
            if (originator_ == null) {
              Originator = new global::OpenVASP.ProtocolMessages.Messages.ProtoOriginator();
            }
            input.ReadMessage(Originator);
            break;
          }
          case 26: {
            if (beneficiary_ == null) {
              Beneficiary = new global::OpenVASP.ProtocolMessages.Messages.ProtoBeneficiary();
            }
            input.ReadMessage(Beneficiary);
            break;
          }
          case 34: {
            if (transfer_ == null) {
              Transfer = new global::OpenVASP.ProtocolMessages.Messages.ProtoTransferReply();
            }
            input.ReadMessage(Transfer);
            break;
          }
          case 42: {
            Comment = input.ReadString();
            break;
          }
          case 50: {
            if (vaspInfo_ == null) {
              VaspInfo = new global::OpenVASP.ProtocolMessages.Messages.ProtoVaspInfo();
            }
            input.ReadMessage(VaspInfo);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code