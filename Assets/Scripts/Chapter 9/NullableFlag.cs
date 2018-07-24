using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NullableFlag : MonoBehaviour {

    private float _realValue;
    private bool _nullFlag;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this._realValue = Time.time;
        this._nullFlag = false;
        this.PrintNum(this._realValue);
	}

    void LateUpdate()
    {
        this._nullFlag = true;
        this.PrintNum(this._realValue);
    }

    void PrintNum(float number)
    {
        if(this._nullFlag)
        {
            Debug.Log("传入的数字为空值");
            return;
        }
        Debug.Log("传入的数字为：" + number);
    }
}
