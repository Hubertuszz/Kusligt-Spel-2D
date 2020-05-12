using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float time = 0;
    public Text timer;
    bool timing = false;

    public void StartTimer()
    {
        timing = true;
    }
  
    void Update() 
    {
        if (timing == true)
            IncrementTime(); 
    }

    public void StopTimer()
    {
        timing = false;
    }

    void IncrementTime() {

        time += Time.deltaTime;
        
        int minutes = Mathf.FloorToInt(time / 60f);
        int seconds = Mathf.RoundToInt(time % 60f);
 
        string formatedSeconds = seconds.ToString();
 
        if (seconds == 60)
        {
            seconds = 0;
            minutes += 1;
        }
 
        timer.text = minutes.ToString("00") + ":" + seconds.ToString("00");
    }
}
