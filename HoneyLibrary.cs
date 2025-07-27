using BepInEx;
using HoneyLib.Utils;

namespace HoneyLib
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class HoneyLib : BaseUnityPlugin
    {
        public static PlatformTagJoin platform;
        // public static bool steamVrActionsInit = false;

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
