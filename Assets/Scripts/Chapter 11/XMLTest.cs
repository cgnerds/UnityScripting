using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Linq;

public class XMLTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
        XElement result = LoadXML("Assets/Xml/Test.xml");
        Debug.Log(result.ToString());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    XElement LoadXML(string path)
    {
        XElement xml = XElement.Load(path);
        return xml;
    }
}
