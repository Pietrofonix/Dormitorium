using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void RestartGame()
    {
        Inventory.key = false;
        Inventory.key2 = false;
        Inventory.key3 = false;
        Inventory.crowbar = false;
        Inventory.safecode = false;
        SceneController.SafeOpened = false;
        Time.timeScale = 1.0f;
        SceneController.GameStarted = true;
        TimerManager.Instance.m_startTimer = false;
        TimerManager.Instance.m_timer = 60f;
        SoundManagerScript.instance.m_musicVolumeSliderPause.value = PlayerPrefs.GetFloat("musicVolume");
        SoundManagerScript.instance.m_sfxVolumeSliderPause.value = PlayerPrefs.GetFloat("sfxVolume");
        SceneController.Flames.Clear();
        SceneManager.LoadSceneAsync("000");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
