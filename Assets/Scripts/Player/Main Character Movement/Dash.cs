//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Dash : MonoBehaviour
//{
//    private Rigidbody2D rb;
//    public float dashSpeed;
//    private float dashtime;
//    public float startDashTime;
//    private int dir;
//    public Movement pl;
//    public GameObject dashEffect;
//    private float fireRate = 1.3f;
//    float nextFire = 0;
//    public GameObject dashPos;

//    void Start()
//    {
//        rb = GetComponent<Rigidbody2D>();
//        dashtime = startDashTime;



//    }

//    void Update()
//    {
//        if (dir == 0)
//        {
//            if (Input.GetKeyDown(KeyCode.LeftShift) && Time.time > nextFire)
//            {
//                nextFire = Time.time + fireRate;

//                if (pl.m_FacingRight)
//                {
//                    dir = 2;
//                    Instantiate(dashEffect, dashPos.transform.position, Quaternion.identity);
//                }
//                else if (pl.m_FacingRight == false)
//                {
//                    dir = 1;
//                    Instantiate(dashEffect, dashPos.transform.position, Quaternion.identity);
//                }

//            }



//        }
//        else
//        {
//            if (dashtime <= 0)
//            {
//                dir = 0;
//                dashtime = startDashTime;
//                rb.velocity = Vector2.zero;
//            }
//            else
//            {
//                dashtime -= Time.deltaTime;

//                if (dir == 1)
//                {
//                    rb.velocity = Vector2.left * dashSpeed;
//                }
//                if (dir == 2)
//                {
//                    rb.velocity = Vector2.right * dashSpeed;
//                }


//            }
//        }
//    }
//}
