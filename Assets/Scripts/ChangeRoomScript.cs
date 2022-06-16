using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeRoomScript : MonoBehaviour
{
    public string scene;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            /*string currentScene = SceneManager.GetActiveScene().name;
            PlayerPrefs.SetString("LastScene", currentScene);
            PlayerPrefs.Save();*/

            //SoundManagerScript.PlaySound("Door");
            SoundManagerScript.instance.PlaySFX("Door");
            Debug.Log(SceneManager.GetActiveScene().name);
            InOutScript.lastScene = SceneManager.GetActiveScene().name;
            Debug.Log(InOutScript.lastScene);
            SceneManager.LoadSceneAsync(scene);
            
        }
    }
}
