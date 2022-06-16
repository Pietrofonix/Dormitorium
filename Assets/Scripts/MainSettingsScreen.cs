using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSettingsScreen : MonoBehaviour
{
    public GameObject SettingsScreen;

    void Awake()
    {
        if (SoundManagerScript.BackToMenu)
            SettingsScreen.SetActive(true);
    }
}
