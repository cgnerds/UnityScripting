using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Linq;
using System.Xml;
using System.IO;

public class AssetBundleTest : MonoBehaviour {

    private string _result;

	// Use this for initialization
	void Start () {
        LoadXML();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void LoadXML()
    {
        //AssetBundle AssetBundleCsv = new AssetBundle();
        // 读取放入StreamingAssets文件夹中的bundle文件
        string str = Application.streamingAssetsPath + "/" + "TextXML.bundle";
        WWW www = new WWW(str);
        www = WWW.LoadFromCacheOrDownload(str, 0);
        AssetBundle AssetBundleCsv = www.assetBundle;

        string path = "Test";
        TextAsset test = AssetBundleCsv.LoadAsset(path, typeof(TextAsset)) as TextAsset;
        _result = test.ToString();
    }

    void OnGUI()
    {
        GUIStyle titleStyle = new GUIStyle();
        titleStyle.fontSize = 20;
        titleStyle.normal.textColor = new Color(46f / 256f, 163f / 256f, 256f / 256f, 256f / 256f);
        GUI.Label(new Rect(400, 10, 500, 200), _result, titleStyle);
    }
}
