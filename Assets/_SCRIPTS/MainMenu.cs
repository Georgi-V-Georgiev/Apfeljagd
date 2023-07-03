using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(2);
    }
    public void Story()
    {
        SceneManager.LoadSceneAsync(5);
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("You have quit the game!");
    }
    public void Credits()
    {
        SceneManager.LoadSceneAsync(7);

    }

    public void GoBackToMainMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
