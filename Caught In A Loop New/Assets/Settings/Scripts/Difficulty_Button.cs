using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Difficulty_Button : MonoBehaviour
{
    Button selectedButton;
    Color blueColour = Color.blue;
    Color whiteColour = Color.white;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        
    }
        

    public void DifficultyButtonPressed(Button button)
    {
        {
            if (selectedButton == button)
            {
                button.GetComponent<Image>().color = whiteColour;
                selectedButton = null;
            }
            else if (selectedButton != button) {
                selectedButton.GetComponent<Image>().color = Color.white;
                button.GetComponent<Image>().color = blueColour;
                selectedButton = button;

            }
            
            else {
                if (selectedButton != null)
                    selectedButton.GetComponent<Image>().color = whiteColour;
                button.GetComponent<Image>().color = blueColour;
                selectedButton = button;
            }
        }


    }

}
