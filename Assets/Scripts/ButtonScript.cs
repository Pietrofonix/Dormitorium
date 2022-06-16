using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonScript : MonoBehaviour, IPointerEnterHandler
{
    GameObject m_soundManagerScript;

    void Awake()
    {
        m_soundManagerScript = GameObject.FindGameObjectWithTag("SoundManager");
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        m_soundManagerScript.GetComponent<SoundManagerScript>().PlaySFX("Button");
    }
}
