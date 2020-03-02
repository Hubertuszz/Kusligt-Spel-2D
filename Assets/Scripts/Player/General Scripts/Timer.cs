using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    private float time = 0;
    public Text timer;
    
    // Start is called before the first frame update
    void Start() {
        StartTimer();
    }

    public void StartTimer(){
        time = 0;
        InvokeRepeating("IncrementTime", 1,1);
    }
  
    void Update() {
        if(GameObject.FindGameObjectsWithTag("Infected").Length == 0)
            StopTimer();
    }

    public void StopTimer(){
        CancelInvoke();
    }

    public void IncrementTime() {

        time += 1;
        
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
