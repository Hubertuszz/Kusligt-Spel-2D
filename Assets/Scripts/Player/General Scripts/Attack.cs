using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public int dmg;
    bool canAttack = false;
    Collider2D infected;

    void Update() {
        if(canAttack == true && Input.GetKeyDown(KeyCode.Space) && infected)
            infected.gameObject.GetComponent<Health>().TakeDmg(34);            
    }

    void OnTriggerEnter2D(Collider2D col) {
        if(col.gameObject.tag == "Infected") {
            canAttack = true;
            infected = col;
        }
    }

    void OnTriggerExit2D(Collider2D col) {
        if(col.gameObject.tag == "Infected") {
            canAttack = false;
            infected = null;
        }
    }

    public float closeDistance = 5;
    
    public CheckCloseDistance()
    {
            GameObject[] taggedObjects = GameObject.FindGameObjectsWithTag("Point");
    
            for(int i = 0; i < taggedObjects.length; i++)
            {
                    if(Vector3.Distance(a.transform.position, 
                            taggedObjects[i].transform.position) <= closeDistance)
                    {
                            //This is within your close distance so do whatever close 
                            //logic here
                    }
            }
    }
}
