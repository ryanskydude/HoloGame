using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsContainer
{
    public List<ValueReference> valueList;

    public StatsContainer()
    {
        valueList = new List<ValueReference>();
    }

    internal string GetText(Value trackValue)
    {
        int i = valueList.FindIndex(x => x.valueBase == trackValue);
        return valueList[i].TEXT;
    }

    public void Sum(Value v, int sum)
    {
        int i = valueList.FindIndex(x => x.valueBase == v);
        if (i != -1)
        {
            ValueIntReference reference = (ValueIntReference)valueList[i];
            reference.Sum(sum);
        }
        else
        {
            Add(v, sum);
        }
    }

    internal void Subscribe(Action action, Value trackValue)
    {
        int i = valueList.FindIndex(x => x.valueBase == trackValue);
        valueList[i].onChange += action;
    }
    public void Sum(Value v, float sum)
    {
        int i = valueList.FindIndex(x => x.valueBase == v);
        if (i != -1)
        {
            ValueFloatReference reference = (ValueFloatReference)valueList[i];
            reference.Sum(sum);
        }
        else
        {
            Add(v, sum);
        }
    }

    private void Add(Value v, float sum)
    {
        valueList.Add(new ValueFloatReference(v, sum));
    }
    private void Add(Value v, int sum)
    {
        valueList.Add(new ValueIntReference(v, sum));
    }
}



public class Character : MonoBehaviour
{
    public ValueStructure statsStructure;
    public StatsContainer statsContainer;
    
    // Start is called before the first frame update
    void Start()
    {
        Init();  
    }

    void Init()
    {
        statsContainer = new StatsContainer();
        for (int i = 0; i < statsStructure.values.Count; i++)
        {
            if (statsStructure.values[i] is ValueFloat)
            {
                statsContainer.valueList.Add(new ValueFloatReference(statsStructure.values[i], 0f));
            }
            if (statsStructure.values[i] is ValueInt)
            {
                statsContainer.valueList.Add(new ValueIntReference(statsStructure.values[i], 0));
            }
        }
    }

    // Update is called once per frame
    public Value testReferenceValue;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.X))
        {
            statsContainer.Sum(testReferenceValue, 1);
        }
    }
}
