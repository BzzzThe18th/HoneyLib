### JoinLeaveRoom
You can get room join/leave events with two different methods:
 - [delegates](#delegates)
 - [events](#events)

#### Delegates
You can subscribe join/leave methods to the following:
```cs
void OnJoinedRoom(string roomcode, string gamemode);
void OnLeaveRoom();
void OnOtherLeaveRoom(Player leavingPlayer);
```
Example:
```cs
void OnJoinedRoom(string _roomCode, string _gamemode) =>
    Debug.Log($"room code: {_roomCode}, gamemode: {_gamemode}");

void OnLeaveRoom() =>
    Debug.Log("im outta here bye");

Events.OnJoinedRoom += OnJoinedRoom
Events.OnLeaveRoom += OnLeaveRoom
```

#### Events
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
