using ExitGames.Client.Photon;
using Photon.Pun;
using Photon.Realtime;

namespace HoneyLib.Utils
{
    public class GeneralUtils
    {
        public static VRRig RigOfPlayer(Player p)
        {
            VRRig rig;
            //start with most efficient method, continue to slower if failed
            if (GorillaParent.instance.vrrigDict.TryGetValue(p, out rig)) return rig;
            if (GorillaGameManager.instance.playerVRRigDict.TryGetValue(p.ActorNumber, out rig)) return rig;
            foreach (VRRig r in GorillaParent.instance.vrrigs)
            {
                if (r.myPlayer == p) return r;
            }
            return null;
        }

        public static Hashtable GetPlayerProperties(Player p) => p.CustomProperties;

        public static Hashtable GetPlayerProperties(PhotonView p) => p.Owner.CustomProperties;

        public static Hashtable GetPlayerProperties(VRRig r) => r.photonView.Owner.CustomProperties;
    }
}
