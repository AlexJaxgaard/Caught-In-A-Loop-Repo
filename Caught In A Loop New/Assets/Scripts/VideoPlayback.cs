using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoPlayback : MonoBehaviour
{

    [SerializeField] private VideoClip[] videoClips;
    private VideoPlayer videoPlayer;
    private int videoClipIndex;
    [SerializeField] private string nextScene;
    private double time;
    private double currentTime;




    private void Awake()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        videoPlayer.clip = videoClips[0];
    }

    private void Update()
    {
        if(videoClipIndex == (videoClips.Length - 1)){
            time = gameObject.GetComponent<VideoPlayer>().clip.length;
            currentTime += Time.deltaTime;
            if (currentTime >= time)
            {
                PlayNextVideo();
            }
        }
        else if (videoPlayer.isPaused && PauseMenu.gameIsPaused == false)
        {
            PlayNextVideo();
        }
    }

    public void PlayNextVideo()
    {
        videoClipIndex++;
        if(videoClipIndex >= videoClips.Length)
        {
            SceneManager.LoadScene(nextScene);
        }
        else
        {
            videoPlayer.clip = videoClips[videoClipIndex];
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
