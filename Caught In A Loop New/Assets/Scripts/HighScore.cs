using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.WSA;

public class HighScore : MonoBehaviour
{
    double[] scores;
    public String Path_To_File;
    public Text highScoreText;

    // Start is called before the first frame update
    void Start()
    {
        Path_To_File = "";
        // Read a file
        string readText = File.ReadAllText(Path_To_File);
        String[] highScoreArray = readText.Split(";");

        int current = TimeSinceLevelLoad.getTime();
        int hej = int.Parse(highScoreArray[0]);

        

        if (hej < current)
        {

        } else
        {
            highScoreText.text = hej.ToString() + "s";
        }


    }

    private void setNewHighScore()
    {
        //Change file
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
