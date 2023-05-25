using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class Special_Playback : MonoBehaviour
{
    [SerializeField] private string defaultScene;

    [SerializeField] private VideoClip[] videoClips;
    private VideoPlayer videoPlayer;
    private int videoClipIndex;
    private string sceneName;
    private double time;
    private double currentTime;



    private void Awake()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        SetSceneName();
    }

    // Start is called before the first frame update
    void Start()
    {
        videoPlayer.clip = videoClips[0];
        time = gameObject.GetComponent<VideoPlayer>().clip.length;
    }

    private void Update()
    {
        currentTime = gameObject.GetComponent<VideoPlayer>().time;
        if (currentTime >= time)
        {
            PlayNextVideo();
        }
    }

    public void PlayNextVideo()
    {
        string nextScene = sceneName;
        videoClipIndex++;
        if (videoClipIndex >= videoClips.Length)
        {
            SceneManager.LoadScene(nextScene);
        }
        else
        {
            videoPlayer.clip = videoClips[videoClipIndex];
        }

    }


    public void SetSceneName()
    {
        if(Check_Camera_Wire.GetWireStatus() == false)
        {
            sceneName = "Stealth Ending";
        }
        else
        {
            sceneName = defaultScene;
        }
    }

    public void PauseVideo()
    {
        videoPlayer.Pause();
    }

    public void ResumeVideo()
    {
        videoPlayer.Play();
    }

}