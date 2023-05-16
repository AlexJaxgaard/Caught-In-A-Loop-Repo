using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentDifficulty : MonoBehaviour
{

    static Button difficulty;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void SetDifficulty(Button button)
    {
        difficulty = button;
    }

    public static Button GetDifficulty()
    {
        return difficulty;
    }

   

}
