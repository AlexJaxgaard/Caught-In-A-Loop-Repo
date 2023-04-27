using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SendTo_GameOver : MonoBehaviour
{
        public Text m_MyText;
        public string Text_To_Write;

    public void LoadScene()
    {
        m_MyText.text = Text_To_Write;
        SceneManager.LoadScene("GameOver");
    }
}
