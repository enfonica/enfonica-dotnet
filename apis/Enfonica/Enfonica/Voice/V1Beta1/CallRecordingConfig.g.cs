// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: enfonica/voice/v1beta1/call_recording_config.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Enfonica.Voice.V1Beta1 {

  /// <summary>Holder for reflection information generated from enfonica/voice/v1beta1/call_recording_config.proto</summary>
  public static partial class CallRecordingConfigReflection {

    #region Descriptor
    /// <summary>File descriptor for enfonica/voice/v1beta1/call_recording_config.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CallRecordingConfigReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjJlbmZvbmljYS92b2ljZS92MWJldGExL2NhbGxfcmVjb3JkaW5nX2NvbmZp",
            "Zy5wcm90bxIWZW5mb25pY2Eudm9pY2UudjFiZXRhMRofZ29vZ2xlL3Byb3Rv",
            "YnVmL3RpbWVzdGFtcC5wcm90bxoeZ29vZ2xlL3Byb3RvYnVmL2R1cmF0aW9u",
            "LnByb3RvGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvGhlnb29nbGUv",
            "YXBpL3Jlc291cmNlLnByb3RvGh9nb29nbGUvYXBpL2ZpZWxkX2JlaGF2aW9y",
            "LnByb3RvGhdnb29nbGUvYXBpL2NsaWVudC5wcm90byKLAwoTQ2FsbFJlY29y",
            "ZGluZ0NvbmZpZxJRCgd0cmlnZ2VyGAEgASgOMkAuZW5mb25pY2Eudm9pY2Uu",
            "djFiZXRhMS5DYWxsUmVjb3JkaW5nQ29uZmlnLkNhbGxSZWNvcmRpbmdUcmln",
            "Z2VyEj8KD3Bvc3RfcHJvY2Vzc2luZxgCIAMoDjImLmVuZm9uaWNhLnZvaWNl",
            "LnYxYmV0YTEuUG9zdFByb2Nlc3NpbmcSGwoTcmVjb3JkaW5nX3JlYWR5X3Vy",
            "aRgDIAEoCRI8Cgp0cmFuc2NyaWJlGAQgASgOMiguZW5mb25pY2Eudm9pY2Uu",
            "djFiZXRhMS5UcmFuc2NyaWJlT3B0aW9uEh8KF3RyYW5zY3JpcHRpb25fcmVh",
            "ZHlfdXJpGAUgASgJImQKFENhbGxSZWNvcmRpbmdUcmlnZ2VyEiYKIkNBTExf",
            "UkVDT1JESU5HX1RSSUdHRVJfVU5TUEVDSUZJRUQQABIMCghESVNBQkxFRBAB",
            "EgoKBkFOU1dFUhACEgoKBkJSSURHRRADKkMKDlBvc3RQcm9jZXNzaW5nEh8K",
            "G1BPU1RfUFJPQ0VTU0lOR19VTlNQRUNJRklFRBAAEhAKDFRSSU1fU0lMRU5D",
            "RRABKlAKEFRyYW5zY3JpYmVPcHRpb24SIQodVFJBTlNDUklCRV9PUFRJT05f",
            "VU5TUEVDSUZJRUQQABIMCghESVNBQkxFRBABEgsKB0RFRkFVTFQQAkKRAQoa",
            "Y29tLmVuZm9uaWNhLnZvaWNlLnYxYmV0YTFCGENhbGxSZWNvcmRpbmdDb25m",
            "aWdQcm90b1ABWjNnaXRodWIuY29tL2VuZm9uaWNhL2VuZm9uaWNhLWdvL3Zv",
            "aWNlL3YxYmV0YTE7dm9pY2X4AQGiAgVFTkZPTqoCFkVuZm9uaWNhLlZvaWNl",
            "LlYxQmV0YTFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.DurationReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Enfonica.Voice.V1Beta1.PostProcessing), typeof(global::Enfonica.Voice.V1Beta1.TranscribeOption), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Enfonica.Voice.V1Beta1.CallRecordingConfig), global::Enfonica.Voice.V1Beta1.CallRecordingConfig.Parser, new[]{ "Trigger", "PostProcessing", "RecordingReadyUri", "Transcribe", "TranscriptionReadyUri" }, null, new[]{ typeof(global::Enfonica.Voice.V1Beta1.CallRecordingConfig.Types.CallRecordingTrigger) }, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// Post processing options.
  /// </summary>
  public enum PostProcessing {
    /// <summary>
    /// Unspecified post processing.
    /// </summary>
    [pbr::OriginalName("POST_PROCESSING_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// Trim silence from the start and end of the audio.
    /// </summary>
    [pbr::OriginalName("TRIM_SILENCE")] TrimSilence = 1,
  }

  /// <summary>
  /// How transcription should operate.
  /// </summary>
  public enum TranscribeOption {
    /// <summary>
    /// Unspecified transcribe option.
    /// </summary>
    [pbr::OriginalName("TRANSCRIBE_OPTION_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// Transcription is disabled.
    /// </summary>
    [pbr::OriginalName("DISABLED")] Disabled = 1,
    /// <summary>
    /// Transcribe using Enfonica's default transcription provider.
    /// </summary>
    [pbr::OriginalName("DEFAULT")] Default = 2,
  }

  #endregion

  #region Messages
  /// <summary>
  /// The configuration of how a call is recorded and transcribed.
  ///
  /// You need to comply with certain laws and regulations, including those regarding
  /// obtaining consent to record. Enfonica recommends that you consult with your legal
  /// counsel to make sure that you are complying with all applicable laws in connection
  /// with communications you record or store using Enfonica.
  /// </summary>
  public sealed partial class CallRecordingConfig : pb::IMessage<CallRecordingConfig>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CallRecordingConfig> _parser = new pb::MessageParser<CallRecordingConfig>(() => new CallRecordingConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CallRecordingConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Enfonica.Voice.V1Beta1.CallRecordingConfigReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CallRecordingConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CallRecordingConfig(CallRecordingConfig other) : this() {
      trigger_ = other.trigger_;
      postProcessing_ = other.postProcessing_.Clone();
      recordingReadyUri_ = other.recordingReadyUri_;
      transcribe_ = other.transcribe_;
      transcriptionReadyUri_ = other.transcriptionReadyUri_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CallRecordingConfig Clone() {
      return new CallRecordingConfig(this);
    }

    /// <summary>Field number for the "trigger" field.</summary>
    public const int TriggerFieldNumber = 1;
    private global::Enfonica.Voice.V1Beta1.CallRecordingConfig.Types.CallRecordingTrigger trigger_ = global::Enfonica.Voice.V1Beta1.CallRecordingConfig.Types.CallRecordingTrigger.Unspecified;
    /// <summary>
    /// Whether to record the call, and the event that should trigger recording
    /// to start. Defaults to DISABLED.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Enfonica.Voice.V1Beta1.CallRecordingConfig.Types.CallRecordingTrigger Trigger {
      get { return trigger_; }
      set {
        trigger_ = value;
      }
    }

    /// <summary>Field number for the "post_processing" field.</summary>
    public const int PostProcessingFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Enfonica.Voice.V1Beta1.PostProcessing> _repeated_postProcessing_codec
        = pb::FieldCodec.ForEnum(18, x => (int) x, x => (global::Enfonica.Voice.V1Beta1.PostProcessing) x);
    private readonly pbc::RepeatedField<global::Enfonica.Voice.V1Beta1.PostProcessing> postProcessing_ = new pbc::RepeatedField<global::Enfonica.Voice.V1Beta1.PostProcessing>();
    /// <summary>
    /// What post processing to perform on the recording. Defaults to NONE.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Enfonica.Voice.V1Beta1.PostProcessing> PostProcessing {
      get { return postProcessing_; }
    }

    /// <summary>Field number for the "recording_ready_uri" field.</summary>
    public const int RecordingReadyUriFieldNumber = 3;
    private string recordingReadyUri_ = "";
    /// <summary>
    /// The absolute URI where the recording ready webhook should be sent.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RecordingReadyUri {
      get { return recordingReadyUri_; }
      set {
        recordingReadyUri_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "transcribe" field.</summary>
    public const int TranscribeFieldNumber = 4;
    private global::Enfonica.Voice.V1Beta1.TranscribeOption transcribe_ = global::Enfonica.Voice.V1Beta1.TranscribeOption.Unspecified;
    /// <summary>
    /// Whether to transcribe the call. If transcription is enabled, call recording
    /// must also be enabled. Defaults to DISABLED.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Enfonica.Voice.V1Beta1.TranscribeOption Transcribe {
      get { return transcribe_; }
      set {
        transcribe_ = value;
      }
    }

    /// <summary>Field number for the "transcription_ready_uri" field.</summary>
    public const int TranscriptionReadyUriFieldNumber = 5;
    private string transcriptionReadyUri_ = "";
    /// <summary>
    /// The absolute URI where the transcription ready webhook should be sent.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TranscriptionReadyUri {
      get { return transcriptionReadyUri_; }
      set {
        transcriptionReadyUri_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CallRecordingConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CallRecordingConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Trigger != other.Trigger) return false;
      if(!postProcessing_.Equals(other.postProcessing_)) return false;
      if (RecordingReadyUri != other.RecordingReadyUri) return false;
      if (Transcribe != other.Transcribe) return false;
      if (TranscriptionReadyUri != other.TranscriptionReadyUri) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Trigger != global::Enfonica.Voice.V1Beta1.CallRecordingConfig.Types.CallRecordingTrigger.Unspecified) hash ^= Trigger.GetHashCode();
      hash ^= postProcessing_.GetHashCode();
      if (RecordingReadyUri.Length != 0) hash ^= RecordingReadyUri.GetHashCode();
      if (Transcribe != global::Enfonica.Voice.V1Beta1.TranscribeOption.Unspecified) hash ^= Transcribe.GetHashCode();
      if (TranscriptionReadyUri.Length != 0) hash ^= TranscriptionReadyUri.GetHashCode();
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
      if (Trigger != global::Enfonica.Voice.V1Beta1.CallRecordingConfig.Types.CallRecordingTrigger.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Trigger);
      }
      postProcessing_.WriteTo(output, _repeated_postProcessing_codec);
      if (RecordingReadyUri.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(RecordingReadyUri);
      }
      if (Transcribe != global::Enfonica.Voice.V1Beta1.TranscribeOption.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Transcribe);
      }
      if (TranscriptionReadyUri.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(TranscriptionReadyUri);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Trigger != global::Enfonica.Voice.V1Beta1.CallRecordingConfig.Types.CallRecordingTrigger.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Trigger);
      }
      postProcessing_.WriteTo(ref output, _repeated_postProcessing_codec);
      if (RecordingReadyUri.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(RecordingReadyUri);
      }
      if (Transcribe != global::Enfonica.Voice.V1Beta1.TranscribeOption.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Transcribe);
      }
      if (TranscriptionReadyUri.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(TranscriptionReadyUri);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Trigger != global::Enfonica.Voice.V1Beta1.CallRecordingConfig.Types.CallRecordingTrigger.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Trigger);
      }
      size += postProcessing_.CalculateSize(_repeated_postProcessing_codec);
      if (RecordingReadyUri.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RecordingReadyUri);
      }
      if (Transcribe != global::Enfonica.Voice.V1Beta1.TranscribeOption.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Transcribe);
      }
      if (TranscriptionReadyUri.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TranscriptionReadyUri);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CallRecordingConfig other) {
      if (other == null) {
        return;
      }
      if (other.Trigger != global::Enfonica.Voice.V1Beta1.CallRecordingConfig.Types.CallRecordingTrigger.Unspecified) {
        Trigger = other.Trigger;
      }
      postProcessing_.Add(other.postProcessing_);
      if (other.RecordingReadyUri.Length != 0) {
        RecordingReadyUri = other.RecordingReadyUri;
      }
      if (other.Transcribe != global::Enfonica.Voice.V1Beta1.TranscribeOption.Unspecified) {
        Transcribe = other.Transcribe;
      }
      if (other.TranscriptionReadyUri.Length != 0) {
        TranscriptionReadyUri = other.TranscriptionReadyUri;
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
          case 8: {
            Trigger = (global::Enfonica.Voice.V1Beta1.CallRecordingConfig.Types.CallRecordingTrigger) input.ReadEnum();
            break;
          }
          case 18:
          case 16: {
            postProcessing_.AddEntriesFrom(input, _repeated_postProcessing_codec);
            break;
          }
          case 26: {
            RecordingReadyUri = input.ReadString();
            break;
          }
          case 32: {
            Transcribe = (global::Enfonica.Voice.V1Beta1.TranscribeOption) input.ReadEnum();
            break;
          }
          case 42: {
            TranscriptionReadyUri = input.ReadString();
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
          case 8: {
            Trigger = (global::Enfonica.Voice.V1Beta1.CallRecordingConfig.Types.CallRecordingTrigger) input.ReadEnum();
            break;
          }
          case 18:
          case 16: {
            postProcessing_.AddEntriesFrom(ref input, _repeated_postProcessing_codec);
            break;
          }
          case 26: {
            RecordingReadyUri = input.ReadString();
            break;
          }
          case 32: {
            Transcribe = (global::Enfonica.Voice.V1Beta1.TranscribeOption) input.ReadEnum();
            break;
          }
          case 42: {
            TranscriptionReadyUri = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the CallRecordingConfig message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// The trigger to start call recording.
      /// </summary>
      public enum CallRecordingTrigger {
        /// <summary>
        /// Unspecified recording trigger.
        /// </summary>
        [pbr::OriginalName("CALL_RECORDING_TRIGGER_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Recording is disabled.
        /// </summary>
        [pbr::OriginalName("DISABLED")] Disabled = 1,
        /// <summary>
        /// Recording will begin when the call is answered.
        /// </summary>
        [pbr::OriginalName("ANSWER")] Answer = 2,
        /// <summary>
        /// Recording will begin when the call is bridged.
        /// This won't include any messages or menus played before the call was bridged.
        /// This is useful if you want to record only conversations.
        /// </summary>
        [pbr::OriginalName("BRIDGE")] Bridge = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
