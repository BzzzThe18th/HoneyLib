using System.Reflection;
using System.IO;
using UnityEngine;

namespace HoneyLib.Utils
{
    /*
    * note from bingus:
    * the assembly.getcallingassembly() was last tested with cardboard in may 2025
    * https://github.com/sirkingbinx/cardboard/blob/master/Utils/CardboardAssetLoader.cs
    *
    * every code referencing these should still work because defining the assembly yourself
    * is still avaliable as an overload
    */
    public static class EasyAssetLoading
    {
        public static AssetBundle LoadBundle(string assetDirectory)
        {
            Stream stream = Assembly.GetCallingAssembly().GetManifestResourceStream(assetDirectory);
            return AssetBundle.LoadFromStream(stream);
        }

        public static AssetBundle LoadBundle(Assembly a, string assetDirectory)
        {
            Stream stream = a.GetManifestResourceStream(assetDirectory);
            return AssetBundle.LoadFromStream(stream);
        }

        public static object LoadAssetToPrefab(string assetDirectory, string gameObjectName)
        {
            var ab = LoadBundle(Assembly.GetCallingAssembly(), assetDirectory);
            var obj = ab.LoadAsset(gameObjectName);
            ab.Unload(false);
            return obj;
        }

        public static object LoadAssetToPrefab(Assembly a, string assetDirectory, string gameObjectName)
        {
            var ab = LoadBundle(a, assetDirectory);
            var obj = ab.LoadAsset(gameObjectName);
            ab.Unload(false);
            return obj;
        }

        public static GameObject InstantiateAsset(string assetDirectory, string gameObjectName) =>
            GameObject.Instantiate((GameObject)LoadAssetToPrefab(Assembly.GetCallingAssembly(), assetDirectory, gameObjectName));

        public static GameObject InstantiateAsset(Assembly a, string assetDirectory, string gameObjectName) =>
            GameObject.Instantiate((GameObject)LoadAssetToPrefab(a, assetDirectory, gameObjectName));
        
        public static GameObject SetupAsset(string assetDirectory, string gameObjectName, Vector3 pos, Quaternion eulers, Transform parent)
        {
            var go = InstantiateAsset(Assembly.GetCallingAssembly(), assetDirectory, gameObjectName);
            go.transform.localPosition = pos;
            go.transform.rotation = Quaternion.Euler(eulers.x,eulers.y,eulers.z);
            go.transform.SetParent(parent, false);
            return go;
        }
         
        public static GameObject SetupAsset(string assetDirectory, string gameObjectName, Vector3 pos, Quaternion eulers)
        {
            var go = InstantiateAsset(Assembly.GetCallingAssembly(), assetDirectory, gameObjectName);
            go.transform.position = pos;
            go.transform.rotation = Quaternion.Euler(eulers.x, eulers.y, eulers.z);
            return go;
        }

        public static GameObject SetupAsset(string assetDirectory, string gameObjectName, Transform parent, bool keepWorldPos)
        {
            var go = InstantiateAsset(Assembly.GetCallingAssembly(), assetDirectory, gameObjectName);
            go.transform.SetParent(parent, keepWorldPos);
            return go;
        }

        public static GameObject SetupAsset(Assembly a, string assetDirectory, string gameObjectName, Vector3 pos, Quaternion eulers, Transform parent)
        {
            var go = InstantiateAsset(a, assetDirectory, gameObjectName);
            go.transform.localPosition = pos;
            go.transform.rotation = Quaternion.Euler(eulers.x,eulers.y,eulers.z);
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

        public static GameObject SetupAsset(Assembly a, string assetDirectory, string gameObjectName, Transform parent, bool keepWorldPos)
        {
            var go = InstantiateAsset(a, assetDirectory, gameObjectName);
            go.transform.SetParent(parent, keepWorldPos);
            return go;
        }
    }
}
