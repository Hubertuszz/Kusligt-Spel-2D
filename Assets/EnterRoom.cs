using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.UI;

public class EnterRoom : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject door;
    public Text txt;
    public Timer timer;
    public GameObject player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        txt.gameObject.SetActive(false);
        player.GetComponent<PlayerHealth>().health = 100;
        player.GetComponent<PlayerHealth>().image.rectTransform.sizeDelta = new Vector2(player.GetComponent<PlayerHealth>().health, 25);
        door.SetActive(true);
        timer.StartTimer();
    }
}
