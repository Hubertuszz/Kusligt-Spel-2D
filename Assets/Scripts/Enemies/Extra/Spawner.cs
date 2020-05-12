using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class Spawner : MonoBehaviour
{
    public Transform[] spawnpoints;
    public GameObject[] enemies;
    int randomSpawnPoint;
    public bool spawnAllowed;
    public Transform spawnTrigger;
    public int distanceTrigger;
    public GameObject target;

    Score sc;
    // Start is called before the first frame update
    void Start()
    {
        sc = GetComponent<Score>();
        
        InvokeRepeating("SpawnEnemy", 0f, 1f);
    }

    void Update()
    {
        if (Vector3.Distance(spawnTrigger.position, target.transform.position) < distanceTrigger)
        {
            Debug.Log("Hello");
            if (sc.score < 200)
                spawnAllowed = true;
            else
                spawnAllowed = false;

        }
    }

    // Update is called once per frame
    void SpawnEnemy()
    {
        if (spawnAllowed)
        {
            Debug.LogError("Hello");
            randomSpawnPoint = Random.Range(0, spawnpoints.Length);
            Instantiate(enemies[0], spawnpoints[randomSpawnPoint].position, Quaternion.identity);
        }
    }
}
