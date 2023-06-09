using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;


public class SendToGameOver_GameOverScene : MonoBehaviour
{
    private VideoPlayer videoPlayer;
    public Text m_MyText;
    public string Text_To_Write;
    private double time;
    private double currentTime;


    private void Awake()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }

    private void Start()
    {
        time = gameObject.GetComponent<VideoPlayer>().clip.length;
    }

    public void LoadScene()//lets you write in unity the reason for the "game over"
    {
        m_MyText.text = Text_To_Write;
        SceneManager.LoadScene("GameOver");
    }

    private void Update()//when video ends load game over
    {
        currentTime = gameObject.GetComponent<VideoPlayer>().time;
        if (currentTime >= time || videoPlayer.isPaused)
        {
            LoadScene();
        }
    }
}
