using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TimerManager : MonoBehaviour
{
    public static TimerManager Instance;

    public Canvas canvas;
    public GameObject timeOnScreen;
    public float m_timer;
    public bool m_startTimer = false;

    // Start is called before the first frame update
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(canvas);
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.T))
        {
            m_startTimer = true;
        }*/

        if (SceneManager.GetActiveScene().name == "GameOver" || SceneManager.GetActiveScene().name == "Victory"
            || SceneManager.GetActiveScene().name == "MainMenu" || SceneManager.GetActiveScene().name == "000")
        {
            m_startTimer = false;
            m_timer = 60f;
            timeOnScreen.GetComponent<TextMeshProUGUI>().text = "";
        }

            if (m_startTimer)
        {
            m_timer -= Time.deltaTime;

            //timeOnScreen.GetComponent<TextMeshProUGUI>().text = Mathf.Ceil(m_timer).ToString("000");
            timeOnScreen.GetComponent<TextMeshProUGUI>().text =  Mathf.Floor(m_timer / 60).ToString("00") + ":" + Mathf.FloorToInt(m_timer % 60).ToString("00");

            if (m_timer <= 0.0f)
            {
                m_startTimer = false;
                SceneManager.LoadSceneAsync("GameOver");
                //timeOnScreen.GetComponent<TextMeshProUGUI>().color = Color.white;
                //timeOnScreen.GetComponent<TextMeshProUGUI>().text = "Time is over";
                timeOnScreen.GetComponent<TextMeshProUGUI>().text = "";
            }
            else
            {

                if (m_timer > 30.9f)
                {
                    timeOnScreen.GetComponent<TextMeshProUGUI>().color = Color.green;

                }
                else if (m_timer <= 30.9f && m_timer > 10.9f)
                {
                    timeOnScreen.GetComponent<TextMeshProUGUI>().color = Color.yellow;

                }
                else if (m_timer <= 10.9f)
                {
                    timeOnScreen.GetComponent<TextMeshProUGUI>().color = Color.red;
                }

                //timeOnScreen.GetComponent<TextMeshProUGUI>().text = "Time: " + Mathf.Ceil(m_timer).ToString("000");
                //timeOnScreen.GetComponent<TextMeshProUGUI>().text = Mathf.Floor(m_timer / 60).ToString("00") + ":" + Mathf.FloorToInt(m_timer % 60).ToString("00");

            }
        }


    }
}
