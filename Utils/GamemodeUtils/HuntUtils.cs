// using System.Collections.Generic;
// using Photon.Pun;
// using Photon.Realtime;
// using HoneyLib.Patches;
using System;

namespace HoneyLib.Utils.GamemodeUtils
{
    [Obsolete("Due to lack of ability to test, gamemode events have been deprecated", true)]
    public class HuntUtils
    {
        // public static Player TargetOfPlayer(Player p) => GameManagerPatch.huntManager.GetTargetOf(p);

        // public static Player HunterOfPlayer(Player p)
        // {
        //     Player p2 = null;
        //     foreach (Player player in PhotonNetwork.PlayerList)
        //     {
        //         if (GameManagerPatch.huntManager.IsTargetOf(player, p)) p2 = player;
        //     }
        //     return p2;
        // }

        // public static int HuntedCount() => GameManagerPatch.huntManager.currentHunted.Count;

        // public static List<Player> HuntedPlayers() => GameManagerPatch.huntManager.currentHunted;

        // public static bool CheckHunted(Player p) => GameManagerPatch.huntManager.currentHunted.Contains(p);
    }
}
