using System.Collections;
using System.Collections.Generic;
using System;
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
        var psList = PlayerPrefs.GetString("scores").Split('-');
        Debug.Log(psList);
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
            hs.text = ""+BubbleSort(psList)[0];
        }
        

    }

    string[] BubbleSort(string[] arr)
    {
        int temp = 0;

        for (int write = 0; write < arr.Length; write++)
        {
            for (int sort = 0; sort < arr.Length - 1; sort++)
            {
                if (int.Parse(arr[sort]) > int.Parse(arr[sort + 1]))
                {
                    temp = int.Parse(arr[sort + 1]);
                    arr[sort + 1] = arr[sort];
                    arr[sort] = ""+temp;
                }
            }
        }
        return arr;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame() {
        SceneManager.LoadScene("SampleScene");
    }
}
