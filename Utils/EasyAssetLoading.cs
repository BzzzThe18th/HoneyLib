using System.Reflection;
using System.IO;
using UnityEngine;

namespace HoneyLib.Utils
{
    public static class EasyAssetLoading
    {
        public static AssetBundle LoadBundle(Assembly a, string assetDirectory)
        {
            Stream stream = a.GetManifestResourceStream(assetDirectory);
            return AssetBundle.LoadFromStream(stream);
        }

        public static GameObject LoadAssetToPrefab(Assembly a, string assetDirectory, string gameObjectName)
        {
            var ab = LoadBundle(a, assetDirectory);
            var go = ab.LoadAsset<GameObject>(gameObjectName);
            ab.Unload(false);
            return go;
        }

        public static GameObject InstantiateAsset(Assembly a, string assetDirectory, string gameObjectName)
        {
            return GameObject.Instantiate(LoadAssetToPrefab(a, assetDirectory, gameObjectName));
        }

        public static GameObject SetupAsset(Assembly a, string assetDirectory, string gameObjectName, Vector3 pos, Quaternion eulers, Transform parent)
        {
            var go = InstantiateAsset(a, assetDirectory, gameObjectName);
            go.transform.localPosition = pos;
            go.transform.localRotation = Quaternion.Euler(eulers.x,eulers.y,eulers.z);
            go.transform.SetParent(parent, false);
            return go;
        }   
        public static GameObject SetupAsset(Assembly a, string assetDirectory, string gameObjectName, Vector3 pos, Quaternion eulers)
        {
            var go = InstantiateAsset(a, assetDirectory, gameObjectName);
            go.transform.position = pos;
            go.transform.rotation = Quaternion.Euler(eulers.x, eulers.y, eulers.z);
            return go;
        }
    }
}
