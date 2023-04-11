using HarmonyLib;

namespace HoneyLib.Patches
{
    [HarmonyPatch(typeof(GorillaGameManager))]
    [HarmonyPatch("Update", MethodType.Normal)]
    class GameManagerPatch
    {
        public static GorillaBattleManager battleManager;
        public static GorillaHuntManager huntManager;
        public static GorillaTagManager tagManager;

        static void Postfix(GorillaGameManager __instance)
        {
            if (__instance is GorillaBattleManager bm) battleManager = bm;
            if (__instance is GorillaHuntManager hm) huntManager = hm;
            if (__instance is GorillaTagManager tm) tagManager = tm;
        }
    }
}
