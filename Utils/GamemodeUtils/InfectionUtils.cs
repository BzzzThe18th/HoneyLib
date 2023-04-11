using System.Collections.Generic;
using Photon.Realtime;
using HoneyLib.Patches;

namespace HoneyLib.Utils.GamemodeUtils
{
    class InfectionUtils
    {
        public static int InfectedCount() => GameManagerPatch.tagManager.currentInfected.Count;

        public static List<Player> InfectedPlayers() => GameManagerPatch.tagManager.currentInfected;

        public static bool CheckInfected(Player p) => GameManagerPatch.tagManager.currentInfected.Contains(p);
    }
}
