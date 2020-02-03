using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseRangeAI : MonoBehaviour
{
    private StateMachine sm = new StateMachine();

    ////public variables
    public GameObject target;
    public Transform forwardPos;
    public Transform backPos;

    ////private variables
    private Rigidbody2D rb;
    private bool fwtrue = true;
    private bool facingRight = false;

    //Radius
    private float moveRad;

    //movement
    private float maxSpeed = 7.5f;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        //States
        sm.AddState("Idle", idle);
        sm.SetActiveState("Idle");
        
    }

    void Update()
    {
        sm.Run();
    }

    public void idle(StateMachine s)
    {
        if (Vector3.Distance(transform.position, target.transform.position) < moveRad)
        {
            //setactivestate movement


        }
        else if (transform.position.x > forwardPos.transform.position.x && fwtrue == true)
        {
            rb.velocity = new Vector2(-maxSpeed, rb.velocity.y);
            if (facingRight == true)
            {
                transform.Rotate(0, 180, 0);
                facingRight = false;
            }
        }
        else
        {
            fwtrue = false;
            rb.velocity = new Vector2(maxSpeed, rb.velocity.y);
            if (facingRight != true)
            {
                transform.Rotate(0, 180, 0);
                facingRight = true;
            }
            if(transform.position.x > backPos.transform.position.x)
            {
                
                fwtrue = true;
            }
        }
        
    }
}
