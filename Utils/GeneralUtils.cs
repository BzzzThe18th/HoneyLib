using System;
using ExitGames.Client.Photon;
using HarmonyLib;
using Photon.Pun;
using Photon.Realtime;

namespace HoneyLib.Utils
{
    public class GeneralUtils
    {
        public static Hashtable GetPlayerProperties(Player p) => p.CustomProperties;

        public static Hashtable GetPlayerProperties(PhotonView p) => p.Owner.CustomProperties;

        public static Hashtable GetPlayerProperties(VRRig r) => GetRigView(r).Owner.CustomProperties;

        [Obsolete("Currently obsolete, will return null")]
        public static PhotonView GetRigView(VRRig r)
        {
            // BUZZ: TODO: test "netView" and "myVoiceView" for possible methods. netView may be risky, seems to be part of the shit to fusion networking
            PhotonView v = (PhotonView)AccessTools.Field(r.GetType(), "photonView").GetValue(r);

            if (v == null && GorillaGameManager.instance != null)
            {
                return null; // method used no longer exists, couldnt find a workaround
            }

            return v;
        }
    }
}
