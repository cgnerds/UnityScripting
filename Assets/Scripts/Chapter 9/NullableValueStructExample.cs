using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NullableValueStructExample : MonoBehaviour {

    private NullableValueStruct number = new NullableValueStruct(0f, false);

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.number.Value = Time.time;
        this.number.IsNull = false;
        this.PrintNum(this.number);
	}

    void LateUpdate()
    {
        this.number.IsNull = true;
        this.PrintNum(this.number);
    }

    void PrintNum(NullableValueStruct number)
    {
        if (number.IsNull)
        {
            Debug.Log("传入的数字为空值");
            return;
        }
        Debug.Log("传入的数字为：" + number.Value);
    }
}
