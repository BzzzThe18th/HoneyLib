using Photon.Pun;
using Photon.Realtime;
using ExitGames.Client.Photon;
using UnityEngine;

namespace HoneyLib.Events
{
    class EventListener : MonoBehaviour
    {
        Events events = new Events();
        void Start()
        {
            PhotonNetwork.NetworkingClient.EventReceived += OnEvent;
            Debug.Log("Setting up event receiving");
        }

        private void OnEvent(EventData data)
        {
            if(data.Code == GorillaTagManager.ReportInfectionTagEvent)
            {
                //try to get tagging obj for info
                object[] tagObj = (object[])data.Parameters.TryGetObject(245);
                string taggerId = (string)tagObj[0], victimUserId = (string)tagObj[1];
                Player tagger = null;
                Player tagged = null;
                //inefficient but afaik necessary foreach loop
                foreach (var p in PhotonNetwork.PlayerList)
                {
                    if (p.UserId == taggerId) tagger = p;
                    if (p.UserId == victimUserId) tagged = p;
                }
                InfectionTagEventArgs args = new InfectionTagEventArgs();
                args.taggedPlayer = tagged;
                args.taggingPlayer = tagger;
                events.TriggerInfectionTagEvent(args);
            }
        }
    }
}
