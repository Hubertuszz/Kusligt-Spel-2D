using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health= 100;
    public GameObject Player;
    public GameObject blood;
    public Toggle splashBlood;

    public Score sc;

    // Start is called before the first frame update
    public void TakeDmg(int amount) {
        health -= amount;
        if(health <= 0) {
            Player.GetComponent<ChangeAppearance>().amount = 100;
            Destroy(gameObject);
            if(splashBlood.isOn)
                Instantiate(blood, transform.position, Quaternion.identity);
            sc.score += 10;
            PlayerPrefs.SetInt("score", sc.score);
        }
    }
    private void Start()
    {
        PlayerPrefs.SetInt("score", 0);
    }
}
