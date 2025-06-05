### EasyAssetLoading
EasyAssetLoading can be used very simply through multiple methods.

Example of loading a gameobject from a stream bundle:

```cs
        void OnGameInitialized(object sender, EventArgs e)
        {
            // NOTE: some of this code is not compatable with new versions
            //       of gorilla tag
            
            // code using honeylib is up-to-date such as SetupAsset();

            RB = GTPlayer.Instance.bodyCollider.attachedRigidbody;

            rHandT = GTPlayer.Instance.rightHandTransform;
            lHandT = GTPlayer.Instance.leftHandTransform;

            var lT = GameObject.Find("Player Objects/Local VRRig/Local Gorilla Player/rig/body/shoulder.L/upper_arm.L/forearm.L/hand.L").transform;
            gauntletL = EasyAssetLoading.SetupAsset("IronMonke.Assets.gloven", "gloveL", new Vector3(-0.026f, 0.015f, -0.0015f), Quaternion.Euler(63f, 85f, 0f), lT);

            var rT = GameObject.Find("Player Objects/Local VRRig/Local Gorilla Player/rig/body/shoulder.R/upper_arm.R/forearm.R/hand.R").transform;
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

## List of overloads
```cs
// Load an AssetBundle
AssetBundle LoadBundle(string assetDirectory)
AssetBundle LoadBundle(Assembly a, string assetDirectory)

// Load an asset bundle and instantiate an object from it
object LoadAssetToPrefab(string assetDirectory, string gameObjectName)
object LoadAssetToPrefab(Assembly a, string assetDirectory, string gameObjectName)

// can you guess what this does
GameObject InstantiateAsset(string assetDirectory, string gameObjectName)
GameObject InstantiateAsset(Assembly a, string assetDirectory, string gameObjectName)

// Loads an asset bundle, grabs a game object, and sets position and rotation stuff
GameObject SetupAsset(string assetDirectory, string gameObjectName, Vector3 pos, Quaternion eulers, Transform parent)
GameObject SetupAsset(string assetDirectory, string gameObjectName, Vector3 pos, Quaternion eulers)
GameObject SetupAsset(string assetDirectory, string gameObjectName, Transform parent, bool keepWorldPos)

GameObject SetupAsset(Assembly a, string assetDirectory, string gameObjectName, Vector3 pos, Quaternion eulers, Transform parent)
GameObject SetupAsset(Assembly a, string assetDirectory, string gameObjectName, Vector3 pos, Quaternion eulers)
GameObject SetupAsset(Assembly a, string assetDirectory, string gameObjectName, Transform parent, bool keepWorldPos)
```

This is a snippet of the new instantiation code for iron monke, it instantiates, parents, offsets and rotates the gauntlets.

[Back to TOC](https://github.com/BzzzThe18th/HoneyLib/blob/main/Docs/Utils/GeneralUtils/TOC.md)
