// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: enfonica/voice/v1beta1/sip_info.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Enfonica.Voice.V1Beta1 {

  /// <summary>Holder for reflection information generated from enfonica/voice/v1beta1/sip_info.proto</summary>
  public static partial class SipInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for enfonica/voice/v1beta1/sip_info.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SipInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVlbmZvbmljYS92b2ljZS92MWJldGExL3NpcF9pbmZvLnByb3RvEhZlbmZv",
            "bmljYS52b2ljZS52MWJldGExGh9nb29nbGUvcHJvdG9idWYvdGltZXN0YW1w",
            "LnByb3RvGh5nb29nbGUvcHJvdG9idWYvZHVyYXRpb24ucHJvdG8aHGdvb2ds",
            "ZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8aGWdvb2dsZS9hcGkvcmVzb3VyY2Uu",
            "cHJvdG8aH2dvb2dsZS9hcGkvZmllbGRfYmVoYXZpb3IucHJvdG8aF2dvb2ds",
            "ZS9hcGkvY2xpZW50LnByb3RvIpwCCgdTaXBJbmZvEgwKBG5hbWUYASABKAkS",
            "LgoKc3RhcnRfdGltZRgCIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5UaW1lc3Rh",
            "bXASLAoIZW5kX3RpbWUYAyABKAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0",
            "YW1wEjQKCG1lc3NhZ2VzGAQgAygLMiIuZW5mb25pY2Eudm9pY2UudjFiZXRh",
            "MS5TaXBNZXNzYWdlEhMKC3NpcF9jYWxsX2lkGAUgASgJEgwKBHBjYXAYBiAB",
            "KAw6TOpBSQoedm9pY2UuYXBpLmVuZm9uaWNhLmNvbS9TaXBJbmZvEidwcm9q",
            "ZWN0cy97cHJvamVjdH0vY2FsbHMve2NhbGx9L3NpcEluZm8izgEKClNpcE1l",
            "c3NhZ2USMgoPb2Zmc2V0X2R1cmF0aW9uGAEgASgLMhkuZ29vZ2xlLnByb3Rv",
            "YnVmLkR1cmF0aW9uEhEKCXNvdXJjZV9pcBgCIAEoCRITCgtzb3VyY2VfcG9y",
            "dBgDIAEoBRIWCg5kZXN0aW5hdGlvbl9pcBgEIAEoCRIYChBkZXN0aW5hdGlv",
            "bl9wb3J0GAUgASgFEg4KBm1ldGhvZBgGIAEoCRIUCgxyZXF1ZXN0X2xpbmUY",
            "ByABKAkSDAoEZGF0YRgIIAEoCSJJChFHZXRTaXBJbmZvUmVxdWVzdBI0CgRu",
            "YW1lGAEgASgJQibgQQL6QSAKHnZvaWNlLmFwaS5lbmZvbmljYS5jb20vU2lw",
            "SW5mbzLnAQoOU2lwSW5mb1NlcnZpY2USkwEKCkdldFNpcEluZm8SKS5lbmZv",
            "bmljYS52b2ljZS52MWJldGExLkdldFNpcEluZm9SZXF1ZXN0Gh8uZW5mb25p",
            "Y2Eudm9pY2UudjFiZXRhMS5TaXBJbmZvIjmC0+STAiwSKi92MWJldGExL3tu",
            "YW1lPXByb2plY3RzLyovY2FsbHMvKi9zaXBJbmZvfdpBBG5hbWUaP8pBFnZv",
            "aWNlLmFwaS5lbmZvbmljYS5jb23SQSNodHRwczovL2FwaS5lbmZvbmljYS5j",
            "b20vYXV0aC92b2ljZUKFAQoaY29tLmVuZm9uaWNhLnZvaWNlLnYxYmV0YTFC",
            "DFNpcEluZm9Qcm90b1ABWjNnaXRodWIuY29tL2VuZm9uaWNhL2VuZm9uaWNh",
            "LWdvL3ZvaWNlL3YxYmV0YTE7dm9pY2X4AQGiAgVFTkZPTqoCFkVuZm9uaWNh",
            "LlZvaWNlLlYxQmV0YTFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.DurationReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Enfonica.Voice.V1Beta1.SipInfo), global::Enfonica.Voice.V1Beta1.SipInfo.Parser, new[]{ "Name", "StartTime", "EndTime", "Messages", "SipCallId", "Pcap" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Enfonica.Voice.V1Beta1.SipMessage), global::Enfonica.Voice.V1Beta1.SipMessage.Parser, new[]{ "OffsetDuration", "SourceIp", "SourcePort", "DestinationIp", "DestinationPort", "Method", "RequestLine", "Data" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Enfonica.Voice.V1Beta1.GetSipInfoRequest), global::Enfonica.Voice.V1Beta1.GetSipInfoRequest.Parser, new[]{ "Name" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The SipInfo resource. This represents information about a SIP call.
  /// </summary>
  public sealed partial class SipInfo : pb::IMessage<SipInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SipInfo> _parser = new pb::MessageParser<SipInfo>(() => new SipInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SipInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Enfonica.Voice.V1Beta1.SipInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SipInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SipInfo(SipInfo other) : this() {
      name_ = other.name_;
      startTime_ = other.startTime_ != null ? other.startTime_.Clone() : null;
      endTime_ = other.endTime_ != null ? other.endTime_.Clone() : null;
      messages_ = other.messages_.Clone();
      sipCallId_ = other.sipCallId_;
      pcap_ = other.pcap_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SipInfo Clone() {
      return new SipInfo(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Resource name of the sip_info. It is of the form
    /// `projects/*/calls/*/sipInfo`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "start_time" field.</summary>
    public const int StartTimeFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Timestamp startTime_;
    /// <summary>
    /// The time that the SIP dialog started.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp StartTime {
      get { return startTime_; }
      set {
        startTime_ = value;
      }
    }

    /// <summary>Field number for the "end_time" field.</summary>
    public const int EndTimeFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Timestamp endTime_;
    /// <summary>
    /// The time that the SIP dialog ended.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp EndTime {
      get { return endTime_; }
      set {
        endTime_ = value;
      }
    }

    /// <summary>Field number for the "messages" field.</summary>
    public const int MessagesFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Enfonica.Voice.V1Beta1.SipMessage> _repeated_messages_codec
        = pb::FieldCodec.ForMessage(34, global::Enfonica.Voice.V1Beta1.SipMessage.Parser);
    private readonly pbc::RepeatedField<global::Enfonica.Voice.V1Beta1.SipMessage> messages_ = new pbc::RepeatedField<global::Enfonica.Voice.V1Beta1.SipMessage>();
    /// <summary>
    /// The messages, in chronological order, that form the SIP dialog.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Enfonica.Voice.V1Beta1.SipMessage> Messages {
      get { return messages_; }
    }

    /// <summary>Field number for the "sip_call_id" field.</summary>
    public const int SipCallIdFieldNumber = 5;
    private string sipCallId_ = "";
    /// <summary>
    /// The `Call-ID` of the SIP call.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SipCallId {
      get { return sipCallId_; }
      set {
        sipCallId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "pcap" field.</summary>
    public const int PcapFieldNumber = 6;
    private pb::ByteString pcap_ = pb::ByteString.Empty;
    /// <summary>
    /// The PCAP file data.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Pcap {
      get { return pcap_; }
      set {
        pcap_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SipInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SipInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (!object.Equals(StartTime, other.StartTime)) return false;
      if (!object.Equals(EndTime, other.EndTime)) return false;
      if(!messages_.Equals(other.messages_)) return false;
      if (SipCallId != other.SipCallId) return false;
      if (Pcap != other.Pcap) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (startTime_ != null) hash ^= StartTime.GetHashCode();
      if (endTime_ != null) hash ^= EndTime.GetHashCode();
      hash ^= messages_.GetHashCode();
      if (SipCallId.Length != 0) hash ^= SipCallId.GetHashCode();
      if (Pcap.Length != 0) hash ^= Pcap.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (startTime_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(StartTime);
      }
      if (endTime_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(EndTime);
      }
      messages_.WriteTo(output, _repeated_messages_codec);
      if (SipCallId.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(SipCallId);
      }
      if (Pcap.Length != 0) {
        output.WriteRawTag(50);
        output.WriteBytes(Pcap);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (startTime_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(StartTime);
      }
      if (endTime_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(EndTime);
      }
      messages_.WriteTo(ref output, _repeated_messages_codec);
      if (SipCallId.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(SipCallId);
      }
      if (Pcap.Length != 0) {
        output.WriteRawTag(50);
        output.WriteBytes(Pcap);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (startTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(StartTime);
      }
      if (endTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EndTime);
      }
      size += messages_.CalculateSize(_repeated_messages_codec);
      if (SipCallId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SipCallId);
      }
      if (Pcap.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Pcap);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SipInfo other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.startTime_ != null) {
        if (startTime_ == null) {
          StartTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        StartTime.MergeFrom(other.StartTime);
      }
      if (other.endTime_ != null) {
        if (endTime_ == null) {
          EndTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        EndTime.MergeFrom(other.EndTime);
      }
      messages_.Add(other.messages_);
      if (other.SipCallId.Length != 0) {
        SipCallId = other.SipCallId;
      }
      if (other.Pcap.Length != 0) {
        Pcap = other.Pcap;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
          case 18: {
            if (startTime_ == null) {
              StartTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(StartTime);
            break;
          }
          case 26: {
            if (endTime_ == null) {
              EndTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(EndTime);
            break;
          }
          case 34: {
            messages_.AddEntriesFrom(input, _repeated_messages_codec);
            break;
          }
          case 42: {
            SipCallId = input.ReadString();
            break;
          }
          case 50: {
            Pcap = input.ReadBytes();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
          case 18: {
            if (startTime_ == null) {
              StartTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(StartTime);
            break;
          }
          case 26: {
            if (endTime_ == null) {
              EndTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(EndTime);
            break;
          }
          case 34: {
            messages_.AddEntriesFrom(ref input, _repeated_messages_codec);
            break;
          }
          case 42: {
            SipCallId = input.ReadString();
            break;
          }
          case 50: {
            Pcap = input.ReadBytes();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// A SIP message that is part of a dialog.
  /// </summary>
  public sealed partial class SipMessage : pb::IMessage<SipMessage>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SipMessage> _parser = new pb::MessageParser<SipMessage>(() => new SipMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SipMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Enfonica.Voice.V1Beta1.SipInfoReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SipMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SipMessage(SipMessage other) : this() {
      offsetDuration_ = other.offsetDuration_ != null ? other.offsetDuration_.Clone() : null;
      sourceIp_ = other.sourceIp_;
      sourcePort_ = other.sourcePort_;
      destinationIp_ = other.destinationIp_;
      destinationPort_ = other.destinationPort_;
      method_ = other.method_;
      requestLine_ = other.requestLine_;
      data_ = other.data_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SipMessage Clone() {
      return new SipMessage(this);
    }

    /// <summary>Field number for the "offset_duration" field.</summary>
    public const int OffsetDurationFieldNumber = 1;
    private global::Google.Protobuf.WellKnownTypes.Duration offsetDuration_;
    /// <summary>
    /// The offset relative to the start_time that this message was sent/received.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Duration OffsetDuration {
      get { return offsetDuration_; }
      set {
        offsetDuration_ = value;
      }
    }

    /// <summary>Field number for the "source_ip" field.</summary>
    public const int SourceIpFieldNumber = 2;
    private string sourceIp_ = "";
    /// <summary>
    /// The source IP where the message originated.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SourceIp {
      get { return sourceIp_; }
      set {
        sourceIp_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "source_port" field.</summary>
    public const int SourcePortFieldNumber = 3;
    private int sourcePort_;
    /// <summary>
    /// The source port where the message originated.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int SourcePort {
      get { return sourcePort_; }
      set {
        sourcePort_ = value;
      }
    }

    /// <summary>Field number for the "destination_ip" field.</summary>
    public const int DestinationIpFieldNumber = 4;
    private string destinationIp_ = "";
    /// <summary>
    /// The destination IP where the message was sent.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DestinationIp {
      get { return destinationIp_; }
      set {
        destinationIp_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "destination_port" field.</summary>
    public const int DestinationPortFieldNumber = 5;
    private int destinationPort_;
    /// <summary>
    /// The destination port where the message was sent.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int DestinationPort {
      get { return destinationPort_; }
      set {
        destinationPort_ = value;
      }
    }

    /// <summary>Field number for the "method" field.</summary>
    public const int MethodFieldNumber = 6;
    private string method_ = "";
    /// <summary>
    /// The method or response code. For example, "INVITE" or "100".
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Method {
      get { return method_; }
      set {
        method_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "request_line" field.</summary>
    public const int RequestLineFieldNumber = 7;
    private string requestLine_ = "";
    /// <summary>
    /// The full request line. For example, "100 Trying".
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RequestLine {
      get { return requestLine_; }
      set {
        requestLine_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "data" field.</summary>
    public const int DataFieldNumber = 8;
    private string data_ = "";
    /// <summary>
    /// The entire contents of the SIP packet, including the request line, headers
    /// and body.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Data {
      get { return data_; }
      set {
        data_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SipMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SipMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(OffsetDuration, other.OffsetDuration)) return false;
      if (SourceIp != other.SourceIp) return false;
      if (SourcePort != other.SourcePort) return false;
      if (DestinationIp != other.DestinationIp) return false;
      if (DestinationPort != other.DestinationPort) return false;
      if (Method != other.Method) return false;
      if (RequestLine != other.RequestLine) return false;
      if (Data != other.Data) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (offsetDuration_ != null) hash ^= OffsetDuration.GetHashCode();
      if (SourceIp.Length != 0) hash ^= SourceIp.GetHashCode();
      if (SourcePort != 0) hash ^= SourcePort.GetHashCode();
      if (DestinationIp.Length != 0) hash ^= DestinationIp.GetHashCode();
      if (DestinationPort != 0) hash ^= DestinationPort.GetHashCode();
      if (Method.Length != 0) hash ^= Method.GetHashCode();
      if (RequestLine.Length != 0) hash ^= RequestLine.GetHashCode();
      if (Data.Length != 0) hash ^= Data.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (offsetDuration_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(OffsetDuration);
      }
      if (SourceIp.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(SourceIp);
      }
      if (SourcePort != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(SourcePort);
      }
      if (DestinationIp.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(DestinationIp);
      }
      if (DestinationPort != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(DestinationPort);
      }
      if (Method.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Method);
      }
      if (RequestLine.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(RequestLine);
      }
      if (Data.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Data);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (offsetDuration_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(OffsetDuration);
      }
      if (SourceIp.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(SourceIp);
      }
      if (SourcePort != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(SourcePort);
      }
      if (DestinationIp.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(DestinationIp);
      }
      if (DestinationPort != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(DestinationPort);
      }
      if (Method.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Method);
      }
      if (RequestLine.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(RequestLine);
      }
      if (Data.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Data);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (offsetDuration_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(OffsetDuration);
      }
      if (SourceIp.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SourceIp);
      }
      if (SourcePort != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(SourcePort);
      }
      if (DestinationIp.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DestinationIp);
      }
      if (DestinationPort != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(DestinationPort);
      }
      if (Method.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Method);
      }
      if (RequestLine.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RequestLine);
      }
      if (Data.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Data);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SipMessage other) {
      if (other == null) {
        return;
      }
      if (other.offsetDuration_ != null) {
        if (offsetDuration_ == null) {
          OffsetDuration = new global::Google.Protobuf.WellKnownTypes.Duration();
        }
        OffsetDuration.MergeFrom(other.OffsetDuration);
      }
      if (other.SourceIp.Length != 0) {
        SourceIp = other.SourceIp;
      }
      if (other.SourcePort != 0) {
        SourcePort = other.SourcePort;
      }
      if (other.DestinationIp.Length != 0) {
        DestinationIp = other.DestinationIp;
      }
      if (other.DestinationPort != 0) {
        DestinationPort = other.DestinationPort;
      }
      if (other.Method.Length != 0) {
        Method = other.Method;
      }
      if (other.RequestLine.Length != 0) {
        RequestLine = other.RequestLine;
      }
      if (other.Data.Length != 0) {
        Data = other.Data;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
            if (offsetDuration_ == null) {
              OffsetDuration = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(OffsetDuration);
            break;
          }
          case 18: {
            SourceIp = input.ReadString();
            break;
          }
          case 24: {
            SourcePort = input.ReadInt32();
            break;
          }
          case 34: {
            DestinationIp = input.ReadString();
            break;
          }
          case 40: {
            DestinationPort = input.ReadInt32();
            break;
          }
          case 50: {
            Method = input.ReadString();
            break;
          }
          case 58: {
            RequestLine = input.ReadString();
            break;
          }
          case 66: {
            Data = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            if (offsetDuration_ == null) {
              OffsetDuration = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(OffsetDuration);
            break;
          }
          case 18: {
            SourceIp = input.ReadString();
            break;
          }
          case 24: {
            SourcePort = input.ReadInt32();
            break;
          }
          case 34: {
            DestinationIp = input.ReadString();
            break;
          }
          case 40: {
            DestinationPort = input.ReadInt32();
            break;
          }
          case 50: {
            Method = input.ReadString();
            break;
          }
          case 58: {
            RequestLine = input.ReadString();
            break;
          }
          case 66: {
            Data = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// The GetSipInfo request message.
  /// </summary>
  public sealed partial class GetSipInfoRequest : pb::IMessage<GetSipInfoRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetSipInfoRequest> _parser = new pb::MessageParser<GetSipInfoRequest>(() => new GetSipInfoRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetSipInfoRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Enfonica.Voice.V1Beta1.SipInfoReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetSipInfoRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetSipInfoRequest(GetSipInfoRequest other) : this() {
      name_ = other.name_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetSipInfoRequest Clone() {
      return new GetSipInfoRequest(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// The resource name of the SipInfo to retrieve.
    /// Must be of the form `projects/*/calls/*/sipInfo`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetSipInfoRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetSipInfoRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetSipInfoRequest other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
