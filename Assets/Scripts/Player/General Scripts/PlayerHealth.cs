using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health;

    void Start() {
        health = 100;
    }
    
    void Update() {
        if(health <= 0)
            Die(); 
    }

   public void Damage(int a) {
        health -= a;
    }

    void Die() {
        Destroy(gameObject);
    }
}
