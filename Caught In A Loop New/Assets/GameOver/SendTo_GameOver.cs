using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;


public class SendTo_GameOver : MonoBehaviour
{
    private VideoPlayer videoPlayer;
    public Text m_MyText;
        public string Text_To_Write;


    private void Awake()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }

    public void LoadScene()
    {
        m_MyText.text = Text_To_Write;
        SceneManager.LoadScene("GameOver");
    }

    private void Update()
    {
        if (videoPlayer.isPaused)
        {
            LoadScene();
        }
    }
}
