using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 10;

    public int currentHealth;

    public float deathDelay;
    
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int dmgAmount)
    {
        currentHealth -= dmgAmount;
        Debug.Log("Player Health = "+currentHealth);
        if (currentHealth <= 0)
        {
            Debug.Log("You are dead! Game Over!");
            Time.timeScale = 0;//freeze the game on player death
        }
    }

    public void addHealth(int healAmount)
    {
        currentHealth += healAmount;
        if (currentHealth >= maxHealth)
        {
            currentHealth = maxHealth;
        }
    }
}
