using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Transform/DebugLogYourPlatform")]
public class AttributeTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Application.platform.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
