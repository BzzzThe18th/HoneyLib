using BepInEx;

namespace HoneyLib
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class HoneyLib : BaseUnityPlugin
    {
        void Awake()
        {
            gameObject.AddComponent<Events.EventListener>();
            HarmonyPatches.ApplyHarmonyPatches();
        }
    }
}