using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Audio_manager : MonoBehaviour
{

    [SerializeField] private AudioSource musicSource;

    [SerializeField] private AudioClip musicClip;

    public bool inGame;

    public static Audio_manager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        inGame = true;
        musicSource.clip = musicClip;
        musicSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (inGame == false)
        {
            Destroy(this);
        }
    }

    public void StopMusic()
    {
        musicSource.Stop();
    }
}
