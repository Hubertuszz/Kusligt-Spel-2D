using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public int dmg;
    bool canAttack = false;
    Collider2D infected;

    void Start() {

    }

    void Update() {
        if(canAttack == true && Input.GetKeyDown(KeyCode.Space)) {
            infected.gameObject.GetComponent<Health>().TakeDmg(34);
        }
            
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Infected") {
            canAttack = true;
            infected = col;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if(col.gameObject.tag == "Infected") {
            canAttack = false;
            infected = null;
        }
    }
}
