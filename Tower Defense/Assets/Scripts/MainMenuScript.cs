﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public Button StartGame;
    public Button GameCredits;
    public Button GameControls;
    public Button QuitGame;
    public Button HowTo;
    public Button ReturnMainMenu;

   



    public void PlayGamelevel()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void GameMenuCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void GameMenuControls()
    {
        SceneManager.LoadScene("Controls");
    }

    public void GameObjectives()
    {
        SceneManager.LoadScene("HowToPlay");
    }


    public void QuitGameMenu()
    {

        #if UNITY_STANDALONE
		Application.Quit ();
        #endif

        #if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }

  
   public void ReturnMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
