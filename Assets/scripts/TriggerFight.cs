using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFight : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool startFight = false;
    public GameObject battletext;
    void Start()
    {
        battletext.SetActive(false);
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            Time.timeScale = 0;
            battletext.SetActive(true);
            StartCoroutine("WaitForSec");
        }
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSecondsRealtime(2);
        Time.timeScale = 1;
        battletext.SetActive(false);
        startFight = true;
    }
}
