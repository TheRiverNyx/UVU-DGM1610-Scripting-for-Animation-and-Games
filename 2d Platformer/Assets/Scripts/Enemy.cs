using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;

    public float speed;
    
    
    // Start is called before the first frame update
    void Start()
    {
        //particles and animation
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
            Debug.Log("Enemy has perished");
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("enemy took damage");
    }
}
