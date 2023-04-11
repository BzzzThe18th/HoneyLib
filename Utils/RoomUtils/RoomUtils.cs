using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;

namespace HoneyLib.Utils.RoomUtils
{
    class RoomUtils
    {
        public static bool InRoom() => PhotonNetwork.InRoom;
        public static string RoomCode() => PhotonNetwork.CurrentRoom.Name;
        public static Player[] AllPlayers() => PhotonNetwork.PlayerList;
        public static int PlayerCount() => AllPlayers().Length;
    }
}
