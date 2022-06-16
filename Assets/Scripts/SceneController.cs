using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [SerializeField] GameObject m_pauseCanvas;
    public static SceneController Instance;
    public static bool GameStarted;
    public static bool SafeOpened;
    public static bool CanPause;
    public static List<int> Flames = new();

    void Awake()
    {
        Application.targetFrameRate = 60;

        GameStarted = false;

        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else 
        {
            Destroy(gameObject);
        }
    }

    public void StartGame()
    {
        Inventory.key = false;
        Inventory.key2 = false;
        Inventory.key3 = false;
        Inventory.crowbar = false;
        Inventory.safecode = false;
        GameStarted = true;
        Time.timeScale = 1.0f;
        TimerManager.Instance.m_startTimer = false;
        TimerManager.Instance.m_timer = 60f;
        Flames.Clear();
        /*SoundManagerScript.instance.m_musicVolumeSliderPause.value = SoundManagerScript.instance.m_musicVolumeSlider.value;
        SoundManagerScript.instance.m_sfxVolumeSliderPause.value = SoundManagerScript.instance.m_sfxVolumeSlider.value;*/
        SoundManagerScript.instance.m_musicVolumeSliderPause.value = PlayerPrefs.GetFloat("musicVolume");
        SoundManagerScript.instance.m_sfxVolumeSliderPause.value = PlayerPrefs.GetFloat("sfxVolume");
        SceneManager.LoadSceneAsync("000");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void BackToMenu()
    {
        SoundManagerScript.BackToMenu = true;
        m_pauseCanvas.SetActive(false);
        SceneManager.LoadSceneAsync("MainMenu");
    }

    public void ResumeGame()
    {
        m_pauseCanvas.SetActive(false);
        Time.timeScale = 1.0f;
    }

    void Update()
    {
        Debug.Log(CanPause);

        if (Input.GetKeyDown(KeyCode.Escape) && !m_pauseCanvas.activeInHierarchy && CanPause)
        {
            m_pauseCanvas.SetActive(true);
            Time.timeScale = 0f;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && m_pauseCanvas.activeInHierarchy)
        {
            m_pauseCanvas.SetActive(false);
            Time.timeScale = 1.0f;
        }

        if (SceneManager.GetActiveScene().name == "GameOver" || SceneManager.GetActiveScene().name == "Victory"
            || SceneManager.GetActiveScene().name == "MainMenu")
        {
            SoundManagerScript.instance.SFXLongSource.Stop();
            //SoundManagerScript.instance.SFXOneShotSource.Stop();
            CanPause = false;
        }
        else
        {
            CanPause = true;
        }

        //Debug.Log(Flames.Count);
    }

    public static void AddFlame(int flame)
    {
        Flames.Add(flame);
    }
}
