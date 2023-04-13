using System;
using Photon.Realtime;
using Photon.Pun;   
using UnityEngine;

namespace HoneyLib.Events
{
    public class Events
    {
        public static EventHandler<InfectionTagMasterArgs> InfectionTagMaster;
        public static EventHandler<InfectionTagMasterArgs> PreInfectionTagMaster;
        public static EventHandler<InfectionTagEventArgs> InfectionTagEvent;
        public static EventHandler<HuntTagMasterArgs> HuntTagMaster;
        public static EventHandler<HuntTagMasterArgs> PreHuntTagMaster;
        public static EventHandler<BattleHitMasterArgs> BattleHitMaster;
        public static EventHandler<BattleHitMasterArgs> PreBattleHitMaster;
        public static EventHandler JoinedRoom;
        public static EventHandler LeftRoom;
        public static EventHandler<TagHitUnsafeArgs> TagHitUnsafe;
        public static EventHandler<TagHitUnsafeArgs> PreTagHitUnsafe;
        public static EventHandler<TagHitLocalArgs> TagHitLocal;
        public static EventHandler<TagHitLocalArgs> PreTagHitLocal;

        public virtual void TriggerInfectionTagMaster(InfectionTagMasterArgs args) => InfectionTagMaster?.Invoke(this, args);
        public virtual void TriggerPreInfectionTagMaster(InfectionTagMasterArgs args) => PreInfectionTagMaster?.Invoke(this, args);
        public virtual void TriggerInfectionTagEvent(InfectionTagEventArgs args) => InfectionTagEvent?.Invoke(this, args);
        public virtual void TriggerHuntTagMaster(HuntTagMasterArgs args) =>  HuntTagMaster?.Invoke(this, args);
        public virtual void TriggerPreHuntTagMaster(HuntTagMasterArgs args) => PreHuntTagMaster?.Invoke(this, args);
        public virtual void TriggerBattleHitMaster(BattleHitMasterArgs args) => BattleHitMaster.Invoke(this, args);
        public virtual void TriggerPreBattleHitMaster(BattleHitMasterArgs args) => PreBattleHitMaster.Invoke(this, args);
        public virtual void TriggerJoinedRoom() => JoinedRoom.Invoke(this, EventArgs.Empty);
        public virtual void TriggerLeftRoom() => LeftRoom.Invoke(this, EventArgs.Empty);
        public virtual void TriggerTagHitUnsafe(TagHitUnsafeArgs args) => TagHitUnsafe?.Invoke(this, args);
        public virtual void TriggerPreTagHitUnsafe(TagHitUnsafeArgs args) => PreTagHitUnsafe?.Invoke(this, args);
        public virtual void TriggerTagHitLocal(TagHitLocalArgs args) => TagHitLocal?.Invoke(this, args);
        public virtual void TriggerPreTagHitLocal(TagHitLocalArgs args) => PreTagHitLocal?.Invoke(this, args);
    }

    public class InfectionTagMasterArgs : EventArgs
    {
        public Player taggedPlayer { get; set; }
        public Player taggingPlayer { get; set; }
    }
    public class InfectionTagEventArgs : EventArgs
    {
        public Player taggedPlayer { get; set; }
        public Player taggingPlayer { get; set; }
    }
    public class HuntTagMasterArgs : EventArgs
    {
        public Player taggedPlayer { get; set; }
        public Player taggingPlayer { get; set; }
    }
    public class BattleHitMasterArgs : EventArgs
    {
        public Player taggedPlayer { get; set; }
        public Vector3 hitLocation { get; set; }
        public int projectileCount { get; set; }
        public PhotonMessageInfo info { get; set; }
    }
    public class TagHitUnsafeArgs : EventArgs
    {
        public PhotonMessageInfo info { get; set; }
    }
    public class TagHitLocalArgs : EventArgs
    {
        public RaycastHit hitInfo { get; set; }
        public bool isBodyTag { get; set; }
        public Player taggedPlayer { get; set; }
    }
}