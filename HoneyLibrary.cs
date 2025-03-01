using BepInEx;
using HarmonyLib;
using GorillaLocomotion;
using System.Collections;
using UnityEngine;
using GorillaNetworking;

namespace HoneyLib
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class HoneyLib : BaseUnityPlugin
    {
        public static string platform { get; private set; }

        void Awake()
        {
            gameObject.AddComponent<Events.EventListener>();
            HarmonyPatches.ApplyHarmonyPatches();

            StartCoroutine(DelayAwake());
        }

        IEnumerator DelayAwake()
        {
            yield return new WaitForSeconds(5f);

            platform = PlayFabAuthenticator.instance.platform.PlatformTag;
        }
    }
}
