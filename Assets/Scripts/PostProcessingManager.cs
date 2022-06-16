using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;

public class PostProcessingManager : MonoBehaviour
{
    public static PostProcessingManager Instance;
    public Volume volume;
    Vignette vignette;
    private float vignetteIntensity;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }

    void Start()
    {
        volume.profile.TryGet<Vignette>(out vignette);
        vignette.intensity.value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "000")
        {
            vignette.intensity.value = 0;
        }

        if(TimerManager.Instance.m_startTimer)
        {
            vignetteIntensity = Mathf.Lerp(1, 0,  TimerManager.Instance.m_timer/60);
            vignette.intensity.value = vignetteIntensity;
        }
    }
}
