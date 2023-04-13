using Photon.Pun;
using Photon.Realtime;

namespace HoneyLib.Utils.RoomUtils
{
    public class RoomUtils
    {
        public static bool InRoom = false;
        public static string RoomCode() => PhotonNetwork.CurrentRoom.Name;
        public static Player[] AllPlayers() => PhotonNetwork.PlayerList;
        public static int PlayerCount() => AllPlayers().Length;
    }
}
