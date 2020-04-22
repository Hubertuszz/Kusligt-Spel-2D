using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainMenu : MonoBehaviour
{
    public Canvas canvas;
    public Text ps;
    public Text hs;
    // Start is called before the first frame update
    void Start()
    {
        string[] psList = PlayerPrefs.GetString("scores").Split('-');

        for(int i = 0; i < psList.Length;i++)
        {
            int.TryParse(psList[i], out int result);
            if (result == 0)
               psList = psList.Where(val => val != psList[i]).ToArray();
        }

        if (psList.Length == 0)
        {
            ps.text = "None";
            hs.text = "None";
        }
        else
        {
            ps.text = "";
            for (int i = 0; i < psList.Length; i++)
                ps.text += psList[i] + "\n";

            hs.text = "High Score: " + psList[Enumerable.Range(0, psList.Length).
                Aggregate((max, i) => int.Parse(psList[max]) > int.Parse(psList[i]) ? max : i)];
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
