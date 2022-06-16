using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stanza1Trigger : MonoBehaviour
{
    Collider2D m_coll;

    // Start is called before the first frame update
    void Start()
    {
        m_coll = GetComponent<Collider2D>();

        if(Inventory.key)
        {
            m_coll.isTrigger = true;
        }
    }
}
