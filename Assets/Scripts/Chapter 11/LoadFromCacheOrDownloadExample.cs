using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadFromCacheOrDownloadExample : MonoBehaviour {

	// Use this for initialization
	IEnumerator Start () {
        var www = WWW.LoadFromCacheOrDownload("http://myserver.com/myassetBundle.unity3d", 5);
        yield return www;
        if(!string.IsNullOrEmpty(www.error))
        {
            Debug.Log(www.error);
            yield return null;
        }
        var myLoadedAssetBundle = www.assetBundle;
        var asset = myLoadedAssetBundle.mainAsset;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
