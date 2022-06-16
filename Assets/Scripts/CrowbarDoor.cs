using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowbarDoor : MonoBehaviour
{
    BoxCollider2D m_BoxCollider2D;
    [SerializeField] GameObject m_crowbarDoortext;

    void Start()
    {
        m_BoxCollider2D = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        if (Inventory.crowbar)
        {
            m_BoxCollider2D.isTrigger = true;
            m_crowbarDoortext.SetActive(false);
        }
    }
}
