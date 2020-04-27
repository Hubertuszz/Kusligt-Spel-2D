using System.Collections;
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
        scoreTxt.text = "Score: " + (int)(sc.score / (timer.time / 3));
        PlayerPrefs.SetString("scores", PlayerPrefs.GetString("scores") + (int)(sc.score / (timer.time / 3)) + "-");
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
