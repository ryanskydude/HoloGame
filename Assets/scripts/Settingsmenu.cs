using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Settingsmenu : MonoBehaviour
{

    public AudioMixer audioMixer;
    public GameObject MainMenu;
    public GameObject OptionsMenu;
    public bool isSettingsOn = false;
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("Volume", volume);
    }
    public void SetQuality (int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }
    public void backButton()
    {
        MainMenu.SetActive(true);
        OptionsMenu.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OptionsMenu.SetActive(false);
            MainMenu.SetActive(true);
            isSettingsOn = false;
        }
    }
}
