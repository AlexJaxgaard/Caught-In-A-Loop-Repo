using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class VolumeSlider : MonoBehaviour
{
    public Slider SliderToUse;
    public Text textToChange;

    void Start()
    {
    }

    void Update()
    {
        textToChange.text = "" + Math.Round(SliderToUse.value, 0);
    }
}
