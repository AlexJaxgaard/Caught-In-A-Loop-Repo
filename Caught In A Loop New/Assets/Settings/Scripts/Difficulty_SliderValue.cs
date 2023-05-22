using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class Difficulty_SliderValue : MonoBehaviour
{
    public Slider SliderToUse;
    public Text textToChange;
    private double currentValue;

    void Start()
    {
    }

    void Update()
    {
        currentValue = Math.Round(SliderToUse.value);
        if (currentValue == 0 || currentValue < 25)
        {
            textToChange.text = "Easy";
        } else if (currentValue >= 25 && currentValue < 75)
        {
            textToChange.text = "Average";
        } else if (currentValue >= 75)
        {
            textToChange.text = "Hard";
        }

        
    }


    public double getCurrentValue()
    {
        return currentValue;
    }
}
