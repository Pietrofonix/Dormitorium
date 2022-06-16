using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameScript : MonoBehaviour
{
    [SerializeField] int m_flameNumber;

    void Start()
    {
        if (SceneController.Flames.Contains(m_flameNumber))
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            TimerManager.Instance.m_timer += 30f;

            if (TimerManager.Instance.m_timer >= 60f)
            {
                TimerManager.Instance.m_timer = 60f;
            }

            SceneController.AddFlame(m_flameNumber);
            Destroy(gameObject);
        }
    }
}
