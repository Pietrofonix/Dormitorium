using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMusicSlidersScript : MonoBehaviour
{
    Slider m_slider;

    void Awake()
    {
        m_slider = GetComponent<Slider>();
        m_slider.onValueChanged.AddListener(delegate { SetMusicVolume(); });
    }

    void SetMusicVolume()
    {
        SoundManagerScript.instance.MusicSource.volume = m_slider.value;
    }
}
