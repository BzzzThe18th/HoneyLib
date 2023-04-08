using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using HoneyLib.Patches;

namespace HoneyLib.Utils.GamemodeUtils
{
    class HuntUtils
    {
        public static Player TargetOfPlayer(Player p)
        {
            return GameManagerPatch.huntManager.GetTargetOf(p);
        }

        public static Player HunterOfPlayer(Player p)
        {
            Player p2 = null;
            foreach (Player player in PhotonNetwork.PlayerList)
            {
                if (GameManagerPatch.huntManager.IsTargetOf(player, p)) p2 = player;
            }
            return p2;
        }

        public static int HuntedCount()
        {
            return GameManagerPatch.huntManager.currentHunted.Count;
        }

        public static List<Player> HuntedPlayers()
        {
            return GameManagerPatch.huntManager.currentHunted;
        }

        public static bool CheckHunted(Player p)
        {
            return GameManagerPatch.huntManager.currentHunted.Contains(p);
        }
    }
}
