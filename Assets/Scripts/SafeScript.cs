using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SafeScript : MonoBehaviour
{
    SpriteRenderer m_spriteRenderer;
    [SerializeField] Sprite m_sprite;
    [SerializeField] GameObject m_safeTrigger;
    [SerializeField] BoxCollider2D m_triggerBox;
    [SerializeField] GameObject m_exitKey;
    bool m_canOpen;
    //bool m_opened;
     
    void Start()
    {
        m_spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Inventory.safecode && !SceneController.SafeOpened)
        {
            m_triggerBox.enabled = true;
            m_safeTrigger.SetActive(false);
        }
        else
        {
            m_triggerBox.enabled = false;
        }

        if (m_canOpen && Input.GetKeyDown(KeyCode.E) && !Inventory.key3)
        {
            ChangeSafeSprite();
            m_exitKey.SetActive(true);
        }
        else if (!Inventory.key3 && SceneController.SafeOpened)
        {
            m_exitKey.SetActive(true);
        }

        if (SceneController.SafeOpened)
        {
            m_spriteRenderer.sprite = m_sprite;
            m_safeTrigger.SetActive(false);
        }
    }

    void ChangeSafeSprite()
    {
        m_spriteRenderer.sprite = m_sprite;
        SceneController.SafeOpened = true;
    }

    /*void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && Input.GetKeyDown(KeyCode.E) && Inventory.safecode && !m_opened)
        {
            m_opened = true;
            m_exitKey.SetActive(true);
            ChangeSafeSprite();
        }
    }*/

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && Inventory.safecode && !SceneController.SafeOpened)
        {
            m_canOpen = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && Inventory.safecode && !SceneController.SafeOpened)
        {
            m_canOpen = false;
        }
    }
}
