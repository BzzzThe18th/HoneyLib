### JoinLeaveRoom
These events will run when you leave or join a room.
Example:
```cs
    void Start()
    {
        Events.JoinedRoom += JoinedRoom;
        HarmonyPatches.ApplyHarmonyPatches();
    }

    void JoinedRoom(object sender, EventArgs e)
    {
        Debug.Log("HONEY Joined room");
    }
```
This will log when joining a room before anything else logs.

[Back to TOC](https://github.com/BzzzThe18th/HoneyLib/blob/main/Docs/Events/TOC.md)
