using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public Image image;
    void Start() {
        health = 100;
    }
    
    void Update() {
        image.rectTransform.sizeDelta = new Vector2(health, 20);
        if (health <= 0)
            Die(); 
    }

   public void Damage(int a) {
        health -= a;
    }

    void Die() {
        Destroy(gameObject);
    }
}
