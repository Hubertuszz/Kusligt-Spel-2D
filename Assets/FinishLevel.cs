using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishLevel : MonoBehaviour
{
    public GameObject player;
    public Text youWon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.GetComponent<PlayerHealth>().health = 0;
        youWon.gameObject.SetActive(true);
    }
}
