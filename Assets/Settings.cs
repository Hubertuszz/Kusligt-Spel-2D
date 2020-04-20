using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    public GameObject settings;
    bool inSettings = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && inSettings==false)
        {
            settings.SetActive(true);
            inSettings = true;
        } else if(Input.GetKeyDown(KeyCode.Escape) && inSettings==true)
        {
            settings.SetActive(false);
            inSettings = false;
        }

    }
}
