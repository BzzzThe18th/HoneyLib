using System.Reflection;
using System.IO;
using UnityEngine;

namespace HoneyLib.Utils
{
    public static class EasyAssetLoading
    {
        public static AssetBundle LoadBundle(string assetDirectory)
        {
            Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(assetDirectory);
            return AssetBundle.LoadFromStream(stream);
        }

        public static GameObject LoadAssetToPrefab(string assetDirectory, string gameObjectName)
        {
            Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(assetDirectory);
            return AssetBundle.LoadFromStream(stream).LoadAsset<GameObject>(gameObjectName);
        }

        public static GameObject InstantiateAsset(string assetDirectory, string gameObjectName)
        {
            Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(assetDirectory);
            return GameObject.Instantiate(AssetBundle.LoadFromStream(stream).LoadAsset<GameObject>(gameObjectName));
        }

        public static GameObject SetupAsset(string assetDirectory, string gameObjectName, Vector3 pos, Quaternion eulers, Transform parent)
        {
            Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(assetDirectory);
            var go = GameObject.Instantiate(AssetBundle.LoadFromStream(stream).LoadAsset<GameObject>(gameObjectName));
            go.transform.localPosition = pos;
            go.transform.localRotation = Quaternion.Euler(eulers.x,eulers.y,eulers.z);
            go.transform.SetParent(parent, false);
            return go;
        }
        public static GameObject SetupAsset(string assetDirectory, string gameObjectName, Vector3 pos, Quaternion eulers)
        {
            Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(assetDirectory);
            var go = GameObject.Instantiate(AssetBundle.LoadFromStream(stream).LoadAsset<GameObject>(gameObjectName));
            go.transform.position = pos;
            go.transform.rotation = Quaternion.Euler(eulers.x, eulers.y, eulers.z);
            return go;
        }
    }
}
