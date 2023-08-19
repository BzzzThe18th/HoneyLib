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

        public static PhotonView GetRigView(VRRig r)
        {
            PhotonView v = (PhotonView)AccessTools.Field(r.GetType(), "photonView").GetValue(r);
            if (v == null && GorillaGameManager.instance != null)
            {
                Player p = (Player)AccessTools.Field(r.GetType(), "creator").GetValue(r);
                v = GorillaGameManager.instance.FindVRRigForPlayer(p);
            }
            return v;
        }
    }
}
