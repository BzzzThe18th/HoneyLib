# HONEY LIBRARY
Honey library is a mod creation library with utils to simplify mod creation and make code look more elegant.

### How to Use
Start by [installing the mod](https://github.com/BzzzThe18th/HoneyLib/releases/latest/download/HoneyLib-v1.0.0.zip), then open the project you would like to use HoneyLib for.

Under the solution explorer in Visual Studio, right-click "Dependencies"

![image](https://user-images.githubusercontent.com/69125495/230703400-1b1eb63c-4c38-4df9-9337-84f0d8c9fd1b.png "Dependencies highlighted here")

Next, click "Add Project Reference"

![image](https://user-images.githubusercontent.com/69125495/230703422-56ad931c-8bff-4486-aec7-c035e47f54b7.png "Add Project Reference highlighted here")

You will be met with a new window that should look something like this

![image](https://user-images.githubusercontent.com/69125495/230703459-b3089824-f4b9-4048-b0af-88119acbbe40.png "Project reference window")

Click "Browse" and navigate to your Plugins folder directory.

![image](https://user-images.githubusercontent.com/69125495/230703511-947062b2-c4fe-4819-be1c-6531028f9a20.png)

Open the HoneyLib folder and select the HoneyLib DLL.
Click OK.

You can now use HoneyLib as you would any other namespace.

## Documentation

HoneyLib v1.0.0 has Utilities for the Infection, Paintbrawl and Hunt gamemodes, currently allowing for easy access to an array of utilities and variables within said gamemodes. It also allows for XR Controller inputs to be used easily.

### EasyInput
EasyInput can be used as simply as running the `UpdateInput` method when you want to check for inputs and then referencing those inputs with simple variables such as `FaceButtonX`

Example:
```cs
        void FixedUpdate()
        {
            EasyInput.UpdateInput();

            if (EasyInput.RightStickClick) Debug.Log("O.O");
        }
```

This will log `O.O` when the right joystick is clicked down.
### EasyAssetLoading
EasyAssetLoading can be used very simply through multiple methods.

Example of loading a gameobject from a stream bundle:

```cs
        void OnGameInitialized(object sender, EventArgs e)
        {
            RB = Player.Instance.bodyCollider.attachedRigidbody;

            rHandT = Player.Instance.rightHandTransform;
            lHandT = Player.Instance.leftHandTransform;

            var lT = GameObject.Find("Global/Local VRRig/Local Gorilla Player/rig/body/shoulder.L/upper_arm.L/forearm.L/hand.L").transform;
            gauntletL = EasyAssetLoading.SetupAsset("IronMonke.Assets.gloven", "gloveL", new Vector3(-0.026f, 0.015f, -0.0015f), Quaternion.Euler(63f, 85f, 0f), lT);
            var rT = GameObject.Find("Global/Local VRRig/Local Gorilla Player/rig/body/shoulder.R/upper_arm.R/forearm.R/hand.R").transform;
            gauntletR = EasyAssetLoading.SetupAsset("IronMonke.Assets.gloven", "gloveR", new Vector3(0.02f, 0.015f, -0.0015f), Quaternion.Euler(63f, 275f, 180f), rT);

            particlesL = gauntletL.transform.GetChild(0).GetChild(0).gameObject.GetComponent<ParticleSystem>();
            particlesR = gauntletR.transform.GetChild(0).GetChild(0).gameObject.GetComponent<ParticleSystem>();

            audioL = gauntletL.GetComponent<AudioSource>();
            audioR = gauntletR.GetComponent<AudioSource>();

            if (particlesL.isPlaying) particlesL.Stop();
            if (particlesR.isPlaying) particlesR.Stop();

            gauntletL.SetActive(false);
            gauntletR.SetActive(false);

            initialized = true;
        }
```

This is a snippet of the new instantiation code for iron monke, it instantiates, parents, offsets and rotates the gauntlets.

### GeneralUtils
This class is for general utilities such as fetching player properties and and getting a player's rig.
No example is needed.

### GamemodeUtils
All gamemode utilities contain various methods to gather information about specific gamemodes for mod use easily.
No example is needed, names are descriptive and simple.

## Feature requests / bug reports
If you have any feature requests or bug reports, please contact me through discord at `Buzz Bzzz bzz BZZZ The 18th#0431`
This mod was made quickly and not tested very thoroughly, if something is wrong or seems wrong, please contact me.
