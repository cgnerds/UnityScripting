using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Linq;
using System.Xml;
using System.IO;

public class StreamingAssetsTest : MonoBehaviour {

    private string _result;

	// Use this for initialization
	void Start () {
        StartCoroutine(LoadXML());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    /// <summary>
    /// 如前文所述，StreamingAssets只能使用WWW来读取
    /// 如果不是使用WWW来读取的同学，就不要问为什么读不到StreamingAssets下的内容了
    /// 这里还可以使用PersistentDataPath来保存从StreamingAssets那里的内容
    /// </summary>
    /// <returns></returns>
    IEnumerator LoadXML()
    {
        string sPath = Application.streamingAssetsPath + "/Test.xml";
        WWW www = new WWW(sPath);
        yield return www;
        _result = www.text;
    }

    void OnGUI()
    {
        GUIStyle titleStyle = new GUIStyle();
        titleStyle.fontSize = 20;
        titleStyle.normal.textColor = new Color(46f / 256f, 163f / 256f, 256f / 256f, 256f / 256f);
        GUI.Label(new Rect(400, 10, 500, 200), _result, titleStyle);
    }
}
