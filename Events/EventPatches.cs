using HarmonyLib;
using Photon.Realtime;
using Photon.Pun;
using System;

namespace HoneyLib.Events
{
    [Obsolete("Due to lack of ability to test, gamemode events have been deprecated", true)]
    // [HarmonyPatch(typeof(GorillaTagManager), "ReportTag")]
    class InfectionTagMaster
    {
        // internal static Events events = new Events();
        // internal static void Postfix(Player taggedPlayer, Player taggingPlayer)
        // {
        //     if (Events.InfectionTagMaster == null)
        //         return;

        //     InfectionTagMasterArgs args = new InfectionTagMasterArgs();
        //     args.taggedPlayer = taggedPlayer;
        //     args.taggingPlayer = taggingPlayer;
        //     events.TriggerInfectionTagMaster(args);
        // }

        // internal static void Prefix(Player taggedPlayer, Player taggingPlayer)
        // {
        //     if (Events.PreInfectionTagMaster == null)
        //         return;

        //     InfectionTagMasterArgs args = new InfectionTagMasterArgs();
        //     args.taggedPlayer = taggedPlayer;
        //     args.taggingPlayer = taggingPlayer;
        //     events.TriggerPreInfectionTagMaster(args);
        // }
    }

    [Obsolete("Due to lack of ability to test, gamemode events have been deprecated", true)]
    // [HarmonyPatch(typeof(GorillaHuntManager), "ReportTag")]
    class HuntTagMaster
    {
        // internal static Events events = new Events();
        // internal static void Postfix(Player taggedPlayer, Player taggingPlayer)
        // {
        //     if (Events.HuntTagMaster == null)
        //         return;

        //     HuntTagMasterArgs args = new HuntTagMasterArgs();
        //     args.taggedPlayer = taggedPlayer;
        //     args.taggingPlayer = taggingPlayer;
        //     events.TriggerHuntTagMaster(args);
        // }

        // internal static void Prefix(Player taggedPlayer, Player taggingPlayer)
        // {
        //     if (Events.PreHuntTagMaster == null)
        //         return;

        //     HuntTagMasterArgs args = new HuntTagMasterArgs();
        //     args.taggedPlayer = taggedPlayer;
        //     args.taggingPlayer = taggingPlayer;
        //     events.TriggerPreHuntTagMaster(args);
        // }
    }

    [Obsolete("Due to lack of ability to test, gamemode events have been deprecated", true)]
    // [HarmonyPatch(typeof(GorillaBattleManager), "ReportSlingshotHit")]
    class BattleHitMaster
    {
        // internal static Events events = new Events();
        // internal static void Postfix(Player taggedPlayer, UnityEngine.Vector3 hitLocation, int projectileCount, PhotonMessageInfo info)
        // {
        //     if (Events.BattleHitMaster == null)
        //         return;

        //     BattleHitMasterArgs args = new BattleHitMasterArgs();
        //     args.taggedPlayer = taggedPlayer;
        //     args.hitLocation = hitLocation;
        //     args.projectileCount = projectileCount;
        //     args.info = info;
        //     events.TriggerBattleHitMaster(args);
        // }

        // internal static void Prefix(Player taggedPlayer, UnityEngine.Vector3 hitLocation, int projectileCount, PhotonMessageInfo info)
        // {
        //     if (Events.PreBattleHitMaster == null)
        //         return;

        //     BattleHitMasterArgs args = new BattleHitMasterArgs();
        //     args.taggedPlayer = taggedPlayer;
        //     args.hitLocation = hitLocation;
        //     args.projectileCount = projectileCount;
        //     args.info = info;
        //     events.TriggerPreBattleHitMaster(args);
        // }
    }

    [Obsolete("Due to lack of ability to test, gamemode events have been deprecated", true)]
    // [HarmonyPatch(typeof(VRRig), "PlayTagSoundLocal")]
    class TagHitUnsafe
    {
        // internal static Events events = new Events();
        // internal static void Postfix(int soundIndex, PhotonMessageInfo info)
        // {
        //     if (soundIndex == 0 || soundIndex == 5)
        //     {
        //         TagHitUnsafeArgs args = new TagHitUnsafeArgs();
        //         args.info = info;
        //         events.TriggerTagHitUnsafe(args);
        //     }
        // }
        // internal static void Prefix(int soundIndex, PhotonMessageInfo info)
        // {
        //     if (soundIndex == 0 || soundIndex == 5)
        //     {
        //         TagHitUnsafeArgs args = new TagHitUnsafeArgs();
        //         args.info = info;
        //         events.TriggerPreTagHitUnsafe(args);
        //     }
        // }
    }

    [Obsolete("Due to lack of ability to test, gamemode events have been deprecated", true)]
    // [HarmonyPatch(typeof(PhotonView), "RPC", new System.Type[] { typeof(string), typeof(RpcTarget), typeof(object[]) })]
    class TagHitLocal
    {
        // internal static Events events = new Events();
        // internal static void Postfix(string methodName, RpcTarget target, params object[] parameters)
        // {
        //     if (methodName == "ReportTagRPC" || methodName == "ReportSlingshotHit")
        //     {
        //         TagHitLocalArgs args = new TagHitLocalArgs();
        //         args.taggedPlayer = (Player)parameters[0];
        //         events.TriggerTagHitLocal(args);
        //     }
        // }
        // internal static void Prefix(string methodName, RpcTarget target, params object[] parameters)
        // {
        //     if (methodName == "ReportTagRPC" || methodName == "ReportSlingshotHit")
        //     {
        //         TagHitLocalArgs args = new TagHitLocalArgs();
        //         args.taggedPlayer = (Player)parameters[0];
        //         events.TriggerPreTagHitLocal(args);
        //     }
        // }
    }
}