using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainSFXSlidersScript : MonoBehaviour
{
    Slider m_slider;

    void Awake()
    {
        m_slider = GetComponent<Slider>();
        m_slider.onValueChanged.AddListener(delegate { SetSFXVolume(); });
    }

    void SetSFXVolume()
    {
        SoundManagerScript.instance.SFXLongSource.volume = m_slider.value;
        SoundManagerScript.instance.SFXOneShotSource.volume = m_slider.value;
    }
}
