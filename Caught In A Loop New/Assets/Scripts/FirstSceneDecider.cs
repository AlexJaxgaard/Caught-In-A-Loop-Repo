using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstSceneDecider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Invoke("checkBeforeLoad", 3);

    }
    void loadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    void checkBeforeLoad()
    {
        if (PlayerPrefs.HasKey("FirstSceneLoaded") || PlayerPrefs.GetString("FirstSceneLoaded") == "true")
        {
            PlayerPrefs.SetString("FirstSceneLoaded", "true");
            loadScene("MainMenu");
        }
        else if (!PlayerPrefs.HasKey("FirstSceneLoaded") || PlayerPrefs.GetString("FirstSceneLoaded") == "false")
        {
            PlayerPrefs.SetString("FirstSceneLoaded", "true");
            loadScene("Prolog_Intro");

        }
    }
}
