using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingTracker : MonoBehaviour
{
   


    public static bool stealthEnding;
    public static bool fightEnding;
    public static bool mysteryEnding;
    public static bool patient;

    void Update()
    {
        Scene scene = SceneManager.GetActiveScene();

        if(scene.name.Equals("Stealth Ending") || scene.name.Equals("Button get key"))
        {
            stealthEnding = true;
        }
        if (scene.name.Equals("DownStairs"))
        {
            mysteryEnding = true;
        }
        if (scene.name.Equals("Fight Ending"))
        {
            fightEnding = true;
        }
        if (scene.name.Equals("Get Clue"))
        {
            patient = true;
        }

    }

}
