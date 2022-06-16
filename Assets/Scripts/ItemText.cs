using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemText : MonoBehaviour
{
    [TextArea(10, 150)]
    public string Sentence;
    [SerializeField] int m_cps;
    [SerializeField] TMP_Text m_text;
    float m_timer = 1f;
    bool m_type;
    bool m_typing;
    int m_index;

    void Start()
    {
        m_typing = true;
        m_type = true;
    }

    void Update()
    {
        if (m_typing)
        {
            TypeWriting();
        }
    }

    void TypeWriting()
    {
        m_timer -= Time.deltaTime * m_cps;

        if (m_timer <= 0 && m_type)
        {
            m_text.text += Sentence[m_index];
            m_index++;
            m_timer = 1f;
        }

        if (m_index >= Sentence.Length)
        {
            m_type = false;
            m_timer = 0f;
            m_typing = false;
        }
    }
}
