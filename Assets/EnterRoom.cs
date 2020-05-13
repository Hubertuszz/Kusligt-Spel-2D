using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(AudioSource))]
public class EnterRoom : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject door;
    public Text txt;
    public Timer timer;
    public GameObject player;
    public AudioSource audioData;
    public GameObject lockedDoor;
    public Tutorial tut;
    public PlayerHealth h;
    public GameObject nextDoor;
    public Spawner sp;
    bool changed = false;
    GameObject aud;

    public Text t;
    void Start()
    {
        aud = GameObject.FindWithTag("ChestSound");
        audioData = GetComponent<AudioSource>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (h.kills == 10 && changed == false)
        {
            KilledAll();
            changed = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        SpawnEnemies();
        tut.step += 2;
        txt.gameObject.SetActive(false);
        lockedDoor.SetActive(true);
        player.GetComponent<PlayerHealth>().health = 100;
        player.GetComponent<PlayerHealth>().image.rectTransform.sizeDelta = new Vector2(player.GetComponent<PlayerHealth>().health, 25);
        door.SetActive(true);
        timer.StartTimer();
        audioData.Play(0);
        GetComponent<BoxCollider2D>().enabled = false;  
    }

    void SpawnEnemies()
    {
        sp.InvokeRepeating("SpawnEnemy", 0f, 2f);
    }

    void KilledAll()
    {
        nextDoor.SetActive(false);
        aud.GetComponent<AudioSource>().Play(0);
        t.gameObject.SetActive(true);
        t.text = "Good job, now continue forward.";
    }
}
