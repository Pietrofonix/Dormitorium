using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (Inventory.key)
        {
            Destroy(gameObject);
        }
    }
}
