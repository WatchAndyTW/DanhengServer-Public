// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessRogueFinishType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChessRogueFinishType.proto</summary>
  public static partial class ChessRogueFinishTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessRogueFinishType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessRogueFinishTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpDaGVzc1JvZ3VlRmluaXNoVHlwZS5wcm90byr1AQoUQ2hlc3NSb2d1ZUZp",
            "bmlzaFR5cGUSHwobQ0hFU1NfUk9HVUVfQUNDT1VOVF9CWV9OT05FEAASKAok",
            "Q0hFU1NfUk9HVUVfQUNDT1VOVF9CWV9OT1JNQUxfRklOSVNIEAESJgoiQ0hF",
            "U1NfUk9HVUVfQUNDT1VOVF9CWV9OT1JNQUxfUVVJVBACEiEKHUNIRVNTX1JP",
            "R1VFX0FDQ09VTlRfQllfRElBTE9HEAMSIQodQ0hFU1NfUk9HVUVfQUNDT1VO",
            "VF9CWV9GQUlMRUQQBBIkCiBDSEVTU19ST0dVRV9BQ0NPVU5UX0JZX0NVU1RP",
            "TV9PUBAFQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::EggLink.DanhengServer.Proto.ChessRogueFinishType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum ChessRogueFinishType {
    [pbr::OriginalName("CHESS_ROGUE_ACCOUNT_BY_NONE")] ChessRogueAccountByNone = 0,
    [pbr::OriginalName("CHESS_ROGUE_ACCOUNT_BY_NORMAL_FINISH")] ChessRogueAccountByNormalFinish = 1,
    [pbr::OriginalName("CHESS_ROGUE_ACCOUNT_BY_NORMAL_QUIT")] ChessRogueAccountByNormalQuit = 2,
    [pbr::OriginalName("CHESS_ROGUE_ACCOUNT_BY_DIALOG")] ChessRogueAccountByDialog = 3,
    [pbr::OriginalName("CHESS_ROGUE_ACCOUNT_BY_FAILED")] ChessRogueAccountByFailed = 4,
    [pbr::OriginalName("CHESS_ROGUE_ACCOUNT_BY_CUSTOM_OP")] ChessRogueAccountByCustomOp = 5,
  }

  #endregion

}

#endregion Designer generated code
