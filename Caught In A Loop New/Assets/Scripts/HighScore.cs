using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.WSA;


public class HighScore : MonoBehaviour
{
    public Text highScoreText;
    int highScore;
    private int currentScore;



    // Start is called before the first frame update
    void Start()
    {
        
        Console.WriteLine(highScoreText.text);
        currentScore = TimeSinceLevelLoad.getTime();
        if (PlayerPrefs.HasKey("hiScore"))
        {
            {
                if (currentScore > PlayerPrefs.GetInt("hiScore"))
                {
                    highScore = currentScore;
                    PlayerPrefs.SetInt("hiScore", highScore);
                    PlayerPrefs.Save();
                }
            }
        }

        else
        {
            highScore = currentScore;
            PlayerPrefs.SetInt("hiScore", TimeSinceLevelLoad.getTime());
            PlayerPrefs.Save();

        }

        
        int highScoreToShow = PlayerPrefs.GetInt("hiScore", currentScore);
        highScoreText.text = highScoreToShow.ToString();



    }

    // Update is called once per frame
    void Update()
        {

    }
    }

