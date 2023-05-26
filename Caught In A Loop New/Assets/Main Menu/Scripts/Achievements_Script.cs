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

    void Start()
    {

        patientDetHidden.SetActive(!EndingTracker.patient);
        patientDetShown.SetActive(EndingTracker.patient);

        fighterHidden.SetActive(!EndingTracker.fightEnding);
        fighterShown.SetActive(EndingTracker.fightEnding);

        stealthyHidden.SetActive(!EndingTracker.stealthEnding);
        stealthyShown.SetActive(EndingTracker.stealthEnding);

        mysteryHidden.SetActive(!EndingTracker.mysteryEnding);
        mysteryShown.SetActive(EndingTracker.mysteryEnding);
    }

    
}
