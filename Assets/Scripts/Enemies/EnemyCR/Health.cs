using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int health= 100;
    public int index;
    public GameObject Player;
    public GameObject blood;
    public Toggle splashBlood;
    public Combo c;
    public Score sc;
    public AudioSource src;
    public PlayerHealth h;

    // Start is called before the first frame update
    public void TakeDmg(int amount) {
        health -= amount;
        if(health <= 0) {
            if (index != 2)
                h.kills += 1;

            Player.GetComponent<ChangeAppearance>().amount = 100;
            Destroy(gameObject);
            if(splashBlood.isOn)
                Instantiate(blood, transform.position, Quaternion.identity);
            src.Play(0);
            src.time = 1;
            if (c.comboLvl == 0)
                sc.score += 10;
            else
                sc.score += 10 * c.comboLvl;
            c.NewCombo();
            PlayerPrefs.SetInt("score", sc.score);
        }
    }
    private void Start()
    {
        PlayerPrefs.SetInt("score", 0);
    }
}
