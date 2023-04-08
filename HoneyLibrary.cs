using BepInEx;

namespace HoneyLib
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class HoneyLib : BaseUnityPlugin
    {
        void Awake()
        {
            HarmonyPatches.ApplyHarmonyPatches();
        }
    }
}
