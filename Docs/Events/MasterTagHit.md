### MasterTagHit
Master tagging or hitting events detect when someone is tagged as master client. It gives more information and can be used for all three gamemodes, but only runs when the user is master client.
Example:
```cs
    void Start()
    {
        Events.InfectionTagMaster += InfectionTagMaster;
        HarmonyPatches.ApplyHarmonyPatches();
    }

    void InfectionTagMaster(object sender, InfectionTagMasterArgs e)
    {
        Debug.Log($"HONEY MASTER Infection tag\n{e.taggingPlayer.NickName}, {e.taggedPlayer.NickName}");
    }
```
This will log who got tagged and who tagged said person upon anyone tagging, due to how the game works, in hunt and infection this will be spammed while tagging until that person is tagged.

[Back to TOC](https://github.com/BzzzThe18th/HoneyLib/blob/main/Docs/Events/TOC.md)
