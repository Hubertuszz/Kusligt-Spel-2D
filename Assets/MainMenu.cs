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

        string[] psList = PlayerPrefs.GetString("scores").Split('-');

        if (psList.Length == 0)
            ps.text = "None";
        else {
            ps.text = "";
            for (int i = psList.Length - 1; i >= 0; i--)
                ps.text += psList[i].ToString().Split(new char[] { ',' })[0] + "\n";


            hs.text = "High Score: " + PlayerPrefs.GetFloat("highScore").ToString().Split(new char[] { ',' })[0] + "\n";
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
