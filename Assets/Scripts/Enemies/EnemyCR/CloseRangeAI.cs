using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseRangeAI : MonoBehaviour
{
    //referenses
    private StateMachine sm = new StateMachine();
    private ChangeAppearance ch;
    private PlayerHealth ph;

    ////public variables
    public GameObject target;
    public Transform forwardPos;
    public Transform backPos;
    public int dmgInf = 10;
    public int dmgP = 25;
    public int delayAttack = 3;
    public float dA;

    ////private variables
    private Rigidbody2D rb;
    private bool fwtrue = true;
    private bool facingRight = false;

    //Radius
    public float followRad;
    public float attackRad;

    //movement
    private float maxSpeed = 7.5f;



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        //States
        sm.AddState("Idle", idle);
        sm.AddState("Attack", attack);
        sm.AddState("Follow", follow);
        sm.SetActiveState("Idle");
        ch = target.GetComponent<ChangeAppearance>();
        ph = target.GetComponent<PlayerHealth>();
    }

    void Update()
    {
        sm.Run();
        dA += Time.deltaTime;
    }

    public void idle(StateMachine s)
    {
        if (Vector3.Distance(transform.position, target.transform.position) < followRad && ch.isInfected == true)
        {
            s.SetActiveState("Follow");
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

    public void attack(StateMachine s)
    {
        if (Vector3.Distance(transform.position, target.transform.position) < followRad && Vector3.Distance(transform.position, target.transform.position) > attackRad && ch.isInfected == true)
        {
            s.SetActiveState("Follow");
        }
        else
        {
            
            if (ch.isInfected == true && dA > delayAttack)
            {
                ph.Damage(dmgInf);
                dA = 0;
                Debug.Log(ph.health);
            }
            else if(ch.isInfected != true && dA > delayAttack)
                ph.Damage(dmgP);
            
        }
    }

    public void follow(StateMachine s)
    {
        if (Vector3.Distance(transform.position, target.transform.position) < attackRad)
        {
            s.SetActiveState("Attack");
        }
        else if(Vector3.Distance(transform.position, target.transform.position) > followRad)
        {
            s.SetActiveState("Idle");
        }
        else if(transform.position.x > target.transform.position.x)
        {
            rb.velocity = new Vector2(-maxSpeed, rb.velocity.y);
            if (facingRight == true)
            {
                transform.Rotate(0, 180, 0);
                facingRight = false;
            }
        }
        else if(transform.position.x < target.transform.position.x)
        {
            rb.velocity = new Vector2(maxSpeed, rb.velocity.y);
            if (facingRight != true)
            {
                transform.Rotate(0, 180, 0);
                facingRight = true;
            }
        }
    }
}
