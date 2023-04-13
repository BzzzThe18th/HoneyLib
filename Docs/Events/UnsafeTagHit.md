### UnsafeTagHit
This event runs based on tag sounds, it will run when the player tagged sound runs (also runs when someone joins and gets tagged), and when the player slow sound runs, it's unsafe due to the possibility of spamming it using cheat mods. It also contains no information.
Example:
```cs
    void Start()
    {
        Events.TagHitUnsafe += TagHitUnsafe;
        HarmonyPatches.ApplyHarmonyPatches();
    }
    void TagHitUnsafe(object sender, EventArgs e)
    {
        Debug.Log($"HONEY UNSAFE tag/hit");
    }
```
This will log whenever the tag or slow sounds are detected.

[Back to TOC](https://github.com/BzzzThe18th/HoneyLib/blob/main/Docs/Events/TOC.md)
