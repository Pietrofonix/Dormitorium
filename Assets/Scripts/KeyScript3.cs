using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript3 : MonoBehaviour
{
    void Start()
    {
        if(Inventory.key3)
        {
            Destroy(gameObject);
        }
    }
}
