using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class Difficulty_SliderValue : MonoBehaviour
{
    public Slider SliderToUse;
    public Text textToChange;

    void Start()
    {
    }

    void Update()
    {
        Math.Round(SliderToUse.value, 0)
        if (SliderToUse.value >= 25)

        textToChange.text = "" + Math.Round(SliderToUse.value, 0) + "%";
    }
}
