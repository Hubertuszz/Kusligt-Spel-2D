﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DiedMenu : MonoBehaviour
{
    public Score sc;
    public Text scoreTxt;
    public Timer timer;

    private void Start()
    {
        sc.scoreTxt.enabled = false;
        if(sc.score != 0)
            scoreTxt.text = "SCORE: " + (sc.score / (timer.time / 20)).ToString("0");
        PlayerPrefs.SetString("scores", PlayerPrefs.GetString("scores") + (float)(sc.score / (timer.time / 20)) + "-");
        if ((float)(sc.score / (timer.time / 20)) > PlayerPrefs.GetFloat("highScore"))
            PlayerPrefs.SetFloat("highScore", (float)(sc.score / (timer.time / 20)));
    }

    public void BackToMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
    }
}
