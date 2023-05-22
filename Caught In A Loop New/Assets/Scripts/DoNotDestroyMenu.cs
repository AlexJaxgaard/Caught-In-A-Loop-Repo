using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoNotDestroyMenu : MonoBehaviour
{
    private AudioSource audioSource;

    [SerializeField] private AudioClip menuMusic;
    [SerializeField] private AudioClip gameMusic;

    private bool inGame;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        audioSource = GetComponent<AudioSource>();
        inGame = false;
    }

    private void Update()
    {
        GameObject[] musicObjectGame = GameObject.FindGameObjectsWithTag("GameMusic");
        GameObject[] musicObjectMenu = GameObject.FindGameObjectsWithTag("MenuMusic");

        if (musicObjectGame.Length > 0 && inGame == true)
        {
            audioSource.Stop();
            audioSource.clip = gameMusic;
            audioSource.Play();
            inGame = false;
        }else if (musicObjectMenu.Length > 0 && inGame == false)
        {
            audioSource.Stop();
            audioSource.clip = menuMusic;
            audioSource.Play();
            inGame = true;
        }
    }

    public void StopThisAudio(GameObject audioSource)
    {
        audioSource.SetActive(false);

    }
}
