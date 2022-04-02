using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausemenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pausemenuUI;
    

    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void ControlBack()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    public void Resume()
    {
        pausemenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

    }

     void Pause()
    {
        pausemenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true; 
    }

    public void LoadCONTROLS()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("CONTROLS");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}
