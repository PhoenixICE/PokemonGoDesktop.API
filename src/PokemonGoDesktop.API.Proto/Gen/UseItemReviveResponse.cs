// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Networking/Responses/UseItemReviveResponse.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace PokemonGoDesktop.API.Proto {

  /// <summary>Holder for reflection information generated from Networking/Responses/UseItemReviveResponse.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class UseItemReviveResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for Networking/Responses/UseItemReviveResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UseItemReviveResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjBOZXR3b3JraW5nL1Jlc3BvbnNlcy9Vc2VJdGVtUmV2aXZlUmVzcG9uc2Uu",
            "cHJvdG8SFE5ldHdvcmtpbmcuUmVzcG9uc2VzItYBChVVc2VJdGVtUmV2aXZl",
            "UmVzcG9uc2USQgoGcmVzdWx0GAEgASgOMjIuTmV0d29ya2luZy5SZXNwb25z",
            "ZXMuVXNlSXRlbVJldml2ZVJlc3BvbnNlLlJlc3VsdBIPCgdzdGFtaW5hGAIg",
            "ASgFImgKBlJlc3VsdBIJCgVVTlNFVBAAEgsKB1NVQ0NFU1MQARIUChBFUlJP",
            "Ul9OT19QT0tFTU9OEAISFAoQRVJST1JfQ0FOTk9UX1VTRRADEhoKFkVSUk9S",
            "X0RFUExPWUVEX1RPX0ZPUlQQBEIdqgIaUG9rZW1vbkdvRGVza3RvcC5BUEku",
            "UHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::PokemonGoDesktop.API.Proto.UseItemReviveResponse), global::PokemonGoDesktop.API.Proto.UseItemReviveResponse.Parser, new[]{ "Result", "Stamina" }, null, new[]{ typeof(global::PokemonGoDesktop.API.Proto.UseItemReviveResponse.Types.Result) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class UseItemReviveResponse : pb::IMessage<UseItemReviveResponse> {
    private static readonly pb::MessageParser<UseItemReviveResponse> _parser = new pb::MessageParser<UseItemReviveResponse>(() => new UseItemReviveResponse());
    public static pb::MessageParser<UseItemReviveResponse> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::PokemonGoDesktop.API.Proto.UseItemReviveResponseReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public UseItemReviveResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    public UseItemReviveResponse(UseItemReviveResponse other) : this() {
      result_ = other.result_;
      stamina_ = other.stamina_;
    }

    public UseItemReviveResponse Clone() {
      return new UseItemReviveResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::PokemonGoDesktop.API.Proto.UseItemReviveResponse.Types.Result result_ = 0;
    public global::PokemonGoDesktop.API.Proto.UseItemReviveResponse.Types.Result Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "stamina" field.</summary>
    public const int StaminaFieldNumber = 2;
    private int stamina_;
    public int Stamina {
      get { return stamina_; }
      set {
        stamina_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as UseItemReviveResponse);
    }

    public bool Equals(UseItemReviveResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if (Stamina != other.Stamina) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      if (Stamina != 0) hash ^= Stamina.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Result != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Result);
      }
      if (Stamina != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Stamina);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      if (Stamina != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Stamina);
      }
      return size;
    }

    public void MergeFrom(UseItemReviveResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      if (other.Stamina != 0) {
        Stamina = other.Stamina;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            result_ = (global::PokemonGoDesktop.API.Proto.UseItemReviveResponse.Types.Result) input.ReadEnum();
            break;
          }
          case 16: {
            Stamina = input.ReadInt32();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the UseItemReviveResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class Types {
      public enum Result {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
        [pbr::OriginalName("ERROR_NO_POKEMON")] ErrorNoPokemon = 2,
        [pbr::OriginalName("ERROR_CANNOT_USE")] ErrorCannotUse = 3,
        [pbr::OriginalName("ERROR_DEPLOYED_TO_FORT")] ErrorDeployedToFort = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
