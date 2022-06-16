using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static bool safecode = false;
    public static bool crowbar = false;
    public static bool key = false;
    public static bool key2 = false;
    public static bool key3 = false; 

    public void AddSafeCode()
    {
        SoundManagerScript.instance.PlaySFX("Paper");
        safecode = true;
    }

    public void AddCrowbar()
    {
        SoundManagerScript.instance.PlaySFX("Crowbar");
        crowbar = true;
    }

    public void AddKey()
    {
        SoundManagerScript.instance.PlaySFX("Key");
        key = true;
    }

    public void AddKey2()
    {
        SoundManagerScript.instance.PlaySFX("Key");
        key2 = true;
    }

    public void AddKey3()
    {
        SoundManagerScript.instance.PlaySFX("Key");
        key3 = true;
    }

}
