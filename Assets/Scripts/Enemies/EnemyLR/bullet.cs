using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed1 = 0;
    int direction;
    Rigidbody2D MyRB;
    public int dmg;
    int dir;

    private void Awake()
    {
        MyRB = GetComponent<Rigidbody2D>();
        dir = GameObject.FindGameObjectWithTag("Player").GetComponent<Movement>().direction;
    }
    private void Update()
    {
        transform.Translate(dir * Vector2.right * Time.deltaTime * 60);
    }
    private void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.gameObject.tag == "Infected")
        {
            hit.GetComponent<Health>().TakeDmg(dmg);
            hit.GetComponent<SpriteRenderer>().color = Color.red;
            GetComponent<SpriteRenderer>().enabled = false;
            transform.position = new Vector3(10000, -10000, 10);
            StartCoroutine(Wait(hit));
        }
       
    }

    IEnumerator Wait(Collider2D g)
    {
        yield return new WaitForSeconds(0.1f);
        g.GetComponent<SpriteRenderer>().color = Color.white;
        Destroy(gameObject);
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
