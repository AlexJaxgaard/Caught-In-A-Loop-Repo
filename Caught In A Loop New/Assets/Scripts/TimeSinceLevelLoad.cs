//Attach this script to a GameObject
//Create a Button (Create>UI>Button) and a Text GameObject (Create>UI>Text)
//Click on the GameObject and attach the Button and Text in the fields in the Inspector

//This script outputs the time since the last level load. It also allows you to load a new Scene by pressing the Button. When this new Scene loads, the time resets and updates.

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeSinceLevelLoad : MonoBehaviour
{
    public Button m_MyButton;
    public Text m_MyText;
    static int timeSinceLevelLoaded;

    void Awake()
    {
        // Don't destroy the GameObject when loading a new Scene
        DontDestroyOnLoad(gameObject);
        // Make sure the Canvas isn't deleted so the UI stays on the Scene load
        DontDestroyOnLoad(GameObject.Find("Canvas"));

     
    }

    void Update()
    {
        int timeSinceLevelLoadInt = (int)Time.timeSinceLevelLoad;
        timeSinceLevelLoaded = timeSinceLevelLoadInt;
        // Output the time since the Scene loaded to the screen using this label
        m_MyText.text = timeSinceLevelLoadInt.ToString() + "s";
    }

    public static int getTime()
    {
        return timeSinceLevelLoaded;
    }

 
}