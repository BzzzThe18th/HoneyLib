using HarmonyLib;
using GorillaNetworking;

namespace HoneyLib.Patches
{
    [HarmonyPatch(typeof(PlayFabAuthenticator))]
    [HarmonyPatch("Awake", MethodType.Normal)]
    static class PlayfabAuthAwakePatch
    {
        public static void Postfix(PlayFabAuthenticator __instance)
        {
            // Assign platform tag on authenticator init to avoid race conditions from the old awake delay code
            HoneyLib.platform = __instance.platform.PlatformTag;
        }
    }
}