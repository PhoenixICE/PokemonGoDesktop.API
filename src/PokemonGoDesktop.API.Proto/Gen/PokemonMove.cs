// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Enums/PokemonMove.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Enums {

  /// <summary>Holder for reflection information generated from Enums/PokemonMove.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class PokemonMoveReflection {

    #region Descriptor
    /// <summary>File descriptor for Enums/PokemonMove.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PokemonMoveReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdFbnVtcy9Qb2tlbW9uTW92ZS5wcm90bxIFRW51bXMqzhcKC1Bva2Vtb25N",
            "b3ZlEg4KCk1PVkVfVU5TRVQQABIRCg1USFVOREVSX1NIT0NLEAESEAoMUVVJ",
            "Q0tfQVRUQUNLEAISCwoHU0NSQVRDSBADEgkKBUVNQkVSEAQSDQoJVklORV9X",
            "SElQEAUSCgoGVEFDS0xFEAYSDgoKUkFaT1JfTEVBRhAHEg0KCVRBS0VfRE9X",
            "ThAIEg0KCVdBVEVSX0dVThAJEggKBEJJVEUQChIJCgVQT1VORBALEg8KC0RP",
            "VUJMRV9TTEFQEAwSCAoEV1JBUBANEg4KCkhZUEVSX0JFQU0QDhIICgRMSUNL",
            "EA8SDgoKREFSS19QVUxTRRAQEggKBFNNT0cQERIKCgZTTFVER0UQEhIOCgpN",
            "RVRBTF9DTEFXEBMSDQoJVklDRV9HUklQEBQSDwoLRkxBTUVfV0hFRUwQFRIM",
            "CghNRUdBSE9SThAWEg8KC1dJTkdfQVRUQUNLEBcSEAoMRkxBTUVUSFJPV0VS",
            "EBgSEAoMU1VDS0VSX1BVTkNIEBkSBwoDRElHEBoSDAoITE9XX0tJQ0sQGxIO",
            "CgpDUk9TU19DSE9QEBwSDgoKUFNZQ0hPX0NVVBAdEgsKB1BTWUJFQU0QHhIO",
            "CgpFQVJUSFFVQUtFEB8SDgoKU1RPTkVfRURHRRAgEg0KCUlDRV9QVU5DSBAh",
            "Eg8KC0hFQVJUX1NUQU1QECISDQoJRElTQ0hBUkdFECMSEAoMRkxBU0hfQ0FO",
            "Tk9OECQSCAoEUEVDSxAlEg4KCkRSSUxMX1BFQ0sQJhIMCghJQ0VfQkVBTRAn",
            "EgwKCEJMSVpaQVJEECgSDQoJQUlSX1NMQVNIECkSDQoJSEVBVF9XQVZFECoS",
            "DQoJVFdJTkVFRExFECsSDgoKUE9JU09OX0pBQhAsEg4KCkFFUklBTF9BQ0UQ",
            "LRINCglEUklMTF9SVU4QLhISCg5QRVRBTF9CTElaWkFSRBAvEg4KCk1FR0Ff",
            "RFJBSU4QMBIMCghCVUdfQlVaWhAxEg8KC1BPSVNPTl9GQU5HEDISDwoLTklH",
            "SFRfU0xBU0gQMxIJCgVTTEFTSBA0Eg8KC0JVQkJMRV9CRUFNEDUSDgoKU1VC",
            "TUlTU0lPThA2Eg8KC0tBUkFURV9DSE9QEDcSDQoJTE9XX1NXRUVQEDgSDAoI",
            "QVFVQV9KRVQQORINCglBUVVBX1RBSUwQOhINCglTRUVEX0JPTUIQOxIMCghQ",
            "U1lTSE9DSxA8Eg4KClJPQ0tfVEhST1cQPRIRCg1BTkNJRU5UX1BPV0VSED4S",
            "DQoJUk9DS19UT01CED8SDgoKUk9DS19TTElERRBAEg0KCVBPV0VSX0dFTRBB",
            "EhAKDFNIQURPV19TTkVBSxBCEhAKDFNIQURPV19QVU5DSBBDEg8KC1NIQURP",
            "V19DTEFXEEQSEAoMT01JTk9VU19XSU5EEEUSDwoLU0hBRE9XX0JBTEwQRhIQ",
            "CgxCVUxMRVRfUFVOQ0gQRxIPCgtNQUdORVRfQk9NQhBIEg4KClNURUVMX1dJ",
            "TkcQSRINCglJUk9OX0hFQUQQShIUChBQQVJBQk9MSUNfQ0hBUkdFEEsSCQoF",
            "U1BBUksQTBIRCg1USFVOREVSX1BVTkNIEE0SCwoHVEhVTkRFUhBOEg8KC1RI",
            "VU5ERVJCT0xUEE8SCwoHVFdJU1RFUhBQEhEKDURSQUdPTl9CUkVBVEgQURIQ",
            "CgxEUkFHT05fUFVMU0UQUhIPCgtEUkFHT05fQ0xBVxBTEhMKD0RJU0FSTUlO",
            "R19WT0lDRRBUEhEKDURSQUlOSU5HX0tJU1MQVRISCg5EQVpaTElOR19HTEVB",
            "TRBWEg0KCU1PT05CTEFTVBBXEg4KClBMQVlfUk9VR0gQWBIQCgxDUk9TU19Q",
            "T0lTT04QWRIPCgtTTFVER0VfQk9NQhBaEg8KC1NMVURHRV9XQVZFEFsSDQoJ",
            "R1VOS19TSE9UEFwSDAoITVVEX1NIT1QQXRINCglCT05FX0NMVUIQXhIMCghC",
            "VUxMRE9aRRBfEgwKCE1VRF9CT01CEGASDwoLRlVSWV9DVVRURVIQYRIMCghC",
            "VUdfQklURRBiEg8KC1NJR05BTF9CRUFNEGMSDQoJWF9TQ0lTU09SEGQSEAoM",
            "RkxBTUVfQ0hBUkdFEGUSDwoLRkxBTUVfQlVSU1QQZhIOCgpGSVJFX0JMQVNU",
            "EGcSCQoFQlJJTkUQaBIPCgtXQVRFUl9QVUxTRRBpEgkKBVNDQUxEEGoSDgoK",
            "SFlEUk9fUFVNUBBrEgsKB1BTWUNISUMQbBINCglQU1lTVFJJS0UQbRINCglJ",
            "Q0VfU0hBUkQQbhIMCghJQ1lfV0lORBBvEhAKDEZST1NUX0JSRUFUSBBwEgoK",
            "BkFCU09SQhBxEg4KCkdJR0FfRFJBSU4QchIOCgpGSVJFX1BVTkNIEHMSDgoK",
            "U09MQVJfQkVBTRB0Eg4KCkxFQUZfQkxBREUQdRIOCgpQT1dFUl9XSElQEHYS",
            "CgoGU1BMQVNIEHcSCAoEQUNJRBB4Eg4KCkFJUl9DVVRURVIQeRINCglIVVJS",
            "SUNBTkUQehIPCgtCUklDS19CUkVBSxB7EgcKA0NVVBB8EgkKBVNXSUZUEH0S",
            "DwoLSE9STl9BVFRBQ0sQfhIJCgVTVE9NUBB/Eg0KCEhFQURCVVRUEIABEg8K",
            "CkhZUEVSX0ZBTkcQgQESCQoEU0xBTRCCARIOCglCT0RZX1NMQU0QgwESCQoE",
            "UkVTVBCEARINCghTVFJVR0dMRRCFARIUCg9TQ0FMRF9CTEFTVE9JU0UQhgES",
            "GQoUSFlEUk9fUFVNUF9CTEFTVE9JU0UQhwESDwoKV1JBUF9HUkVFThCIARIO",
            "CglXUkFQX1BJTksQiQESFQoQRlVSWV9DVVRURVJfRkFTVBDIARISCg1CVUdf",
            "QklURV9GQVNUEMkBEg4KCUJJVEVfRkFTVBDKARIWChFTVUNLRVJfUFVOQ0hf",
            "RkFTVBDLARIXChJEUkFHT05fQlJFQVRIX0ZBU1QQzAESFwoSVEhVTkRFUl9T",
            "SE9DS19GQVNUEM0BEg8KClNQQVJLX0ZBU1QQzgESEgoNTE9XX0tJQ0tfRkFT",
            "VBDPARIVChBLQVJBVEVfQ0hPUF9GQVNUENABEg8KCkVNQkVSX0ZBU1QQ0QES",
            "FQoQV0lOR19BVFRBQ0tfRkFTVBDSARIOCglQRUNLX0ZBU1QQ0wESDgoJTElD",
            "S19GQVNUENQBEhUKEFNIQURPV19DTEFXX0ZBU1QQ1QESEwoOVklORV9XSElQ",
            "X0ZBU1QQ1gESFAoPUkFaT1JfTEVBRl9GQVNUENcBEhIKDU1VRF9TSE9UX0ZB",
            "U1QQ2AESEwoOSUNFX1NIQVJEX0ZBU1QQ2QESFgoRRlJPU1RfQlJFQVRIX0ZB",
            "U1QQ2gESFgoRUVVJQ0tfQVRUQUNLX0ZBU1QQ2wESEQoMU0NSQVRDSF9GQVNU",
            "ENwBEhAKC1RBQ0tMRV9GQVNUEN0BEg8KClBPVU5EX0ZBU1QQ3gESDQoIQ1VU",
            "X0ZBU1QQ3wESFAoPUE9JU09OX0pBQl9GQVNUEOABEg4KCUFDSURfRkFTVBDh",
            "ARIUCg9QU1lDSE9fQ1VUX0ZBU1QQ4gESFAoPUk9DS19USFJPV19GQVNUEOMB",
            "EhQKD01FVEFMX0NMQVdfRkFTVBDkARIWChFCVUxMRVRfUFVOQ0hfRkFTVBDl",
            "ARITCg5XQVRFUl9HVU5fRkFTVBDmARIQCgtTUExBU0hfRkFTVBDnARIdChhX",
            "QVRFUl9HVU5fRkFTVF9CTEFTVE9JU0UQ6AESEgoNTVVEX1NMQVBfRkFTVBDp",
            "ARIWChFaRU5fSEVBREJVVFRfRkFTVBDqARITCg5DT05GVVNJT05fRkFTVBDr",
            "ARIWChFQT0lTT05fU1RJTkdfRkFTVBDsARIQCgtCVUJCTEVfRkFTVBDtARIW",
            "ChFGRUlOVF9BVFRBQ0tfRkFTVBDuARIUCg9TVEVFTF9XSU5HX0ZBU1QQ7wES",
            "EwoORklSRV9GQU5HX0ZBU1QQ8AESFAoPUk9DS19TTUFTSF9GQVNUEPEBYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Enums.PokemonMove), }, null));
    }
    #endregion

  }
  #region Enums
  public enum PokemonMove {
    [pbr::OriginalName("MOVE_UNSET")] MoveUnset = 0,
    [pbr::OriginalName("THUNDER_SHOCK")] ThunderShock = 1,
    [pbr::OriginalName("QUICK_ATTACK")] QuickAttack = 2,
    [pbr::OriginalName("SCRATCH")] Scratch = 3,
    [pbr::OriginalName("EMBER")] Ember = 4,
    [pbr::OriginalName("VINE_WHIP")] VineWhip = 5,
    [pbr::OriginalName("TACKLE")] Tackle = 6,
    [pbr::OriginalName("RAZOR_LEAF")] RazorLeaf = 7,
    [pbr::OriginalName("TAKE_DOWN")] TakeDown = 8,
    [pbr::OriginalName("WATER_GUN")] WaterGun = 9,
    [pbr::OriginalName("BITE")] Bite = 10,
    [pbr::OriginalName("POUND")] Pound = 11,
    [pbr::OriginalName("DOUBLE_SLAP")] DoubleSlap = 12,
    [pbr::OriginalName("WRAP")] Wrap = 13,
    [pbr::OriginalName("HYPER_BEAM")] HyperBeam = 14,
    [pbr::OriginalName("LICK")] Lick = 15,
    [pbr::OriginalName("DARK_PULSE")] DarkPulse = 16,
    [pbr::OriginalName("SMOG")] Smog = 17,
    [pbr::OriginalName("SLUDGE")] Sludge = 18,
    [pbr::OriginalName("METAL_CLAW")] MetalClaw = 19,
    [pbr::OriginalName("VICE_GRIP")] ViceGrip = 20,
    [pbr::OriginalName("FLAME_WHEEL")] FlameWheel = 21,
    [pbr::OriginalName("MEGAHORN")] Megahorn = 22,
    [pbr::OriginalName("WING_ATTACK")] WingAttack = 23,
    [pbr::OriginalName("FLAMETHROWER")] Flamethrower = 24,
    [pbr::OriginalName("SUCKER_PUNCH")] SuckerPunch = 25,
    [pbr::OriginalName("DIG")] Dig = 26,
    [pbr::OriginalName("LOW_KICK")] LowKick = 27,
    [pbr::OriginalName("CROSS_CHOP")] CrossChop = 28,
    [pbr::OriginalName("PSYCHO_CUT")] PsychoCut = 29,
    [pbr::OriginalName("PSYBEAM")] Psybeam = 30,
    [pbr::OriginalName("EARTHQUAKE")] Earthquake = 31,
    [pbr::OriginalName("STONE_EDGE")] StoneEdge = 32,
    [pbr::OriginalName("ICE_PUNCH")] IcePunch = 33,
    [pbr::OriginalName("HEART_STAMP")] HeartStamp = 34,
    [pbr::OriginalName("DISCHARGE")] Discharge = 35,
    [pbr::OriginalName("FLASH_CANNON")] FlashCannon = 36,
    [pbr::OriginalName("PECK")] Peck = 37,
    [pbr::OriginalName("DRILL_PECK")] DrillPeck = 38,
    [pbr::OriginalName("ICE_BEAM")] IceBeam = 39,
    [pbr::OriginalName("BLIZZARD")] Blizzard = 40,
    [pbr::OriginalName("AIR_SLASH")] AirSlash = 41,
    [pbr::OriginalName("HEAT_WAVE")] HeatWave = 42,
    [pbr::OriginalName("TWINEEDLE")] Twineedle = 43,
    [pbr::OriginalName("POISON_JAB")] PoisonJab = 44,
    [pbr::OriginalName("AERIAL_ACE")] AerialAce = 45,
    [pbr::OriginalName("DRILL_RUN")] DrillRun = 46,
    [pbr::OriginalName("PETAL_BLIZZARD")] PetalBlizzard = 47,
    [pbr::OriginalName("MEGA_DRAIN")] MegaDrain = 48,
    [pbr::OriginalName("BUG_BUZZ")] BugBuzz = 49,
    [pbr::OriginalName("POISON_FANG")] PoisonFang = 50,
    [pbr::OriginalName("NIGHT_SLASH")] NightSlash = 51,
    [pbr::OriginalName("SLASH")] Slash = 52,
    [pbr::OriginalName("BUBBLE_BEAM")] BubbleBeam = 53,
    [pbr::OriginalName("SUBMISSION")] Submission = 54,
    [pbr::OriginalName("KARATE_CHOP")] KarateChop = 55,
    [pbr::OriginalName("LOW_SWEEP")] LowSweep = 56,
    [pbr::OriginalName("AQUA_JET")] AquaJet = 57,
    [pbr::OriginalName("AQUA_TAIL")] AquaTail = 58,
    [pbr::OriginalName("SEED_BOMB")] SeedBomb = 59,
    [pbr::OriginalName("PSYSHOCK")] Psyshock = 60,
    [pbr::OriginalName("ROCK_THROW")] RockThrow = 61,
    [pbr::OriginalName("ANCIENT_POWER")] AncientPower = 62,
    [pbr::OriginalName("ROCK_TOMB")] RockTomb = 63,
    [pbr::OriginalName("ROCK_SLIDE")] RockSlide = 64,
    [pbr::OriginalName("POWER_GEM")] PowerGem = 65,
    [pbr::OriginalName("SHADOW_SNEAK")] ShadowSneak = 66,
    [pbr::OriginalName("SHADOW_PUNCH")] ShadowPunch = 67,
    [pbr::OriginalName("SHADOW_CLAW")] ShadowClaw = 68,
    [pbr::OriginalName("OMINOUS_WIND")] OminousWind = 69,
    [pbr::OriginalName("SHADOW_BALL")] ShadowBall = 70,
    [pbr::OriginalName("BULLET_PUNCH")] BulletPunch = 71,
    [pbr::OriginalName("MAGNET_BOMB")] MagnetBomb = 72,
    [pbr::OriginalName("STEEL_WING")] SteelWing = 73,
    [pbr::OriginalName("IRON_HEAD")] IronHead = 74,
    [pbr::OriginalName("PARABOLIC_CHARGE")] ParabolicCharge = 75,
    [pbr::OriginalName("SPARK")] Spark = 76,
    [pbr::OriginalName("THUNDER_PUNCH")] ThunderPunch = 77,
    [pbr::OriginalName("THUNDER")] Thunder = 78,
    [pbr::OriginalName("THUNDERBOLT")] Thunderbolt = 79,
    [pbr::OriginalName("TWISTER")] Twister = 80,
    [pbr::OriginalName("DRAGON_BREATH")] DragonBreath = 81,
    [pbr::OriginalName("DRAGON_PULSE")] DragonPulse = 82,
    [pbr::OriginalName("DRAGON_CLAW")] DragonClaw = 83,
    [pbr::OriginalName("DISARMING_VOICE")] DisarmingVoice = 84,
    [pbr::OriginalName("DRAINING_KISS")] DrainingKiss = 85,
    [pbr::OriginalName("DAZZLING_GLEAM")] DazzlingGleam = 86,
    [pbr::OriginalName("MOONBLAST")] Moonblast = 87,
    [pbr::OriginalName("PLAY_ROUGH")] PlayRough = 88,
    [pbr::OriginalName("CROSS_POISON")] CrossPoison = 89,
    [pbr::OriginalName("SLUDGE_BOMB")] SludgeBomb = 90,
    [pbr::OriginalName("SLUDGE_WAVE")] SludgeWave = 91,
    [pbr::OriginalName("GUNK_SHOT")] GunkShot = 92,
    [pbr::OriginalName("MUD_SHOT")] MudShot = 93,
    [pbr::OriginalName("BONE_CLUB")] BoneClub = 94,
    [pbr::OriginalName("BULLDOZE")] Bulldoze = 95,
    [pbr::OriginalName("MUD_BOMB")] MudBomb = 96,
    [pbr::OriginalName("FURY_CUTTER")] FuryCutter = 97,
    [pbr::OriginalName("BUG_BITE")] BugBite = 98,
    [pbr::OriginalName("SIGNAL_BEAM")] SignalBeam = 99,
    [pbr::OriginalName("X_SCISSOR")] XScissor = 100,
    [pbr::OriginalName("FLAME_CHARGE")] FlameCharge = 101,
    [pbr::OriginalName("FLAME_BURST")] FlameBurst = 102,
    [pbr::OriginalName("FIRE_BLAST")] FireBlast = 103,
    [pbr::OriginalName("BRINE")] Brine = 104,
    [pbr::OriginalName("WATER_PULSE")] WaterPulse = 105,
    [pbr::OriginalName("SCALD")] Scald = 106,
    [pbr::OriginalName("HYDRO_PUMP")] HydroPump = 107,
    [pbr::OriginalName("PSYCHIC")] Psychic = 108,
    [pbr::OriginalName("PSYSTRIKE")] Psystrike = 109,
    [pbr::OriginalName("ICE_SHARD")] IceShard = 110,
    [pbr::OriginalName("ICY_WIND")] IcyWind = 111,
    [pbr::OriginalName("FROST_BREATH")] FrostBreath = 112,
    [pbr::OriginalName("ABSORB")] Absorb = 113,
    [pbr::OriginalName("GIGA_DRAIN")] GigaDrain = 114,
    [pbr::OriginalName("FIRE_PUNCH")] FirePunch = 115,
    [pbr::OriginalName("SOLAR_BEAM")] SolarBeam = 116,
    [pbr::OriginalName("LEAF_BLADE")] LeafBlade = 117,
    [pbr::OriginalName("POWER_WHIP")] PowerWhip = 118,
    [pbr::OriginalName("SPLASH")] Splash = 119,
    [pbr::OriginalName("ACID")] Acid = 120,
    [pbr::OriginalName("AIR_CUTTER")] AirCutter = 121,
    [pbr::OriginalName("HURRICANE")] Hurricane = 122,
    [pbr::OriginalName("BRICK_BREAK")] BrickBreak = 123,
    [pbr::OriginalName("CUT")] Cut = 124,
    [pbr::OriginalName("SWIFT")] Swift = 125,
    [pbr::OriginalName("HORN_ATTACK")] HornAttack = 126,
    [pbr::OriginalName("STOMP")] Stomp = 127,
    [pbr::OriginalName("HEADBUTT")] Headbutt = 128,
    [pbr::OriginalName("HYPER_FANG")] HyperFang = 129,
    [pbr::OriginalName("SLAM")] Slam = 130,
    [pbr::OriginalName("BODY_SLAM")] BodySlam = 131,
    [pbr::OriginalName("REST")] Rest = 132,
    [pbr::OriginalName("STRUGGLE")] Struggle = 133,
    [pbr::OriginalName("SCALD_BLASTOISE")] ScaldBlastoise = 134,
    [pbr::OriginalName("HYDRO_PUMP_BLASTOISE")] HydroPumpBlastoise = 135,
    [pbr::OriginalName("WRAP_GREEN")] WrapGreen = 136,
    [pbr::OriginalName("WRAP_PINK")] WrapPink = 137,
    [pbr::OriginalName("FURY_CUTTER_FAST")] FuryCutterFast = 200,
    [pbr::OriginalName("BUG_BITE_FAST")] BugBiteFast = 201,
    [pbr::OriginalName("BITE_FAST")] BiteFast = 202,
    [pbr::OriginalName("SUCKER_PUNCH_FAST")] SuckerPunchFast = 203,
    [pbr::OriginalName("DRAGON_BREATH_FAST")] DragonBreathFast = 204,
    [pbr::OriginalName("THUNDER_SHOCK_FAST")] ThunderShockFast = 205,
    [pbr::OriginalName("SPARK_FAST")] SparkFast = 206,
    [pbr::OriginalName("LOW_KICK_FAST")] LowKickFast = 207,
    [pbr::OriginalName("KARATE_CHOP_FAST")] KarateChopFast = 208,
    [pbr::OriginalName("EMBER_FAST")] EmberFast = 209,
    [pbr::OriginalName("WING_ATTACK_FAST")] WingAttackFast = 210,
    [pbr::OriginalName("PECK_FAST")] PeckFast = 211,
    [pbr::OriginalName("LICK_FAST")] LickFast = 212,
    [pbr::OriginalName("SHADOW_CLAW_FAST")] ShadowClawFast = 213,
    [pbr::OriginalName("VINE_WHIP_FAST")] VineWhipFast = 214,
    [pbr::OriginalName("RAZOR_LEAF_FAST")] RazorLeafFast = 215,
    [pbr::OriginalName("MUD_SHOT_FAST")] MudShotFast = 216,
    [pbr::OriginalName("ICE_SHARD_FAST")] IceShardFast = 217,
    [pbr::OriginalName("FROST_BREATH_FAST")] FrostBreathFast = 218,
    [pbr::OriginalName("QUICK_ATTACK_FAST")] QuickAttackFast = 219,
    [pbr::OriginalName("SCRATCH_FAST")] ScratchFast = 220,
    [pbr::OriginalName("TACKLE_FAST")] TackleFast = 221,
    [pbr::OriginalName("POUND_FAST")] PoundFast = 222,
    [pbr::OriginalName("CUT_FAST")] CutFast = 223,
    [pbr::OriginalName("POISON_JAB_FAST")] PoisonJabFast = 224,
    [pbr::OriginalName("ACID_FAST")] AcidFast = 225,
    [pbr::OriginalName("PSYCHO_CUT_FAST")] PsychoCutFast = 226,
    [pbr::OriginalName("ROCK_THROW_FAST")] RockThrowFast = 227,
    [pbr::OriginalName("METAL_CLAW_FAST")] MetalClawFast = 228,
    [pbr::OriginalName("BULLET_PUNCH_FAST")] BulletPunchFast = 229,
    [pbr::OriginalName("WATER_GUN_FAST")] WaterGunFast = 230,
    [pbr::OriginalName("SPLASH_FAST")] SplashFast = 231,
    [pbr::OriginalName("WATER_GUN_FAST_BLASTOISE")] WaterGunFastBlastoise = 232,
    [pbr::OriginalName("MUD_SLAP_FAST")] MudSlapFast = 233,
    [pbr::OriginalName("ZEN_HEADBUTT_FAST")] ZenHeadbuttFast = 234,
    [pbr::OriginalName("CONFUSION_FAST")] ConfusionFast = 235,
    [pbr::OriginalName("POISON_STING_FAST")] PoisonStingFast = 236,
    [pbr::OriginalName("BUBBLE_FAST")] BubbleFast = 237,
    [pbr::OriginalName("FEINT_ATTACK_FAST")] FeintAttackFast = 238,
    [pbr::OriginalName("STEEL_WING_FAST")] SteelWingFast = 239,
    [pbr::OriginalName("FIRE_FANG_FAST")] FireFangFast = 240,
    [pbr::OriginalName("ROCK_SMASH_FAST")] RockSmashFast = 241,
  }

  #endregion

}

#endregion Designer generated code