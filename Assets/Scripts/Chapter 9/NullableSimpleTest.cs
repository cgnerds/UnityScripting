using System.Collections;
using UnityEngine;
using System;

public class NullableSimpleTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Int32? testInt = 999;
        Int32? testNull = null;
        Debug.Log("testInt has value: " + testInt.HasValue);
        Debug.Log("testInt value: " + testInt.Value);
        Debug.Log("testInt value: " + (Int32)testInt);
        Debug.Log("testNull has value: " + testNull.HasValue);
        Debug.Log("testNull value: " + testNull.GetValueOrDefault());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
