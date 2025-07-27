using BepInEx;
using HarmonyLib;
using GorillaLocomotion;
using System.Collections;
using UnityEngine;
using GorillaNetworking;
using HoneyLib.Utils;

namespace HoneyLib
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class HoneyLib : BaseUnityPlugin
    {
        public static string platform;
        public static bool steamVrActionsInit = false;

        void Awake()
        {
            // gameObject.AddComponent<Events.EventListener>();
            gameObject.AddComponent<EasyInput>();
            HarmonyPatches.ApplyHarmonyPatches();

            // StartCoroutine(DelayAwake());
        }

        // IEnumerator DelayAwake()
        // {
        //     yield return new WaitForSeconds(5f);

        //     platform = PlayFabAuthenticator.instance.platform.PlatformTag;
        // }
    }
}
