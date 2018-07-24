using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AsTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.CheckAndPrintInt(999999999);
        this.CheckAndPrintInt("九九九九九九九九九");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void CheckAndPrintInt(object obj)
    {
        int? testInt = obj as int?;
        Debug.Log(testInt.HasValue ? testInt.Value.ToString() : "输出的参数无法转化为int");
    }
}
