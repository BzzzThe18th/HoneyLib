### InfectionEventTag
Infection event tag events are only viable for infection and allow the same info as [MasterTagHit](https://github.com/BzzzThe18th/HoneyLib/blob/main/Docs/Events/MasterTagHit.md), without the master requirement or spam.
```cs
        void Start()
        {
            Events.InfectionTagMaster += InfectionTagMaster;
            HarmonyPatches.ApplyHarmonyPatches();
        }
        
        void InfectionTagEvent(object sender, InfectionTagEventArgs e)
        {
            Debug.Log($"HONEY EVENT Infection tag\n{e.taggingPlayer.NickName}, {e.taggedPlayer.NickName}");
        }
```
This will log the same as the documentation in [MasterTagHit](https://github.com/BzzzThe18th/HoneyLib/blob/main/Docs/Events/MasterTagHit.md) but without spam.

[Back to TOC](https://github.com/BzzzThe18th/HoneyLib/blob/main/Docs/Events/TOC.md)
