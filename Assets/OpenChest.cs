using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenChest : MonoBehaviour
{
    bool canOpen = false;
    public Text indicator;
    public GameObject lockedDoor;
    public Text tutTxt;
    AudioSource src;

    void Start()
    {
        src = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(canOpen == true)
        {
            indicator.text = "PRESS E TO OPEN THE CHEST";
            if (Input.GetKeyDown(KeyCode.E))
            {
                src.Play(0);
                src.time = 0.4f;
                lockedDoor.SetActive(false);
                tutTxt.text = "";
                indicator.text = "";
                GetComponent<SpriteRenderer>().enabled = false;
                GetComponent<BoxCollider2D>().enabled = false;
            }
        }
        else
        {
            indicator.text = "";
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        canOpen = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        canOpen = false;
    }
}
