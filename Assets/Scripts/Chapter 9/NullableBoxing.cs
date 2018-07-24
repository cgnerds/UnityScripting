using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NullableBoxing : MonoBehaviour {

	// Use this for initialization
	void Start () {
        // 从正常的不可空的值类型int隐式转换为Nullable<Int32>
        Int32? testInt = 999;
        // 从null隐式转换为Nullable<Int32>
        Int32? testNull = new Nullable<int>();

        object boxedInt = testInt;
        Debug.Log("不可空的可空值类型实例的装箱: " + boxedInt.GetType());

        Int32 normalInt = (int)boxedInt;
        Debug.Log("拆箱为普通的值类型Int32: " + normalInt);

        testInt = (Nullable<int>)boxedInt;
        Debug.Log("拆箱为可空值类型: " + testInt);

        object boxedNull = testNull;
        Debug.Log("为空的可空值类型实例的装箱: " + (boxedNull == null));

        testNull = (Nullable<int>)boxedNull;
        Debug.Log("拆箱为可空值类型: " + testNull.HasValue);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
