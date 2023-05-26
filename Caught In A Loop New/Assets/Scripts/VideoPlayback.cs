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




    private void Awake() //finds video player component
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }

    
    void Start() //Video Clip array
    {
        videoPlayer.clip = videoClips[0];
    }

    private void Update() // checks if video is done playing, and checks if the video is paused because of the menu
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

    public void PlayNextVideo() //plays next video in array until all videos are done, then moves on to next scene
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
