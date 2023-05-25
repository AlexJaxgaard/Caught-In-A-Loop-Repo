using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.WSA;

public class HighScore : MonoBehaviour
{

    public String Path_To_File;
    String[] ScoreArray;
    public Text highScoreText;
    int current;
    StreamWriter write;

    // Start is called before the first frame update
    void Start()
    {
       
        Path_To_File = "./Assets/GameOver/hej.txt";

        
        

        addToFile(current);
    
        openFile();
        setNewHighScore();
        
        


    }

    private void openFile()
    {
        write = new StreamWriter(Path_To_File);
        ScoreArray = write.ToString().Split(";");
        
    }

    private void addToFile(int score)
    {
        write.Write(score + ";");
        
    }

    private void setNewHighScore()
    {
        write.Close();
        openFile();

        if (ScoreArray.Length == 1)
        {
            highScoreText.text = ScoreArray[0];
            return;
        }
        
        int currentEntry = int.Parse(ScoreArray[0]);
       for (int i = 1; i < ScoreArray.Length; i++)
        {
                if (int.Parse(ScoreArray[i]) < currentEntry)
                {
                    currentEntry = int.Parse(ScoreArray[i]);
                }
            
        }
       
       highScoreText.text = currentEntry.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
