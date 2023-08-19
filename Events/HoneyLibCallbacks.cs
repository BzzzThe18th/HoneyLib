using Photon.Pun;
using Photon.Realtime;

namespace HoneyLib.Events
{
    class HoneyLibCallbacks : MonoBehaviourPunCallbacks, IInRoomCallbacks
    {
        Events events = new Events();
        public override void OnJoinedRoom()
        {
            if (Events.JoinedRoom != null)
            {
                string gamemode = "unassigned";
                if (PhotonNetwork.CurrentRoom.CustomProperties.TryGetValue("gameMode", out var gamemodeObject))
                {
                    gamemode = gamemodeObject as string;
                }
                RoomArgs args = new RoomArgs();
                args.gamemode = gamemode;
                events.TriggerJoinedRoom(args);
                Utils.RoomUtils.RoomUtils.InRoom = true;
            }
        }

        public override void OnLeftRoom()
        {
            if (Events.LeftRoom != null)
            {
                events.TriggerLeftRoom();
                Utils.RoomUtils.RoomUtils.InRoom = false;
            }
        }

        public override void OnPlayerLeftRoom(Player otherPlayer)
        {
            base.OnPlayerLeftRoom(otherPlayer);
            if (Events.OtherLeftRoom != null)
            {
                OtherLeaveJoinArgs args = new OtherLeaveJoinArgs();
                args.otherPlayer = otherPlayer;

                events.TriggerOtherLeftRoom(args);
            }
        }
    }
}
