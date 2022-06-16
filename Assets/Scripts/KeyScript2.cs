using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript2 : MonoBehaviour
{
    void Start()
    {
        if(Inventory.key2)
        {
            Destroy(gameObject);
        }
    }
}
