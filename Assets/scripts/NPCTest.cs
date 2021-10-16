using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCTest : MonoBehaviour
{
    public GameObject NPCInteract;
    public GameObject NPCSpeech;
    // Start is called before the first frame update
    void Start()
    {
        NPCInteract.SetActive(false);
        NPCSpeech.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider Player)
    {
        NPCInteract.SetActive(true);

    }
    private void OnTriggerStay(Collider Player)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            NPCInteract.SetActive(false);
            NPCSpeech.SetActive(true);
            Debug.Log("E is pressed?");
        }
    }
    private void OnTriggerExit(Collider Player)
    {
        NPCInteract.SetActive(false);
        NPCSpeech.SetActive(false);
    }
}
