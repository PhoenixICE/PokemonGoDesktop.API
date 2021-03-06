// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Inventory/ItemAward.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace PokemonGoDesktop.API.Proto {

  /// <summary>Holder for reflection information generated from Inventory/ItemAward.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class ItemAwardReflection {

    #region Descriptor
    /// <summary>File descriptor for Inventory/ItemAward.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ItemAwardReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlJbnZlbnRvcnkvSXRlbUF3YXJkLnByb3RvEglJbnZlbnRvcnkaFkludmVu",
            "dG9yeS9JdGVtSWQucHJvdG8iQwoJSXRlbUF3YXJkEiIKB2l0ZW1faWQYASAB",
            "KA4yES5JbnZlbnRvcnkuSXRlbUlkEhIKCml0ZW1fY291bnQYAiABKAVCHaoC",
            "GlBva2Vtb25Hb0Rlc2t0b3AuQVBJLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::PokemonGoDesktop.API.Proto.ItemIdReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::PokemonGoDesktop.API.Proto.ItemAward), global::PokemonGoDesktop.API.Proto.ItemAward.Parser, new[]{ "ItemId", "ItemCount" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class ItemAward : pb::IMessage<ItemAward> {
    private static readonly pb::MessageParser<ItemAward> _parser = new pb::MessageParser<ItemAward>(() => new ItemAward());
    public static pb::MessageParser<ItemAward> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::PokemonGoDesktop.API.Proto.ItemAwardReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public ItemAward() {
      OnConstruction();
    }

    partial void OnConstruction();

    public ItemAward(ItemAward other) : this() {
      itemId_ = other.itemId_;
      itemCount_ = other.itemCount_;
    }

    public ItemAward Clone() {
      return new ItemAward(this);
    }

    /// <summary>Field number for the "item_id" field.</summary>
    public const int ItemIdFieldNumber = 1;
    private global::PokemonGoDesktop.API.Proto.ItemId itemId_ = 0;
    public global::PokemonGoDesktop.API.Proto.ItemId ItemId {
      get { return itemId_; }
      set {
        itemId_ = value;
      }
    }

    /// <summary>Field number for the "item_count" field.</summary>
    public const int ItemCountFieldNumber = 2;
    private int itemCount_;
    public int ItemCount {
      get { return itemCount_; }
      set {
        itemCount_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as ItemAward);
    }

    public bool Equals(ItemAward other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ItemId != other.ItemId) return false;
      if (ItemCount != other.ItemCount) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (ItemId != 0) hash ^= ItemId.GetHashCode();
      if (ItemCount != 0) hash ^= ItemCount.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (ItemId != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) ItemId);
      }
      if (ItemCount != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(ItemCount);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (ItemId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ItemId);
      }
      if (ItemCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ItemCount);
      }
      return size;
    }

    public void MergeFrom(ItemAward other) {
      if (other == null) {
        return;
      }
      if (other.ItemId != 0) {
        ItemId = other.ItemId;
      }
      if (other.ItemCount != 0) {
        ItemCount = other.ItemCount;
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
            itemId_ = (global::PokemonGoDesktop.API.Proto.ItemId) input.ReadEnum();
            break;
          }
          case 16: {
            ItemCount = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
