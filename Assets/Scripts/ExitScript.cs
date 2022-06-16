using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitScript : MonoBehaviour
{
    BoxCollider2D m_boxCollider;
    [SerializeField] GameObject m_exitDoorText;

    void Start()
    {
        m_boxCollider = GetComponent<BoxCollider2D>();    
    }

    void Update()
    {
        if (Inventory.key3)
        {
            m_boxCollider.isTrigger = true;
            m_exitDoorText.SetActive(false);
        }
    }
}
