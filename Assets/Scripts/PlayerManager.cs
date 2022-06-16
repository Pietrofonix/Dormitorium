using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    /*bool m_left = false;
    bool m_right = false;
    bool m_down = false;
    bool m_up = false;*/
    bool m_isWalking = false;

    bool m_lastUp = false;
    bool m_lastDown = false;
    bool m_lastRight = false;
    bool m_lastLeft = false;

    Animator m_anim;
    AudioSource m_audioSrc;
    Rigidbody2D m_rigidbody2D;

    public float playerSpeed = 5.0f;
    float xMov;
    float yMov;
    Vector2 m_moveDir;

    // Start is called before the first frame update
    void Start()
    {
        //m_audioSrc = GetComponent<AudioSource>();
        m_rigidbody2D = GetComponent<Rigidbody2D>();
        m_anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        /*m_left = Input.GetKey(KeyCode.LeftArrow);
        m_right = Input.GetKey(KeyCode.RightArrow);
        m_down = Input.GetKey(KeyCode.DownArrow);
        m_up = Input.GetKey(KeyCode.UpArrow);*/
        PlayFootsteps();
    }

    void FixedUpdate()
    {
        xMov = Input.GetAxisRaw("Horizontal");
        yMov = Input.GetAxisRaw("Vertical");
        m_moveDir = new Vector2(xMov, yMov);
        //m_moveDir.Normalize();

        //Debug.Log(m_moveDir);

        if (/*m_left || m_right || m_up || m_down*/
            m_moveDir != Vector2.zero)
        {
            m_isWalking = true;

            if (m_moveDir.x < 0f)
            {
                m_rigidbody2D.velocity = new Vector2(m_moveDir.x * playerSpeed, 0.0f);
                m_anim.Play("WalkHorizontal");
                transform.rotation = Quaternion.Euler(Vector2.up * 180);
                m_lastLeft = true;
                m_lastRight = false;
                m_lastUp = false;
                m_lastDown = false;
            }
            else if (m_moveDir.x > 0f)
            {
                m_rigidbody2D.velocity = new Vector2(m_moveDir.x * playerSpeed, 0.0f);
                m_anim.Play("WalkHorizontal");
                transform.rotation = Quaternion.Euler(Vector2.up * 0);
                m_lastRight = true;
                m_lastLeft = false;
                m_lastUp = false;
                m_lastDown = false;
            }
            else if (m_moveDir.y > 0f)
            {
                m_rigidbody2D.velocity = new Vector2(0.0f, m_moveDir.y * playerSpeed);
                m_anim.Play("WalkUp");
                m_lastUp = true;
                m_lastRight = false;
                m_lastLeft = false;
                m_lastDown = false;
            }           
            else if (m_moveDir.y < 0f)
            {
                m_rigidbody2D.velocity = new Vector2(0.0f, m_moveDir.y * playerSpeed);
                m_anim.Play("WalkDown");
                m_lastDown = true;
                m_lastUp = false;
                m_lastRight = false;
                m_lastLeft = false;
            }          
        }
        else
        {
            m_isWalking = false;
            m_rigidbody2D.velocity = Vector2.zero;

            if (m_lastUp)
            {
                m_anim.Play("IdleUp");
            }
            else if (m_lastDown)
            {
                m_anim.Play("IdleFront");

            }
            else if (m_lastRight)
            {
                m_anim.Play("IdleRight");
            }
            else if (m_lastLeft)
            {
                m_anim.Play("IdleRight");
            }
        }
    }

    void PlayFootsteps()
    {
        if (m_isWalking)
        {
            if (!SoundManagerScript.instance.SFXLongSource.isPlaying)
            {
                SoundManagerScript.instance.PlaySFX("Footsteps");
            }
        }
        else
        {
            SoundManagerScript.instance.SFXLongSource.Stop();
        }
    }
}
