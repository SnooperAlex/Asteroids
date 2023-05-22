using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game Scene");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Achievments()
    {
        SceneManager.LoadScene("Achievments");
    }
}
