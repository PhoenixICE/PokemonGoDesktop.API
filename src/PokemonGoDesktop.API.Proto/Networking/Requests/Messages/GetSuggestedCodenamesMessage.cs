// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: GetSuggestedCodenamesMessage.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Requests.Messages {

  /// <summary>Holder for reflection information generated from GetSuggestedCodenamesMessage.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class GetSuggestedCodenamesMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for GetSuggestedCodenamesMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetSuggestedCodenamesMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJHZXRTdWdnZXN0ZWRDb2RlbmFtZXNNZXNzYWdlLnByb3RvEidQT0dPUHJv",
            "dG9zLk5ldHdvcmtpbmcuUmVxdWVzdHMuTWVzc2FnZXMiHgocR2V0U3VnZ2Vz",
            "dGVkQ29kZW5hbWVzTWVzc2FnZWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Requests.Messages.GetSuggestedCodenamesMessage), global::POGOProtos.Networking.Requests.Messages.GetSuggestedCodenamesMessage.Parser, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///  No message needed.
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class GetSuggestedCodenamesMessage : pb::IMessage<GetSuggestedCodenamesMessage> {
    private static readonly pb::MessageParser<GetSuggestedCodenamesMessage> _parser = new pb::MessageParser<GetSuggestedCodenamesMessage>(() => new GetSuggestedCodenamesMessage());
    public static pb::MessageParser<GetSuggestedCodenamesMessage> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Requests.Messages.GetSuggestedCodenamesMessageReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public GetSuggestedCodenamesMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    public GetSuggestedCodenamesMessage(GetSuggestedCodenamesMessage other) : this() {
    }

    public GetSuggestedCodenamesMessage Clone() {
      return new GetSuggestedCodenamesMessage(this);
    }

    public override bool Equals(object other) {
      return Equals(other as GetSuggestedCodenamesMessage);
    }

    public bool Equals(GetSuggestedCodenamesMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
    }

    public int CalculateSize() {
      int size = 0;
      return size;
    }

    public void MergeFrom(GetSuggestedCodenamesMessage other) {
      if (other == null) {
        return;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code