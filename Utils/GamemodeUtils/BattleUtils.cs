using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;
using HoneyLib.Patches;

namespace HoneyLib.Utils.GamemodeUtils
{
    public class BattleUtils
    {
        public static bool IsOnBlueTeam(Player p) => GameManagerPatch.battleManager.OnBlueTeam(p);

        public static bool IsOnOrangeTeam(Player p) => GameManagerPatch.battleManager.OnRedTeam(p);

        public static bool IsOnNoTeam(Player p) => GameManagerPatch.battleManager.OnNoTeam(p);
        
        public static bool OnSameTeam(Player p1, Player p2) => GameManagerPatch.battleManager.OnSameTeam(p1, p2);

        public static int GetLives(Player p) => GameManagerPatch.battleManager.GetPlayerLives(p);

        public static bool IsOnStunCooldown(Player p) => GameManagerPatch.battleManager.PlayerInStunCooldown(p);

        public static bool IsOnHitCooldown(Player p) => GameManagerPatch.battleManager.PlayerInHitCooldown(p);

        public static List<Player> OrangeTeamPlayers()
        {
            List<Player> pL = new List<Player>();
            foreach (Player p in PhotonNetwork.PlayerList)
            {
                if (GameManagerPatch.battleManager.OnRedTeam(p)) pL.Add(p);
            }
            return pL;
        }
        
        public static List<Player> BlueTeamPlayers()
        {
            List<Player> pL = new List<Player>();
            foreach (Player p in PhotonNetwork.PlayerList)
            {
                if (GameManagerPatch.battleManager.OnBlueTeam(p)) pL.Add(p);
            }
            return pL;
        }
        
        public static List<Player> NoTeamPlayers()
        {
            List<Player> pL = new List<Player>();
            foreach (Player p in PhotonNetwork.PlayerList)
            {
                if (GameManagerPatch.battleManager.OnNoTeam(p)) pL.Add(p);
            }
            return pL;
        }
        
        public static List<Player> DeadPlayers()
        {
            List<Player> pL = new List<Player>();
            foreach (Player p in PhotonNetwork.PlayerList)
            {
                if (GameManagerPatch.battleManager.GetPlayerLives(p) <= 0) pL.Add(p);
            }
            return pL;
        }


        public static int OrangeTeamCount() => OrangeTeamPlayers().Count;
        
        public static int BlueTeamCount() => BlueTeamPlayers().Count;

        public static int NoTeamCount() => NoTeamPlayers().Count;
        
        public static int DeadCount() => DeadPlayers().Count;
    }
}
