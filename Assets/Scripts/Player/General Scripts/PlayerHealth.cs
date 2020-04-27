using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public Image image;

    public AudioClip clip;
    public AudioSource src;

    public GameObject deathMenu;

    void Start()
    {

        Time.timeScale = 1;
        health = 100;
        src.clip = clip;
        image.rectTransform.sizeDelta = new Vector2(health, 25);
    }

    void Update()
    {
        if (health == 0)
            Die();
    }

    public void Damage(int a)
    {
        health -= a;
        image.rectTransform.sizeDelta = new Vector2(health, 25);
    }

    void Die()
    {
        src.enabled = true;
        deathMenu.SetActive(true);
        GetComponent<SpriteRenderer>().enabled = false;
        Time.timeScale = 0;
    }
}
