using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ObjectExample : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {	
	}
	
	// Update is called once per frame
	void Update ()
    {
        this.PrintNum(Time.time);
	}

    void PrintNum(object number)
    {
        if(number == null)
        {
            Debug.Log("传入的数字为空值");
            return;
        }
        float realNumber = (float)number;
        Debug.Log("传入的数字为：" + realNumber);
    }
}
