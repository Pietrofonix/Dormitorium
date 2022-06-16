using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SoundManagerScript : MonoBehaviour
{
    //public static AudioClip door;
    //public static AudioSource audioSrc;
    public static SoundManagerScript instance;
    public AudioSource MusicSource, SFXOneShotSource, SFXLongSource;
    AudioClip door, footsteps, key, crowbar, paper, button;
    GameObject m_musicVolumeSlider;
    GameObject m_sfxVolumeSlider;
    public GameObject m_settingsScreen;
    public Slider m_musicVolumeSliderPause;
    public Slider m_sfxVolumeSliderPause;
    public static bool BackToMenu;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        if (SceneManager.GetActiveScene().name == "MainMenu")
        {
            m_musicVolumeSlider = GameObject.FindGameObjectWithTag("MainMusicSlider");
            m_sfxVolumeSlider = GameObject.FindGameObjectWithTag("MainSFXSlider");
            m_settingsScreen = GameObject.FindGameObjectWithTag("SettingsScreen");
            m_settingsScreen.SetActive(false);

        }
    }

    void Start()
    {
        footsteps = Resources.Load<AudioClip>("Footsteps");
        door = Resources.Load<AudioClip>("Door");
        key = Resources.Load<AudioClip>("Keys");
        crowbar = Resources.Load<AudioClip>("Crowbar");
        paper = Resources.Load<AudioClip>("Paper");
        button = Resources.Load<AudioClip>("Button");

        //audioSrc = GetComponent<AudioSource>();

        if (!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            Load();
        }
        else
        {
            Load();
        }

        if (!PlayerPrefs.HasKey("sfxVolume"))
        {
            PlayerPrefs.SetFloat("sfxVolume", 1);
            Load();
        }
        else
        {
            Load();
        }
    }

    void Update()
    {
        Debug.Log("BackToMenu: " + BackToMenu);

        if (SceneManager.GetActiveScene().name == "MainMenu" && BackToMenu)
        {
            m_musicVolumeSlider = GameObject.FindGameObjectWithTag("MainMusicSlider");
            m_sfxVolumeSlider = GameObject.FindGameObjectWithTag("MainSFXSlider");
            m_settingsScreen = GameObject.FindGameObjectWithTag("SettingsScreen");
            m_musicVolumeSlider.GetComponent<Slider>().value = PlayerPrefs.GetFloat("musicVolume");
            m_sfxVolumeSlider.GetComponent<Slider>().value = PlayerPrefs.GetFloat("sfxVolume");
            m_settingsScreen.SetActive(false);
            BackToMenu = false;
        }

        /*if (BackToMenu)
        {
            m_settingsScreen = GameObject.FindGameObjectWithTag("SettingsScreen");
            m_settingsScreen.SetActive(false);
            BackToMenu = false;
        }*/
    }

    public void PlaySFX(string clip)
    {
        switch (clip)
        {
            case "Door":
                SFXOneShotSource.PlayOneShot(door);
                break;
            case "Key":
                SFXOneShotSource.PlayOneShot(key);
                break;
            case "Crowbar":
                SFXOneShotSource.PlayOneShot(crowbar);
                break;
            case "Paper":
                SFXOneShotSource.PlayOneShot(paper);
                break;
            case "Button":
                SFXOneShotSource.PlayOneShot(button);
                break;
            case "Footsteps":
                SFXLongSource.clip = footsteps;
                SFXLongSource.Play();
                SFXLongSource.loop = true;
                break;
        }
    }

    public void PlayMusic(AudioClip music)
    {
        MusicSource.clip = music;
        MusicSource.Play();
    }

    public void ChangeMusicVolume()
    {
        if (SceneManager.GetActiveScene().name == "MainMenu")
        {
            MusicSource.volume = m_musicVolumeSlider.GetComponent<Slider>().value;
        }
        else
        {
            MusicSource.volume = m_musicVolumeSliderPause.value;
        }

        Save();
    }

    public void ChangeSFXVolume()
    {
        if (SceneManager.GetActiveScene().name == "MainMenu")
        {
            SFXLongSource.volume = m_sfxVolumeSlider.GetComponent<Slider>().value;
            SFXOneShotSource.volume = m_sfxVolumeSlider.GetComponent<Slider>().value;
        }
        else
        {
            SFXLongSource.volume= m_sfxVolumeSliderPause.value;
            SFXOneShotSource.volume = m_sfxVolumeSliderPause.value;
        }

        Save();
    }

    void Load()
    {
        if (SceneManager.GetActiveScene().name == "MainMenu")
        {
            m_musicVolumeSlider.GetComponent<Slider>().value = PlayerPrefs.GetFloat("musicVolume");
            m_sfxVolumeSlider.GetComponent<Slider>().value = PlayerPrefs.GetFloat("sfxVolume");
        }
        else
        {
            m_musicVolumeSliderPause.value = PlayerPrefs.GetFloat("musicVolume");
            m_sfxVolumeSliderPause.value = PlayerPrefs.GetFloat("sfxVolume");
        }
    }

    void Save()
    {
        if (SceneManager.GetActiveScene().name == "MainMenu")
        {
            PlayerPrefs.SetFloat("musicVolume", m_musicVolumeSlider.GetComponent<Slider>().value);
            PlayerPrefs.SetFloat("sfxVolume", m_sfxVolumeSlider.GetComponent<Slider>().value);
        }
        else
        {
            PlayerPrefs.SetFloat("musicVolume", m_musicVolumeSliderPause.value);
            PlayerPrefs.SetFloat("sfxVolume", m_sfxVolumeSliderPause.value);
        }
    }

    
}
