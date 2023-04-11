using UnityEngine;
using HarmonyLib;
using Photon.Realtime;
using Photon.Pun;

namespace HoneyLib.Events
{
    [HarmonyPatch(typeof(GorillaTagManager), nameof(GorillaTagManager.ReportTag))]
    class InfectionTag
    {
        internal static void Postfix(Player taggedPlayer, Player taggingPlayer)
        {
            Events events = new Events();
            InfectionTagArgs args = new InfectionTagArgs();
            args.taggedPlayer = taggedPlayer;
            args.taggingPlayer = taggingPlayer;
            events.TriggerInfectionTag(args);
        }

        internal static void Prefix(Player taggedPlayer, Player taggingPlayer)
        {
            Events events = new Events();
            InfectionTagArgs args = new InfectionTagArgs();
            args.taggedPlayer = taggedPlayer;
            args.taggingPlayer = taggingPlayer;
            events.TriggerPreInfectionTag(args);
        }
    }

    [HarmonyPatch(typeof(GorillaHuntManager), nameof(GorillaHuntManager.ReportTag))]
    class HuntTag
    {
        internal static void Postfix(Player taggedPlayer, Player taggingPlayer)
        {
            Events events = new Events();
            HuntTagArgs args = new HuntTagArgs();
            args.taggedPlayer = taggedPlayer;
            args.taggingPlayer = taggingPlayer;
            events.TriggerHuntTag(args);
        }

        internal static void Prefix(Player taggedPlayer, Player taggingPlayer)
        {
            Events events = new Events();
            HuntTagArgs args = new HuntTagArgs();
            args.taggedPlayer = taggedPlayer;
            args.taggingPlayer = taggingPlayer;
            events.TriggerPreHuntTag(args);
        }
    }

    [HarmonyPatch(typeof(GorillaBattleManager), nameof(GorillaBattleManager.ReportSlingshotHit))]
    class BattleHit
    {
        internal static void Postfix(Player taggedPlayer, Vector3 hitLocation, int projectileCount, PhotonMessageInfo info)
        {
            Events events = new Events();
            BattleHitArgs args = new BattleHitArgs();
            args.taggedPlayer = taggedPlayer;
            args.hitLocation = hitLocation;
            args.projectileCount = projectileCount;
            args.info = info;
            events.TriggerBattleHit(args);
        }

        internal static void Prefix(Player taggedPlayer, Vector3 hitLocation, int projectileCount, PhotonMessageInfo info)
        {
            Events events = new Events();
            BattleHitArgs args = new BattleHitArgs();
            args.taggedPlayer = taggedPlayer;
            args.hitLocation = hitLocation;
            args.projectileCount = projectileCount;
            args.info = info;
            events.TriggerPreBattleHit(args);
        }
    }

    [HarmonyPatch(typeof(GorillaNetworking.PhotonNetworkController), nameof(GorillaNetworking.PhotonNetworkController.OnJoinedRoom))]
    class JoinedRoom
    {
        internal static void Postfix()
        {
            Events events = new Events();
            events.TriggerJoinedRoom();
        }

        internal static void Prefix()
        {
            Events events = new Events();
            events.TriggerPreJoinedRoom();
        }
    }

    [HarmonyPatch(typeof(GorillaNetworking.PhotonNetworkController), nameof(GorillaNetworking.PhotonNetworkController.OnLeftRoom))]
    class LeftRoom
    {
        internal static void Postfix()
        {
            Events events = new Events();
            events.TriggerLeftRoom();
        }

        internal static void Prefix()
        {
            Events events = new Events();
            events.TriggerPreLeftRoom();
        }
    }

    [HarmonyPatch(typeof(GorillaGameManager), nameof(GorillaGameManager.OnPlayerPropertiesUpdate))]
    class PropetiesUpdate
    {
        internal static void Postfix()
        {
            Events events = new Events();
            events.TriggerPropertiesUpdate();
        }

        internal static void Prefix()
        {
            Events events = new Events();
            events.TriggerPrePropertiesUpdate();
        }
    }
}
