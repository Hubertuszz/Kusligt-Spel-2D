using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// The Audio Source component has an AudioClip option.  The audio
// played in this example comes from AudioClip and is called audioData.

[RequireComponent(typeof(AudioSource))]
public class MainMenu : MonoBehaviour
{
    public Canvas canvas;
    public Text ps;
    public Text hs;
    AudioSource audioData;

    // Start is called before the first frame update
    void Start()
    {
        audioData = GetComponent<AudioSource>();
        audioData.Play(0);
        Debug.Log("started");
        string[] psList = PlayerPrefs.GetString("scores").Split('-');

        for(int i = 0; i < psList.Length;i++)
        {
            int.TryParse(psList[i], out int result);
            if (result == 0)
               psList = psList.Where(val => val != psList[i]).ToArray();
        }

        if (psList.Length == 0)
            ps.text = "None";
        else {
            ps.text = "";
            for (int i = 0; i < psList.Length; i++)
                ps.text += float.Parse(psList[i]).ToString("0.0") + "\n";


            hs.text = "High Score: " + PlayerPrefs.GetFloat("highScore").ToString("0.0");
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
