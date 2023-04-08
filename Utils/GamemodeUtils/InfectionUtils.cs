using System.Collections.Generic;
using Photon.Realtime;
using HoneyLib.Patches;

namespace HoneyLib.Utils.GamemodeUtils
{
    class InfectionUtils
    {
        public static int InfectedCount()
        {
            return GameManagerPatch.tagManager.currentInfected.Count;
        }

        public static List<Player> InfectedPlayers()
        {
            return GameManagerPatch.tagManager.currentInfected;
        }

        public static bool CheckInfected(Player p)
        {
            return GameManagerPatch.tagManager.currentInfected.Contains(p);
        }
    }
}
