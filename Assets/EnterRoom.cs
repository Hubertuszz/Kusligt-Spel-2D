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
        door.SetActive(true);
        timer.StartTimer();
    }
}
