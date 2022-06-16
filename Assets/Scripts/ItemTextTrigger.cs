using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTextTrigger : MonoBehaviour
{
    [SerializeField] GameObject m_itemText;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            m_itemText.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            m_itemText.SetActive(false);
        }
    }
}
