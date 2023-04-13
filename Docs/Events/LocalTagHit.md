### LocalTagHit
This event will run when the local player tags someone, avaialable info is a raycasthit, bool to check if they are tagging the body and what player they are tagging.
Example:
```cs
    void Start()
    {
        Events.TagHitLocal += TagHitLocal;
        HarmonyPatches.ApplyHarmonyPatches();
    }

    void TagHitLocal(object sender, TagHitLocalArgs e)
    {
        Debug.Log($"HONEY LOCAL tag/hit\n{e.taggedPlayer.NickName}");
    }
```
This will log who the local player tags or hits.

[Back to TOC](https://github.com/BzzzThe18th/HoneyLib/blob/main/Docs/Events/TOC.md)
