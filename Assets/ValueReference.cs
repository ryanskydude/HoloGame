using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValueReference
{
    public Value valueBase;
}

public class ValueFloatReference : ValueReference
{
    public float value;

    public ValueFloatReference(Value _valueBase, float _value = 0)
    {
        valueBase = _valueBase;
        value = _value;
    }

    internal void Sum(float sum)
    {
        value += sum;
    }
}

public class ValueIntReference : ValueReference
{
    public int value;

    public ValueIntReference(Value _ValueBase, int _value = 0)
    {
        valueBase = _ValueBase;
        value = _value;
    }

    

    internal void Sum(int sum)
    {
        value += sum;
    }
}