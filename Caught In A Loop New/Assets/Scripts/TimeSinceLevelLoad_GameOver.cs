//Attach this script to a GameObject
//Create a Button (Create>UI>Button) and a Text GameObject (Create>UI>Text)
//Click on the GameObject and attach the Button and Text in the fields in the Inspector

//This script outputs the time since the last level load. It also allows you to load a new Scene by pressing the Button. When this new Scene loads, the time resets and updates.

using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeSinceLevelLoad_GameOver : MonoBehaviour
{
    public static Button m_MyButton;
    public Text gameOverTime;
    int totalTime = 0;
    private static int timeCalculated;
    private string[] cutsceneList;
    private int cutsceneTime = 0;

    void Start()
    {
        // Don't destroy the GameObject when loading a new Scene
        DontDestroyOnLoad(gameObject);
        InvokeRepeating("addSecond", 1f, 1f);  //1s delay, repeat every 1s


    }


    public int getTime()
    {
        return (int)(totalTime - cutsceneTime);
    }

    private void addSecond()
    {
        timeCalculated = getTime();
        Scene scene = SceneManager.GetActiveScene();
        Debug.Log(totalTime);
        if (scene.GetRootGameObjects().Contains(GameObject.FindGameObjectWithTag("PauseMenu")))
        {
            cutsceneTime++;
        } else if (scene.name == "GameOver" || scene.name == "GameOver_TimeRanOut")
        {
            gameOverTime.text = timeCalculated + "s";
            timeCalculated = 0;
            cutsceneTime = 0;
            totalTime = 0;
        }  else if (scene.name == "MainMenu")
        {
            gameOverTime.text = timeCalculated + "s";
            for (int i = 0; i < GameObject.FindGameObjectsWithTag("TimeTracker").Length; i++)
            {
                Destroy(GameObject.FindGameObjectWithTag("TimeTracker"));
            }

        }
        
        
        else
        {
            totalTime++;
        }
        gameOverTime.text = timeCalculated + "s";
    }







}