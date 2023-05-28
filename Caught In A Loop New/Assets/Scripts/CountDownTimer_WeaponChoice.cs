using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class CountDownTimer : MonoBehaviour
{
    public Slider SliderToUse;
    public Text textToChange;
    public double targetTime;
    [SerializeField] private VideoClip[] videoClips;
    private ParticleSystem particleSystemToUse;



    // Start is called before the first frame update
    void Start()
    {
        particleSystemToUse = GetComponent<ParticleSystem>();
        targetTime = videoClips[0].length;
        SliderToUse.maxValue = (float)targetTime;
        
    }

    

    void Update()
    {



        
        SliderToUse.value = (float)targetTime;
        particleSystemToUse.startLifetime = SliderToUse.value;
        int toText = (int)targetTime;
        textToChange.text = toText.ToString() + "s remaining";
        
        if (targetTime <= 0.0f)
        {
            targetTime= 0.0f;
            timerEnded();
        } else
        {
            targetTime -= Time.deltaTime;

        }

    }

    void timerEnded()
    {
        
       
    }


}

