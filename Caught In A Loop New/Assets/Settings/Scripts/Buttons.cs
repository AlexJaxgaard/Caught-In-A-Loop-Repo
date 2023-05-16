using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    Button[] buttons = new Button[3];

    // Start is called before the first frame update
    void Start()
    {
        int i = 0;
        foreach (Button button in Buttons.FindObjectsOfType<Button>())
        {
            buttons[i++] = button;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
