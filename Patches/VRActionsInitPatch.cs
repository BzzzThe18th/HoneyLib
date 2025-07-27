using System;
using HarmonyLib;
using Valve.VR;

namespace HoneyLib.Patches
{
    // The SteamVR actions check has been removed for oculus software compatibility
    // [HarmonyPatch(typeof(SteamVR_Actions))]
    // [HarmonyPatch("InitializeActionArrays", MethodType.Normal)]
    // static class VRActionsInitPatch
    // {
    //     public static void Postfix()
    //     {
    //         // Ensuring that actions are initialized before continuing on steam
    //         // Actions are used exclusively for joystick inputs
    //         try
    //         {
    //             HoneyLib.steamVrActionsInit = true;
    //         } catch (Exception e) {
    //             HoneyLib.steamVrActionsInit = false;
    //             UnityEngine.Debug.LogError(e);
    //         }
    //     }
    // }
}