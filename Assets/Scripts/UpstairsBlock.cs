using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpstairsBlock : MonoBehaviour
{
    BoxCollider2D m_BoxCollider2D;
    [SerializeField] GameObject m_key2text;

    void Start()
    {
        m_BoxCollider2D = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        if (Inventory.key2)
        {
            m_BoxCollider2D.isTrigger = true;
            m_key2text.SetActive(false);
        }
    }
}
