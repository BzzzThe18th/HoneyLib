using System;
using Photon.Realtime;
using Photon.Pun;   
using UnityEngine;

namespace HoneyLib.Events
{
    public class Events
    {
        public static event EventHandler<InfectionTagArgs> InfectionTag;
        public static event EventHandler<HuntTagArgs> HuntTag;
        public static event EventHandler<BattleHitArgs> BattleHit;

        public virtual void TriggerInfectionTag(InfectionTagArgs args)
        {
            InfectionTag?.Invoke(this, args);
        }
        public virtual void TriggerHuntTag(HuntTagArgs args)
        {
            HuntTag?.Invoke(this, args);
        }
        public virtual void TriggerBattleHit(BattleHitArgs args)
        {
            BattleHit.Invoke(this, args);
        }
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
