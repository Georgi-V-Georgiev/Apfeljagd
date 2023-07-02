using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void Story()
    {
        SceneManager.LoadSceneAsync(4);
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("You have quit the game!");
    }
    public void Credits()
    {
        SceneManager.LoadSceneAsync(6);

    }
}
