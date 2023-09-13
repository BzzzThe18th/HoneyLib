using BepInEx;
using HarmonyLib;
using System.Collections;
using UnityEngine;

namespace HoneyLib
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class HoneyLib : BaseUnityPlugin
    {
        void Awake()
        {
            gameObject.AddComponent<Events.EventListener>();
            HarmonyPatches.ApplyHarmonyPatches();

            StartCoroutine(DelayAwake());
        }

        IEnumerator DelayAwake()
        {
            yield return new WaitForSeconds(5f);

            gameObject.AddComponent<Utils.EasyInput>().platform = (string)Traverse.Create(GorillaNetworking.PlayFabAuthenticator.instance).Field("platform").GetValue();
        }
    }
}