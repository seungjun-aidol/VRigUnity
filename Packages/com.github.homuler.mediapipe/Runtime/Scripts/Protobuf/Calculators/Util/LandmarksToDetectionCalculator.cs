// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: mediapipe/calculators/util/landmarks_to_detection_calculator.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Mediapipe {

  /// <summary>Holder for reflection information generated from mediapipe/calculators/util/landmarks_to_detection_calculator.proto</summary>
  public static partial class LandmarksToDetectionCalculatorReflection {

    #region Descriptor
    /// <summary>File descriptor for mediapipe/calculators/util/landmarks_to_detection_calculator.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LandmarksToDetectionCalculatorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkJtZWRpYXBpcGUvY2FsY3VsYXRvcnMvdXRpbC9sYW5kbWFya3NfdG9fZGV0",
            "ZWN0aW9uX2NhbGN1bGF0b3IucHJvdG8SCW1lZGlhcGlwZRokbWVkaWFwaXBl",
            "L2ZyYW1ld29yay9jYWxjdWxhdG9yLnByb3RvIqoBCiVMYW5kbWFya3NUb0Rl",
            "dGVjdGlvbkNhbGN1bGF0b3JPcHRpb25zEiEKGXNlbGVjdGVkX2xhbmRtYXJr",
            "X2luZGljZXMYASADKAUyXgoDZXh0EhwubWVkaWFwaXBlLkNhbGN1bGF0b3JP",
            "cHRpb25zGPWpiXwgASgLMjAubWVkaWFwaXBlLkxhbmRtYXJrc1RvRGV0ZWN0",
            "aW9uQ2FsY3VsYXRvck9wdGlvbnM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Mediapipe.CalculatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Mediapipe.LandmarksToDetectionCalculatorOptions), global::Mediapipe.LandmarksToDetectionCalculatorOptions.Parser, new[]{ "SelectedLandmarkIndices" }, null, null, new pb::Extension[] { global::Mediapipe.LandmarksToDetectionCalculatorOptions.Extensions.Ext }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class LandmarksToDetectionCalculatorOptions : pb::IMessage<LandmarksToDetectionCalculatorOptions>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LandmarksToDetectionCalculatorOptions> _parser = new pb::MessageParser<LandmarksToDetectionCalculatorOptions>(() => new LandmarksToDetectionCalculatorOptions());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LandmarksToDetectionCalculatorOptions> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Mediapipe.LandmarksToDetectionCalculatorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LandmarksToDetectionCalculatorOptions() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LandmarksToDetectionCalculatorOptions(LandmarksToDetectionCalculatorOptions other) : this() {
      selectedLandmarkIndices_ = other.selectedLandmarkIndices_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LandmarksToDetectionCalculatorOptions Clone() {
      return new LandmarksToDetectionCalculatorOptions(this);
    }

    /// <summary>Field number for the "selected_landmark_indices" field.</summary>
    public const int SelectedLandmarkIndicesFieldNumber = 1;
    private static readonly pb::FieldCodec<int> _repeated_selectedLandmarkIndices_codec
        = pb::FieldCodec.ForInt32(8);
    private readonly pbc::RepeatedField<int> selectedLandmarkIndices_ = new pbc::RepeatedField<int>();
    /// <summary>
    /// A subset of indices to be included when creating the detection.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<int> SelectedLandmarkIndices {
      get { return selectedLandmarkIndices_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LandmarksToDetectionCalculatorOptions);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LandmarksToDetectionCalculatorOptions other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!selectedLandmarkIndices_.Equals(other.selectedLandmarkIndices_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= selectedLandmarkIndices_.GetHashCode();
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
      selectedLandmarkIndices_.WriteTo(output, _repeated_selectedLandmarkIndices_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      selectedLandmarkIndices_.WriteTo(ref output, _repeated_selectedLandmarkIndices_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += selectedLandmarkIndices_.CalculateSize(_repeated_selectedLandmarkIndices_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(LandmarksToDetectionCalculatorOptions other) {
      if (other == null) {
        return;
      }
      selectedLandmarkIndices_.Add(other.selectedLandmarkIndices_);
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
            selectedLandmarkIndices_.AddEntriesFrom(input, _repeated_selectedLandmarkIndices_codec);
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
            selectedLandmarkIndices_.AddEntriesFrom(ref input, _repeated_selectedLandmarkIndices_codec);
            break;
          }
        }
      }
    }
    #endif

    #region Extensions
    /// <summary>Container for extensions for other messages declared in the LandmarksToDetectionCalculatorOptions message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Extensions {
      public static readonly pb::Extension<global::Mediapipe.CalculatorOptions, global::Mediapipe.LandmarksToDetectionCalculatorOptions> Ext =
        new pb::Extension<global::Mediapipe.CalculatorOptions, global::Mediapipe.LandmarksToDetectionCalculatorOptions>(260199669, pb::FieldCodec.ForMessage(2081597354, global::Mediapipe.LandmarksToDetectionCalculatorOptions.Parser));
    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code