using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void Exit()
    {
        Application.Quit();
    }

    public void TryAgain()
    {
        SceneManager.LoadSceneAsync(2);
    }
}