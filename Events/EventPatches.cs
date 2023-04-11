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
    }
}
