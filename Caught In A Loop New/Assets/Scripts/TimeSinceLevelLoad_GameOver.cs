//Attach this script to a GameObject
//Create a Button (Create>UI>Button) and a Text GameObject (Create>UI>Text)
//Click on the GameObject and attach the Button and Text in the fields in the Inspector

//This script outputs the time since the last level load. It also allows you to load a new Scene by pressing the Button. When this new Scene loads, the time resets and updates.

using System.IO;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections.Generic;



public class TimeSinceLevelLoad_GameOver : MonoBehaviour
{
    public static Button m_MyButton;
    public Text gameOverTime;
    float totalTime = 0;
    private static float timeCalculated;
    private float cutsceneTime = 0;
    private float sceneOneLoadedTimes = 0;
    private static GameObject instance = null;
    void Awake()
    {
        if (instance == null)
        {
            instance = gameObject;
            DontDestroyOnLoad(this.gameObject);
            return;
        }
        Destroy(this.gameObject);
    }

    void Start()
    {




        // Don't destroy the GameObject when loading a new Scene
        DontDestroyOnLoad(gameObject);


    }

    float sekundVisare = 0f;
    private void Update()
    {
        Time.timeScale = 1f;
        timeCalculated = getTime();
        Debug.Log(timeCalculated);
        Scene scene = SceneManager.GetActiveScene();

        if (scene.GetRootGameObjects().Contains(GameObject.FindGameObjectWithTag("PauseMenu")))
        {
            
            cutsceneTime += Time.deltaTime;
        }
        else if (scene.name == "GameOver" || scene.name == "GameOver_TimeRanOut")
        {
            

            gameOverTime.text = timeCalculated + "s";
            resetTimer();
        }
        else if (scene.name == "MainMenu")
        {
            

            resetTimer();

        } 
        


        else
        {
            totalTime += Time.deltaTime;


        }
        gameOverTime.text = timeCalculated + "s";
    }

    
        
    



    public int getTime()
    {
        return (int)(totalTime - cutsceneTime);
    }

    

    private void resetTimer()
    {
        timeCalculated = 0;
        cutsceneTime = 0;
        totalTime = 0;
  
    }

    private bool sceneOneLoadedBefore()
    {
        return sceneOneLoadedTimes > 0;
    }







}