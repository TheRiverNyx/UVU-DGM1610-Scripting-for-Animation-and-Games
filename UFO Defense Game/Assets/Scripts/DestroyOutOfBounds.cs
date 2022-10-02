using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBounds = 30.00f;
    public float lowerBounds = -10.00f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }else if (transform.position.z<lowerBounds){
            if (gameObject.CompareTag("Enemy"))//if gameobject has enemy tag end destroy the player and end the game
            {
                Debug.Log("Game Over");
                Destroy(GameObject.FindWithTag("Player"));
            }
            Destroy(gameObject);
        }
    }
}
