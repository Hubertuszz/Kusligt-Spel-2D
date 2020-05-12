using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public Image image;
    public int g = 0;
    public GameObject audioData;
    public GameObject deathMenu;

    void Start()
    {
        Time.timeScale = 1;
        health = 100;
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
        audioData.GetComponent<AudioSource>().Play(0);
        audioData.GetComponent<AudioSource>().time = 1.5f;
        deathMenu.SetActive(true);
        GetComponent<SpriteRenderer>().enabled = false;
    }
}
