using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed1 = 1000f;
    int direction;
    Rigidbody2D MyRB;
    public int dmg;


    private void Awake()
    {
        MyRB = GetComponent<Rigidbody2D>();

        MyRB.AddForce(-transform.right * speed1, ForceMode2D.Impulse);

    }

    private void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.gameObject.tag == "Player")
        {
            hit.GetComponent<PlayerHealth>().Damage(dmg);
        }
        Destroy(this.gameObject);
    }

    void Start()
    {
        StartCoroutine(DestroyFireBall());
    }

    IEnumerator DestroyFireBall()
    {
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }
}
