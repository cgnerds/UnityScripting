using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NulCoalescingOperator : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Int32? testNull = null;
        Int32? testInt = testNull ?? 999;
        Debug.Log("testInt has value: " + testInt.HasValue);
        Debug.Log("testInt value: " + testInt.Value);
        Debug.Log("testNull has value: " + testNull.HasValue);
        Debug.Log("testNull value: " + testNull.GetValueOrDefault());
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
