using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] balloonPrefabs;// array of all the balloon prefabs

    public float startDelay = 0.5f;

    public float spawnInterval = 1.5f;

    public float xRange=5;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBalloon",startDelay,spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomBalloon()
    {
        // get random point on the x-axis
        Vector3 spawnPos = new Vector3(Random.Range(-xRange,xRange),0,0);
        //pick random balloon from the balloon array
        int balloonIndex = Random.Range(0, balloonPrefabs.Length);
        //spawn a random balloon at spawn point
        Instantiate(balloonPrefabs[balloonIndex],spawnPos, balloonPrefabs[balloonIndex].transform.rotation);

    }
}
