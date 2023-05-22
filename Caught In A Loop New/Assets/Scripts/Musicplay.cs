using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musicplay : MonoBehaviour
{
    public GameObject objectMusic;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        objectMusic = GameObject.FindWithTag("GameMusic");
        audioSource = objectMusic.GetComponent<AudioSource>();
    }

}
