using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicVolumeSlider : MonoBehaviour
{
    public Slider slider;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Awake()
    {

        slider.value = PlayerPrefs.GetFloat("Volume") * 100;

        audioSource = GameObject.FindObjectOfType<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("Volume", slider.value/ 100);
        audioSource.volume = PlayerPrefs.GetFloat("Volume");
    }
}
