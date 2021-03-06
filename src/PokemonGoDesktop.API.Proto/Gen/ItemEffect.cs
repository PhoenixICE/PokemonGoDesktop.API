// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Enums/ItemEffect.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace PokemonGoDesktop.API.Proto {

  /// <summary>Holder for reflection information generated from Enums/ItemEffect.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class ItemEffectReflection {

    #region Descriptor
    /// <summary>File descriptor for Enums/ItemEffect.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ItemEffectReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZFbnVtcy9JdGVtRWZmZWN0LnByb3RvEgVFbnVtcyqYBAoKSXRlbUVmZmVj",
            "dBIUChBJVEVNX0VGRkVDVF9OT05FEAASHAoXSVRFTV9FRkZFQ1RfQ0FQX05P",
            "X0ZMRUUQ6AcSIAobSVRFTV9FRkZFQ1RfQ0FQX05PX01PVkVNRU5UEOoHEh4K",
            "GUlURU1fRUZGRUNUX0NBUF9OT19USFJFQVQQ6wcSHwoaSVRFTV9FRkZFQ1Rf",
            "Q0FQX1RBUkdFVF9NQVgQ7AcSIAobSVRFTV9FRkZFQ1RfQ0FQX1RBUkdFVF9T",
            "TE9XEO0HEiEKHElURU1fRUZGRUNUX0NBUF9DSEFOQ0VfTklHSFQQ7gcSIwoe",
            "SVRFTV9FRkZFQ1RfQ0FQX0NIQU5DRV9UUkFJTkVSEO8HEicKIklURU1fRUZG",
            "RUNUX0NBUF9DSEFOQ0VfRklSU1RfVEhST1cQ8AcSIgodSVRFTV9FRkZFQ1Rf",
            "Q0FQX0NIQU5DRV9MRUdFTkQQ8QcSIQocSVRFTV9FRkZFQ1RfQ0FQX0NIQU5D",
            "RV9IRUFWWRDyBxIiCh1JVEVNX0VGRkVDVF9DQVBfQ0hBTkNFX1JFUEVBVBDz",
            "BxInCiJJVEVNX0VGRkVDVF9DQVBfQ0hBTkNFX01VTFRJX1RIUk9XEPQHEiIK",
            "HUlURU1fRUZGRUNUX0NBUF9DSEFOQ0VfQUxXQVlTEPUHEigKI0lURU1fRUZG",
            "RUNUX0NBUF9DSEFOQ0VfU0lOR0xFX1RIUk9XEPYHQh2qAhpQb2tlbW9uR29E",
            "ZXNrdG9wLkFQSS5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::PokemonGoDesktop.API.Proto.ItemEffect), }, null));
    }
    #endregion

  }
  #region Enums
  public enum ItemEffect {
    [pbr::OriginalName("ITEM_EFFECT_NONE")] None = 0,
    [pbr::OriginalName("ITEM_EFFECT_CAP_NO_FLEE")] CapNoFlee = 1000,
    [pbr::OriginalName("ITEM_EFFECT_CAP_NO_MOVEMENT")] CapNoMovement = 1002,
    [pbr::OriginalName("ITEM_EFFECT_CAP_NO_THREAT")] CapNoThreat = 1003,
    [pbr::OriginalName("ITEM_EFFECT_CAP_TARGET_MAX")] CapTargetMax = 1004,
    [pbr::OriginalName("ITEM_EFFECT_CAP_TARGET_SLOW")] CapTargetSlow = 1005,
    [pbr::OriginalName("ITEM_EFFECT_CAP_CHANCE_NIGHT")] CapChanceNight = 1006,
    [pbr::OriginalName("ITEM_EFFECT_CAP_CHANCE_TRAINER")] CapChanceTrainer = 1007,
    [pbr::OriginalName("ITEM_EFFECT_CAP_CHANCE_FIRST_THROW")] CapChanceFirstThrow = 1008,
    [pbr::OriginalName("ITEM_EFFECT_CAP_CHANCE_LEGEND")] CapChanceLegend = 1009,
    [pbr::OriginalName("ITEM_EFFECT_CAP_CHANCE_HEAVY")] CapChanceHeavy = 1010,
    [pbr::OriginalName("ITEM_EFFECT_CAP_CHANCE_REPEAT")] CapChanceRepeat = 1011,
    [pbr::OriginalName("ITEM_EFFECT_CAP_CHANCE_MULTI_THROW")] CapChanceMultiThrow = 1012,
    [pbr::OriginalName("ITEM_EFFECT_CAP_CHANCE_ALWAYS")] CapChanceAlways = 1013,
    [pbr::OriginalName("ITEM_EFFECT_CAP_CHANCE_SINGLE_THROW")] CapChanceSingleThrow = 1014,
  }

  #endregion

}

#endregion Designer generated code
