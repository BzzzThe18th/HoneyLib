using HarmonyLib;
using Valve.VR;

namespace HoneyLib.Patches
{
    [HarmonyPatch(typeof(SteamVR_Actions))]
    [HarmonyPatch("InitializeActionArrays", MethodType.Normal)]
    static class VRActionsInitPatch
    {
        public static void Postfix()
        {
            // Ensuring that actions are initialized before continuing on steam
            // Actions are used exclusively for joystick inputs
            HoneyLib.steamVrActionsInit = true;
        }
    }
}