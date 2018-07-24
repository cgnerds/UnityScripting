using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NullableValueTypeExample : MonoBehaviour {

    private NullableValueType value;

	// Use this for initialization
	void Start () {
        this.value = new NullableValueType(0f);
	}
	
	// Update is called once per frame
	void Update () {
        this.value.Value = Time.time;
        this.PrintNum(this.value);
	}

    void PrintNum(NullableValueType number)
    {
        if (number == null)
        {
            Debug.Log("传入的数字为空值");
            return;
        }

        Debug.Log("传入的数字为：" + number.Value);
    }
}
