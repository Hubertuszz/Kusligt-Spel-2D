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
    public GameObject nextDoor;
    public int index;
    public Text tutTxt;
    public Spawner sp;
    bool changed = false;
    public PlayerHealth h;
    GameObject aud;
    public GameObject bossHP;

    public GameObject boss;
    public Text t;
    public int lim;
    void Start()
    {
        aud = GameObject.FindWithTag("ChestSound");
    }
    private void Update()
    {
        if(index != 5 || index != 4)
        {
            if (h.kills == lim && changed == false)
            {
                KilledAll();
                changed = true;
            }
        }
    }

    void KilledAll()
    {
        nextDoor.SetActive(false);
        aud.GetComponent<AudioSource>().Play(0);
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
        else if (index == 4)
        {
            bossHP.SetActive(true);
            boss.SetActive(true);
        }
        else
        {
            sp.InvokeRepeating("SpawnEnemy", 0f, 2f);
            if (index == 1)
                t.text = "";

        }
    }
}
