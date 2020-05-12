using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterRoomGeneral : MonoBehaviour
{
    // Start is called before the first frame update
    public EnterRoom AudioLink;
    public AudioClip clip;
    public GameObject lockedDoor;
    public int index;
    public Text tutTxt;

    void Start()
    {
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        AudioLink.audioData.clip = clip;
        AudioLink.audioData.Play(0);
        lockedDoor.SetActive(true);
        GetComponent<BoxCollider2D>().enabled = false;
        if (index == 5)
        {
            tutTxt.text = "YOUR GOAL IS NOW TO OPEN THE NEXT DOOR BY FINDING THE CHEST";
            Debug.Log("GG");
            tutTxt.gameObject.SetActive(true);
        }

    }
}
