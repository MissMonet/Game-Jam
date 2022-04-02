using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class startmenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ScenceSwitcher()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void Settings()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }

    public void ControlBack()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    public void VolumeBack()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }

    public void Controlback2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }


    public void QuitGame()
    {
        Debug.Log(" QUIT!");
        Application.Quit();
    }
}
