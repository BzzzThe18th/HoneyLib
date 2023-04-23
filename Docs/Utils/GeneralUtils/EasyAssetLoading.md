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
            gauntletL = EasyAssetLoading.SetupAsset(Assembly.GetExecutingAssembly(), "IronMonke.Assets.gloven", "gloveL", new Vector3(-0.026f, 0.015f, -0.0015f), Quaternion.Euler(63f, 85f, 0f), lT);
            var rT = GameObject.Find("Global/Local VRRig/Local Gorilla Player/rig/body/shoulder.R/upper_arm.R/forearm.R/hand.R").transform;
            gauntletR = EasyAssetLoading.SetupAsset(Assembly.GetExecutingAssembly(), "IronMonke.Assets.gloven", "gloveR", new Vector3(0.02f, 0.015f, -0.0015f), Quaternion.Euler(63f, 275f, 180f), rT);

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

[Back to TOC](https://github.com/BzzzThe18th/HoneyLib/blob/main/Docs/Utils/GeneralUtils/TOC.md)
