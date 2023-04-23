using Photon.Pun;

namespace HoneyLib.Events
{
    class HoneyLibCallbacks : MonoBehaviourPunCallbacks
    {
        Events events = new Events();
        public override void OnJoinedRoom()
        {
            if (Events.JoinedRoom != null)
            {
                events.TriggerJoinedRoom();
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
    }
}
