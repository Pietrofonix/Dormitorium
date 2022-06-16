using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    public void BackToMenu()
    {
        SoundManagerScript.BackToMenu = true;
        SceneManager.LoadSceneAsync("MainMenu");
    }

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
        SceneController.Flames.Clear();
        SceneManager.LoadScene("000");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
