using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RunAway : MonoBehaviour
{
    public GameObject FightUi;
    public GameObject RunAwayConfirmUi;
    public void RunawayConfirm()
    {
        FightUi.SetActive(false);
        RunAwayConfirmUi.SetActive(true);
    }

    public void RunAwayYes()
    {
        SceneManager.LoadScene(1);
    }

    public void RunAwayNo()
    {
        RunAwayConfirmUi.SetActive(false);
        FightUi.SetActive(true);                                                             
    }
}
