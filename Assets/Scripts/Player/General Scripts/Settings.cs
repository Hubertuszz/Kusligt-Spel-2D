using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public GameObject settings;
    bool paused = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && paused == false)
        {
            paused = true;
            settings.SetActive(true);
            Time.timeScale = 0;
        } else if (Input.GetKeyDown(KeyCode.Escape) && paused == true)
        {
            paused = false;
            settings.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
