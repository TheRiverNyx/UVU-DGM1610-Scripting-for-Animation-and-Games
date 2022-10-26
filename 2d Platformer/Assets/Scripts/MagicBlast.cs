using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicBlast : MonoBehaviour
{
    public float speed;

    public int damage;

    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        GhostEnemy enemy = other.GetComponent<GhostEnemy>();
        if (other.gameObject.CompareTag("Enemy"))
        {
            enemy.TakeDamage(damage);
            Destroy(gameObject);
            
        }
        
    }
}
