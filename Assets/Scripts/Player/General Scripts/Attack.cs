using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public int dmg;
    Collider2D infected;
    public GameObject bulletPrefab;
    public Transform position;
    float canFire = 2;
    public GameObject audio;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Shoot();
        canFire += Time.deltaTime;
    }

    void Shoot()
    {
        if(canFire >= 0.6f)
        {
            Instantiate(bulletPrefab, position.position, Quaternion.Euler(new Vector3(0, 0, transform.localEulerAngles.z)));
            canFire = 0;
            
            audio.GetComponent<AudioSource>().Play(0);
            audio.GetComponent<AudioSource>().time = 0.5f;

        }
    }
}