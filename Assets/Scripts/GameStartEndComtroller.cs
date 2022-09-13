using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameStartEndComtroller : MonoBehaviour
{

    public bool isGameOver;
    public GameObject StartButtonTouch;
    public static bool isGameStarted;
    public GameObject GameOverMenu;
    public static GameStartEndComtroller GameControllStartEndInstance;
    public GameObject  MainMenuOptions;
    public GameObject SettingButton;
    


    public GameObject MainOption;
    
    private void Awake()
    {
        if (GameControllStartEndInstance == null)
        {
            GameControllStartEndInstance = this;
        }
    }

    void Start()
    {
        isGameOver = false;
        isGameStarted = false;
        SpawnRings.instance.rings[0].SetActive(false);
        SpawnRings.instance.rings[1].SetActive(false);
        SpawnRings.instance.rings[2].SetActive(false);
        SpawnRings.instance.rings[3].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
            SpawnRings.instance.MainMusicVoice.Pause();
            SpawnRings.instance.PointVoice.Pause();
            SpawnRings.instance.LastPointVoice.Pause();
            GameOverMenuMethod();
        }
    }

    public void AfterTapOnScreen()
    {
        TinySauce.OnGameStarted("1");
        StartButtonTouch.SetActive(false);
        SpawnRings.instance.rings[0].SetActive(true);
        SpawnRings.instance.rings[1].SetActive(true);
        SpawnRings.instance.rings[2].SetActive(true);
        SpawnRings.instance.rings[3].SetActive(true);
    }

    public void GameOverMenuMethod()
    {
        GameOverMenu.SetActive(true);
        SettingButton.SetActive(false);
        SpawnRings.instance.rings[0].SetActive(false);
        SpawnRings.instance.rings[1].SetActive(false);
        SpawnRings.instance.rings[2].SetActive(false);
        SpawnRings.instance.rings[3].SetActive(false);
       
    }


    public void RestartButtonAfterLoose()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        isGameOver = false;
        Time.timeScale = 1f;
    }


    public void QuitGame()
    {
        Application.Quit();
    }


    public void StartGameOptins()
    {
        
        MainMenuOptions.SetActive(true);
        SettingButton.SetActive(false);
        // Invoke("timeController", 1f);
        Time.timeScale = 0;
        SpawnRings.instance.i = -99999999;
    }

    // void timeController()
    // {
    //     
    //     SpawnRings.instance.i = -99999999;
    // }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        SettingButton.SetActive(true);
        MainMenuOptions.SetActive(false);
        SpawnRings.instance.i = 0;
    }

    public void OpenOptions()
    {
        MainMenuOptions.SetActive(false);
        MainOption.SetActive(true);
    }

    public void Continoue()
    {
        Time.timeScale = 1;
        MainMenuOptions.SetActive(false);
        MainOption.SetActive(false);
        SettingButton.SetActive(true);
        SpawnRings.instance.i = 0;
    }
}
