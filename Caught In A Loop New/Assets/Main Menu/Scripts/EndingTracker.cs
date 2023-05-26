using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingTracker : MonoBehaviour
{


    private static bool stealthEnding;

    void Update()
    {
       
    }

    public void StealthEndingReached()
    {
        stealthEnding = true;
    }

}
