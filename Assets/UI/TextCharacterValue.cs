using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextCharacterValue : MonoBehaviour
{
    public Value trackValue;
    public Character character;

    void updateText()
    {
        string str = character.statsContainer.GetText(trackValue);
        GetComponent<Text>().text = str;
    }
    // Start is called before the first frame update
    void Start()
    {
        character.statsContainer.Subscribe(updateText, trackValue);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
