using System;
using Photon.Realtime;
using Photon.Pun;   
using UnityEngine;

namespace HoneyLib.Events
{
    public class Events
    {
        public static event EventHandler<InfectionTagArgs> InfectionTag;
        public static event EventHandler<InfectionTagArgs> PreInfectionTag;
        public static event EventHandler<HuntTagArgs> HuntTag;
        public static event EventHandler<HuntTagArgs> PreHuntTag;
        public static event EventHandler<BattleHitArgs> BattleHit;
        public static event EventHandler<BattleHitArgs> PreBattleHit;
        public static event EventHandler JoinedRoom;
        public static event EventHandler PreJoinedRoom;
        public static event EventHandler LeftRoom;
        public static event EventHandler PreLeftRoom;
        public static event EventHandler PropertiesUpdate;
        public static event EventHandler PrePropertiesUpdate;

        public virtual void TriggerInfectionTag(InfectionTagArgs args) => InfectionTag?.Invoke(this, args);
        public virtual void TriggerPreInfectionTag(InfectionTagArgs args) => PreInfectionTag?.Invoke(this, args);
        public virtual void TriggerHuntTag(HuntTagArgs args) =>  HuntTag?.Invoke(this, args);
        public virtual void TriggerPreHuntTag(HuntTagArgs args) => PreHuntTag?.Invoke(this, args);
        public virtual void TriggerBattleHit(BattleHitArgs args) => BattleHit.Invoke(this, args);
        public virtual void TriggerPreBattleHit(BattleHitArgs args) => PreBattleHit.Invoke(this, args);
        public virtual void TriggerJoinedRoom() => JoinedRoom.Invoke(this, EventArgs.Empty);
        public virtual void TriggerPreJoinedRoom() => PreJoinedRoom.Invoke(this, EventArgs.Empty);
        public virtual void TriggerLeftRoom() => LeftRoom.Invoke(this, EventArgs.Empty);
        public virtual void TriggerPreLeftRoom() => PreLeftRoom.Invoke(this, EventArgs.Empty);
        public virtual void TriggerPropertiesUpdate() => PropertiesUpdate.Invoke(this, EventArgs.Empty);
        public virtual void TriggerPrePropertiesUpdate() => PrePropertiesUpdate.Invoke(this, EventArgs.Empty);
    }

    public class InfectionTagArgs : EventArgs
    {
        public Player taggedPlayer { get; set; }
        public Player taggingPlayer { get; set; }
    }
    public class HuntTagArgs : EventArgs
    {
        public Player taggedPlayer { get; set; }
        public Player taggingPlayer { get; set; }
    }
    public class BattleHitArgs : EventArgs
    {
        public Player taggedPlayer { get; set; }
        public Vector3 hitLocation { get; set; }
        public int projectileCount { get; set; }
        public PhotonMessageInfo info { get; set; }
    }
}
