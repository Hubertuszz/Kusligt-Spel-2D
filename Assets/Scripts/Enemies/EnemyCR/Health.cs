using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health= 100;
    public GameObject Player;
    // Start is called before the first frame update
    public void TakeDmg(int amount) {
        health -= amount;
        if(health <= 0) {
            Player.GetComponent<ChangeAppearance>().amount = 100;
            Destroy(gameObject);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
