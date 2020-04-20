using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int health= 100;
    public GameObject Player;
    public GameObject blood;
    public Toggle splashBlood;

    // Start is called before the first frame update
    public void TakeDmg(int amount) {
        health -= amount;
        if(health <= 0) {
            Player.GetComponent<ChangeAppearance>().amount = 100;
            Destroy(gameObject);
            if(splashBlood.isOn)
                Instantiate(blood, transform.position, Quaternion.identity);
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
