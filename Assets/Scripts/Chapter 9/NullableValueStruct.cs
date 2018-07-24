using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public struct NullableValueStruct {

    private float _realValue;
    private bool _nullFlag;

    public NullableValueStruct(float value, bool isNull)
    {
        this._realValue = value;
        this._nullFlag = isNull;
    }

    public float Value
    {
        get
        {
            return this._realValue;
        }
        set
        {
            this._realValue = value;
        }
    }

    public bool IsNull
    {
        get
        {
            return this._nullFlag;
        }
        set
        {
            this._nullFlag = value;
        }
    }
}
