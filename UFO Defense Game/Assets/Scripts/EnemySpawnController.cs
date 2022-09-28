using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnController : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    [SerializeField]
    private float spawnRangeX = 17f;
    [SerializeField]
    private float spawnPosZ= 20f;

    private float startDelay = 2.0f;

    private float spawnInterval = 2.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy",startDelay,spawnInterval);
    }
    
    void SpawnRandomEnemy()
    {
        //generate random position to spawn on
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),0,spawnPosZ);
        //pick an enemy from the array
        int enemyIndex = Random.Range(0, enemyPrefabs.Length);
        //Spawn the enemy
        Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex].transform.rotation);
    }
}
