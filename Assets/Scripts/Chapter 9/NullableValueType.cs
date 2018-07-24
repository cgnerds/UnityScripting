using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NullableValueType {

    private float _value;

    public NullableValueType(float value)
    {
        this._value = value;
    }

    public float Value
    {
        get
        {
            return this._value;
        }
        set
        {
            this._value = value;
        }
    }
}