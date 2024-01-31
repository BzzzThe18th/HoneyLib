using HarmonyLib;

namespace HoneyLib.Patches
{
    
    [System.Obsolete("Due to lack of ability to test, gamemode events have been deprecated", true)]
    // [HarmonyPatch(typeof(GorillaGameManager))]
    // [HarmonyPatch("InfrequentUpdate", MethodType.Normal)]
    class GameManagerPatch
    {
        // public static GorillaBattleManager battleManager;
        // public static GorillaHuntManager huntManager;
        // public static GorillaTagManager tagManager;

        // static void Postfix(GorillaGameManager __instance)
        // {
        //     if (__instance is GorillaBattleManager bm) battleManager = bm;
        //     if (__instance is GorillaHuntManager hm) huntManager = hm;
        //     if (__instance is GorillaTagManager tm) tagManager = tm;
        // }
    }
}
