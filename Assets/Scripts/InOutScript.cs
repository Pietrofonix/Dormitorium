using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InOutScript : MonoBehaviour
{
    public Transform player;
    public Animator playerAnim;
    public static string lastScene = "";

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(lastScene + " InOutScript");
        //string lastScene = PlayerPrefs.GetString("LastScene", null);

        if (lastScene != "")
        {
            if (lastScene == "000")
            {
                if (SceneManager.GetActiveScene().name == "UpHallway")
                {
                    TimerManager.Instance.m_startTimer = true;
                    player.position = new Vector2(-14f, 74.0f);
                    playerAnim.Play("IdleFront");
                }
            }

            if (lastScene == "Stanza1")
            {
                if (SceneManager.GetActiveScene().name == "UpHallway")
                {
                    TimerManager.Instance.m_startTimer = true;
                    player.position = new Vector2(-14f, 74.0f);
                    playerAnim.Play("IdleFront");
                }
            }

            if (lastScene == "Stanza2")
            {
                if (SceneManager.GetActiveScene().name == "UpHallway")
                {
                    player.position = new Vector2(-14f, -26.0f);
                    playerAnim.Play("IdleUp");
                }  
            }

            if (lastScene == "Stanza3")
            {
                if (SceneManager.GetActiveScene().name == "UpHallway")
                {
                    player.position = new Vector2(178f, 78.0f);
                    playerAnim.Play("IdleFront");
                }
            }

            if (lastScene == "Stanza4")
            {
                if (SceneManager.GetActiveScene().name == "UpHallway")
                {
                    player.position = new Vector2(178.0f, -26.0f);
                    playerAnim.Play("IdleUp");
                }
            }

            if (lastScene == "Stanza5")
            {
                if (SceneManager.GetActiveScene().name == "UpHallway")
                {
                    player.position = new Vector2(-14f, 490.0f);
                    playerAnim.Play("IdleFront");
                }
            }

            if (lastScene == "Stanza6")
            {
                if (SceneManager.GetActiveScene().name == "UpHallway")
                {
                    player.position = new Vector2(-14f, 388.0f);
                    playerAnim.Play("IdleUp");
                }
            }

            if (lastScene == "Stanza7")
            {
                if (SceneManager.GetActiveScene().name == "UpHallway")
                {
                    player.position = new Vector2(178f, 490.0f);
                    playerAnim.Play("IdleFront");
                }
            }

            if (lastScene == "Stanza8")
            {
                if (SceneManager.GetActiveScene().name == "UpHallway")
                {
                    player.position = new Vector2(178.0f, 388.0f);
                    playerAnim.Play("IdleUp");
                }
            }

            if (lastScene == "UpHallway")
            {
                if(SceneManager.GetActiveScene().name == "Stanza1")
                {
                    player.position = new Vector2(48.0f, -67.0f);
                    playerAnim.Play("IdleUp");
                }      
            }

            if (lastScene == "UpHallway")
            {
                if (SceneManager.GetActiveScene().name == "Stanza2")
                {
                    player.position = new Vector2(50.0f, 78.0f);
                    playerAnim.Play("IdleFront");
                }
            }

            if (lastScene == "UpHallway")
            {
                if (SceneManager.GetActiveScene().name == "Stanza3")
                {
                    player.position = new Vector2(-79.0f, -70.0f);
                    playerAnim.Play("IdleUp");
                }
            }

            if (lastScene == "UpHallway")
            {
                if (SceneManager.GetActiveScene().name == "Stanza4")
                {
                    player.position = new Vector2(-78.0f, 80.0f);
                    playerAnim.Play("IdleFront");
                }
            }

            if (lastScene == "UpHallway")
            {
                if (SceneManager.GetActiveScene().name == "Stanza5")
                {
                    player.position = new Vector2(48.0f, -67.0f);
                    playerAnim.Play("IdleUp");
                }
            }

            if (lastScene == "UpHallway")
            {
                if (SceneManager.GetActiveScene().name == "Stanza6")
                {
                    player.position = new Vector2(50.0f, 78.0f);
                    playerAnim.Play("IdleFront");
                }
            }

            if (lastScene == "UpHallway")
            {
                if (SceneManager.GetActiveScene().name == "Stanza7")
                {
                    player.position = new Vector2(-79.0f, -70.0f);
                    playerAnim.Play("IdleUp");
                }
            }

            if (lastScene == "UpHallway")
            {
                if (SceneManager.GetActiveScene().name == "Stanza8")
                {
                    player.position = new Vector2(-78.0f, 80.0f);
                    playerAnim.Play("IdleFront");
                }
            }

            if (lastScene == "UpHallway")
            {
                if (SceneManager.GetActiveScene().name == "BagnoSopraSX")
                {
                    player.position = new Vector2(-80.0f, 18.0f);
                    playerAnim.Play("IdleRight");
                    player.rotation = Quaternion.Euler(Vector2.up * 180);
                }
            }

            if (lastScene == "UpHallway")
            {
                if (SceneManager.GetActiveScene().name == "BagnoSopraSX 1")
                {
                    player.position = new Vector2(-80.0f, 18.0f);
                    playerAnim.Play("IdleRight");
                    player.rotation = Quaternion.Euler(Vector2.up * 180);
                }
            }

            if (lastScene == "UpHallway")
            {
                if (SceneManager.GetActiveScene().name == "BagnoSopraDX")
                {
                    player.position = new Vector2(-300.0f, 19.0f);
                    playerAnim.Play("IdleRight");
                }
            }

            if (lastScene == "UpHallway")
            {
                if (SceneManager.GetActiveScene().name == "BagnoSopraDX 1")
                {
                    player.position = new Vector2(-300.0f, 19.0f);
                    playerAnim.Play("IdleRight");
                }
            }

            if (lastScene == "BagnoSopraDX 1")
            {
                if (SceneManager.GetActiveScene().name == "UpHallway")
                {
                    player.position = new Vector2(237.0f, 436.0f);
                    playerAnim.Play("IdleRight");
                    player.rotation = Quaternion.Euler(Vector2.up * 180);
                }
            }

            if (lastScene == "BagnoSopraDX")
            {
                if (SceneManager.GetActiveScene().name == "UpHallway")
                {
                    player.position = new Vector2(237.0f, 19.0f);
                    playerAnim.Play("IdleRight");
                    player.rotation = Quaternion.Euler(Vector2.up * 180);
                }
            }

            if (lastScene == "BagnoSopraSX 1")
            {
                if (SceneManager.GetActiveScene().name == "UpHallway")
                {
                    player.position = new Vector2(-66.0f, 436.0f);
                    playerAnim.Play("IdleRight");
                    
                }
            }

            if (lastScene == "BagnoSopraSX")
            {
                if (SceneManager.GetActiveScene().name == "UpHallway")
                {
                    player.position = new Vector2(-66.0f, 19.0f);
                    playerAnim.Play("IdleRight");           
                }
            }

            if (lastScene == "Dispensa")
            {
                if (SceneManager.GetActiveScene().name == "Piano_terra")
                {
                    player.position = new Vector2(90.0f, 84.0f);
                    playerAnim.Play("IdleRight");
                }
            }

            if (lastScene == "BagnoPianoTerra")
            {
                if (SceneManager.GetActiveScene().name == "Piano_terra")
                {
                    player.position = new Vector2(90.0f, 340.0f);
                    playerAnim.Play("IdleRight");
                }
            }

            if (lastScene == "Mensa")
            {
                if (SceneManager.GetActiveScene().name == "Piano_terra")
                {
                    player.position = new Vector2(206.0f, 210.0f);
                    playerAnim.Play("IdleRight");
                    player.rotation = Quaternion.Euler(Vector2.up * 180);
                }
            }

            if (lastScene == "SalaRiunioni")
            {
                if (SceneManager.GetActiveScene().name == "Piano_terra")
                {
                    player.position = new Vector2(90.0f, 851.0f);
                    playerAnim.Play("IdleRight");
                    
                }
            }

            if (lastScene == "Segreteria")
            {
                if (SceneManager.GetActiveScene().name == "Piano_terra")
                {
                    player.position = new Vector2(546.0f, 721.0f);
                    playerAnim.Play("IdleFront");

                }
            }

            if (lastScene == "Mensa")
            {
                if (SceneManager.GetActiveScene().name == "Cucina")
                {
                    player.position = new Vector2(-300.0f, -54.0f);
                    playerAnim.Play("IdleRight");
                    player.rotation = Quaternion.Euler(Vector2.up * 180);
                }
            }

            if (lastScene == "Cucina")
            {
                if (SceneManager.GetActiveScene().name == "Mensa")
                {
                    player.position = new Vector2(-180.0f, -218.0f);
                    playerAnim.Play("IdleRight");

                }
            }

            if (lastScene == "Piano_terra")
            {
                if (SceneManager.GetActiveScene().name == "Dispensa")
                {
                    player.position = new Vector2(-23.0f, -43.0f);
                    playerAnim.Play("IdleRight");
                    player.rotation = Quaternion.Euler(Vector2.up * 180);
                }
            }

            if (lastScene == "Piano_terra")
            {
                if (SceneManager.GetActiveScene().name == "BagnoPianoTerra")
                {
                    player.position = new Vector2(-23.0f, -43.0f);
                    playerAnim.Play("IdleRight");
                    player.rotation = Quaternion.Euler(Vector2.up * 180);
                }
            }

            if (lastScene == "Piano_terra")
            {
                if (SceneManager.GetActiveScene().name == "SalaRiunioni")
                {
                    player.position = new Vector2(-115.0f, -13.0f);
                    playerAnim.Play("IdleRight");
                    player.rotation = Quaternion.Euler(Vector2.up * 180);
                }
            }

            if (lastScene == "Piano_terra")
            {
                if (SceneManager.GetActiveScene().name == "Segreteria")
                {
                    player.position = new Vector2(-194.0f, -101.0f);
                    playerAnim.Play("IdleUp");        
                }
            }

            //Debug.Log(lastScene);

            if (lastScene == "Piano_terra")
            {
                if (SceneManager.GetActiveScene().name == "Mensa")
                {
                    player.position = new Vector2(-300.0f, -45.0f);
                    playerAnim.Play("IdleRight");
                    Debug.Log("Sono in mensa");                    
                }
                Debug.Log("Sono al Piano_terra");
            }

            if(lastScene == "UpHallway")
            {
                if (SceneManager.GetActiveScene().name == "Piano_terra")
                {
                    player.position = new Vector2(-177.0f, -52.0f);
                    playerAnim.Play("IdleRight");
                }
            }

            if (lastScene == "Piano_terra")
            {
                if (SceneManager.GetActiveScene().name == "UpHallway")
                {
                    player.position = new Vector2(305.0f, -347.0f);
                    playerAnim.Play("IdleRight");
                }
            }         
        } 
        else
        {
            playerAnim.Play("IdleFront");
        }
    }
}
