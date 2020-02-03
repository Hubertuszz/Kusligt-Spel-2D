using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public int dmg;
    bool canAttack = false;
    void Start()
    {

    }

    void Update()
    {
        if(canAttack == true && Input.GetKeyDown(KeyCode.Space))
            Debug.Log("ATTACKING"); // Time to attack
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Infected")
            canAttack = true;
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if(col.gameObject.tag == "Infected")
            canAttack = false;
    }
}
