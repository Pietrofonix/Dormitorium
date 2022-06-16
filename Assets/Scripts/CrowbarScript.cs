using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowbarScript : MonoBehaviour
{
    void Start()
    {
        if (Inventory.crowbar)
        {
            Destroy(gameObject);
        }
    }
}
