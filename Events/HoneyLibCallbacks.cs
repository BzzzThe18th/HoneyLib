using UnityEngine;
using Photon.Pun;
using HoneyLib.Events;

namespace HoneyLib.Events
{
    class HoneyLibCallbacks : MonoBehaviourPunCallbacks
    {
        Events events = new Events();
        public override void OnJoinedRoom()
        {
            if(Events.JoinedRoom != null)
            {
                base.OnJoinedRoom();
                events.TriggerJoinedRoom();
                Utils.RoomUtils.RoomUtils.InRoom = true;
            }
        }

        public override void OnLeftRoom()
        {
            if(Events.LeftRoom != null)
            {
                base.OnLeftRoom();
                Events events = new Events();
                events.TriggerLeftRoom();
                Utils.RoomUtils.RoomUtils.InRoom = false;
            }
        }
    }
}
