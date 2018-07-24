using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NullableOperator : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Int32? testInt = 999;
        Int32? testNull = null;

        // 一元操作符(+ ++ - -- ! ~)
        testInt++;
        testNull = -testNull;

        // 二元操作符(+ - * / % & | ^ << >>)
        testInt = testInt + 1000;
        testNull = testNull * 1000;

        // 相等性操作符(== ！=)
        if(testInt != null)
        {
            Debug.Log("testInt is not Null!");
        }
        if(testNull == null)
        {
            Debug.Log("testNull is Null");
        }

        // 比较操作符(< > <= >=)
        if(testInt > testNull)
        {
            Debug.Log("testInt larger than testNull");
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
