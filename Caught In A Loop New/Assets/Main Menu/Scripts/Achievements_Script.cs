using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Achievements_Script : MonoBehaviour
{
    [SerializeField] private GameObject patientDetHidden;
    [SerializeField] private GameObject patientDetShown;

    [SerializeField] private GameObject stealthyHidden;
    [SerializeField] private GameObject stealthyShown;

    [SerializeField] private GameObject fighterHidden;
    [SerializeField] private GameObject fighterShown;

    [SerializeField] private GameObject mysteryHidden;
    [SerializeField] private GameObject mysteryShown;
    [SerializeField] private Scene scene;


    public string GetAchievementStatus()
    {
        ArrayList achList = new();
        achList.Add("Patient Detective");
        achList.Add("Fighter Ending");
        achList.Add("Stealth Ending");
        achList.Add("Mystery Ending");
        //...

        //if (getSceneName &&)
        return null;
    }
    
    public static void AchievementTracker()
    {
        
    }

    public void Update()
    {
        Debug.Log(scene.name);
        scene = SceneManager.GetActiveScene();
        if (scene.name.Equals("Stealth Ending"))
        {
            stealthyHidden.SetActive(false);
            stealthyShown.SetActive(true);
        }
    }
}
