using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
   public static bool GameIsPaused = false;

   public GameObject pauseMenu;
   public void Update()
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

   public void Resume()
   {
      pauseMenu.SetActive(false);
      Time.timeScale = 1f;
      GameIsPaused = false;
   }

   void Pause()
   {
      pauseMenu.SetActive(true);
      Time.timeScale = 0f;
      GameIsPaused = true;
   }

   public void LoadMenu()
   {
      ScoreManager.value = 0;
      Time.timeScale = 1f;
      GameIsPaused = false;
      SceneManager.LoadScene("Main Menu");
   }

   public void Restart()
   {
      ScoreManager.value = 0;
      Time.timeScale = 1f;
      GameIsPaused = false;
      SceneManager.LoadScene("Game Scene");
   }
   
}
