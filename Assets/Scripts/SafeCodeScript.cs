using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeCodeScript : MonoBehaviour
{
    void Start()
    {
        if(Inventory.safecode)
        {
            Destroy(gameObject);
        }
    }
}
