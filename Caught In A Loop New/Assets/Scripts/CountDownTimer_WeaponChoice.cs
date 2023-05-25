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
    public float targetTime = 60.0f;
    [SerializeField] private VideoClip[] videoClips;



    // Start is called before the first frame update
    void Start()
    {
        targetTime = (float)videoClips[0].length;
        SliderToUse.maxValue = targetTime;
        
    }

    

    void Update()
    {

        

        
        SliderToUse.value = targetTime;
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
        
        SceneManager.LoadScene("GameOver_TimeRanOut");
    }


}

