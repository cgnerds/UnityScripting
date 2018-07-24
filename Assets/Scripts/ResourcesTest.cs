using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Linq;

public class ResourcesTest : MonoBehaviour {

    private string _result;

	// Use this for initialization
	void Start () {
        LoadXML("Test");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void LoadXML(string path)
    {
        _result = Resources.Load(path).ToString();
        XmlDocument doc = new XmlDocument();
        doc.LoadXml(_result);
    }

    void OnGUI()
    {
        GUIStyle titleStyle = new GUIStyle();
        titleStyle.fontSize = 20;
        titleStyle.normal.textColor = new Color(46f / 256f, 163f / 256f, 256f / 256f, 256f / 256f);
        GUI.Label(new Rect(400, 10, 500, 200), _result, titleStyle);
    }
}
