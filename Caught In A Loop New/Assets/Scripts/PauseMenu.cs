using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public static bool gameIsPaused = false;
    public GameObject pauseMenuUi;
    public GameObject pauseButton;

    public void PauseGame()
    {
        pauseMenuUi.SetActive(true);
        pauseButton.SetActive(false);
        //Time.timeScale = 0f;
        gameIsPaused = true;
    }

    public void ResumeGame()
    {
        pauseMenuUi.SetActive(false);
        pauseButton.SetActive(true);
        //Time.timeScale = 1f;
        gameIsPaused = false;
    }

    public void LoadMenu()
    {
        UnPauseGame();
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        UnPauseGame();
        Application.Quit();
        
    }

    public void UnPauseGame()
    {
        gameIsPaused = false;
    }

}
