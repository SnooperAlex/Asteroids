using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

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

   void Resume()
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
}
