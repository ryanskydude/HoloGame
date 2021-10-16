using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject PauseOptionMenu;
    public Settingsmenu SettingsCheck;
    public GameObject pauseMenuUI;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(SettingsCheck.isSettingsOn == false)
            {
                if (GameIsPaused)
                {
                    Resume();
                }
                else
                {
                    Pause();
                }
            }
        }
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void LoadMenu()
    {
        Debug.Log("loading settings...");
        pauseMenuUI.SetActive(false);
        PauseOptionMenu.SetActive(true);
        SettingsCheck.isSettingsOn = true;
    }
    public void QuitGame()
    {
        Debug.Log("Quitting to Main Menu... :-(");
        SceneManager.LoadScene("MenuScene");
        Time.timeScale = 1f;
    }
}
