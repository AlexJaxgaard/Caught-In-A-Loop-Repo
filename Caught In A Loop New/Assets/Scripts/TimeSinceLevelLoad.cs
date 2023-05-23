//Attach this script to a GameObject
//Create a Button (Create>UI>Button) and a Text GameObject (Create>UI>Text)
//Click on the GameObject and attach the Button and Text in the fields in the Inspector

//This script outputs the time since the last level load. It also allows you to load a new Scene by pressing the Button. When this new Scene loads, the time resets and updates.

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeSinceLevelLoad : MonoBehaviour
{
    public static Button m_MyButton;
    public Text gameOverTime;
    int totalTime = 0;
    double timeInMainMenu = 0;
    
    void Start()
    {
        // Don't destroy the GameObject when loading a new Scene
        DontDestroyOnLoad(gameObject);

        

     
    }

    void Update()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "GameOver" || scene.name == "GameOver_TimeRanOut")
        {

            gameOverTime.text = totalTime - timeInMainMenu + "s";
        } else
        {
            totalTime = (int)Time.time;
        }

        
       
        // Output the time since the Scene loaded to the screen using this label
        
        
    }

  
    public void StartTime()
    {
        timeInMainMenu = (int)Time.time;

    }



 
}