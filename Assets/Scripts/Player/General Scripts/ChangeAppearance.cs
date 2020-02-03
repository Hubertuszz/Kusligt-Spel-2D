using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAppearance : MonoBehaviour
{
    public Sprite[] sprites;
    public bool isInfected = false;
    // Start is called before the first frame update
    void Start()
    {
        isInfected = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V) && isInfected == false) {
            GetComponent<SpriteRenderer>().sprite = sprites[1];
            isInfected = true;
            GetComponent<Attack>().enabled = true;
            
        } else if (Input.GetKeyDown(KeyCode.V) && isInfected == true) {
            GetComponent<SpriteRenderer>().sprite = sprites[0];
            isInfected = false;
            GetComponent<Attack>().enabled = false;
        }
    }

}