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

public class PlayerHealth : MonoBehaviour
{
    public int health;

    void Start() {
        health = 100;
    	src.clip = clip;
    }
    
    void Update() {
        if(health <= 0)
            Die(); 
    }

   public void Damage(int a) {
        health -= a;
    }

    void Die() {
	src.Play();
        gameObject.SetActive(false);
        PlayerPrefs.SetString("scores", PlayerPrefs.GetString("scores") + PlayerPrefs.GetInt("score") + "-");
        Debug.Log("Set: "+ PlayerPrefs.GetInt("score"));
        SceneManager.LoadScene("MainMenu");
    }
}
