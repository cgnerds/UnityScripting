using System.Collections;
using UnityEngine;

public class BundleLoader : MonoBehaviour {

    public string url;
    public int version;

	IEnumerator Start () {
        while (!Caching.ready)
            yield return null;

        WWW www = WWW.LoadFromCacheOrDownload(url, version);
        yield return www;
        if(!string.IsNullOrEmpty(www.error))
        {
            Debug.Log(www.error);
            yield return null;
        }

        AssetBundle assetBundle = www.assetBundle;
        GameObject gameObject = assetBundle.LoadAsset<GameObject>("Cube");
        Instantiate(gameObject);
        assetBundle.Unload(false);
    }

}
