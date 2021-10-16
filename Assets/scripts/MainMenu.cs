using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Discord;

public class MainMenu : MonoBehaviour
{
    public GameObject Mainmenu;
    public GameObject Optionsmenu;
    public bool isGameQuitting = false;
    public void QuitGame()
    {
        Debug.Log("Stopping Discord Rich Presense");
        isGameQuitting = true;
        Debug.Log("Quitting Game! Goodbye!");
        Application.Quit();
    }

    public void LoadSettings()
    {
        Debug.Log("loading settings...");
        Mainmenu.SetActive(false);
        Optionsmenu.SetActive(true);
    }
    public void Loadlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
