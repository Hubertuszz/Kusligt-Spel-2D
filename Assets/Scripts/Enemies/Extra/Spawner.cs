using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class Spawner : MonoBehaviour
{
    public Transform[] spawnpoints;
    public GameObject[] enemies;
    public Transform spawnTrigger;
    int count = 0;
    public int lim;

    Score sc;
    // Start is called before the first frame update
    void Start()
    {
        sc = GetComponent<Score>();   
    }

    void Update()
    {
    }

    // Update is called once per frame
    void SpawnEnemy()
    {
        int n = Random.Range(0, 2);
        if (count < lim)
        {
            GameObject g = Instantiate(enemies[0], spawnpoints[n].position, transform.rotation);
            g.transform.Rotate(0f, 180f, 0f);
            count += 1;
        }
    }
}
