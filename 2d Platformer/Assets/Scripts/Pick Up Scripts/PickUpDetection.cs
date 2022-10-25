using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpDetection : MonoBehaviour
{
    [SerializeField]
    private int pickUpType;

    private PickupManager pickupManager;
    
    // Start is called before the first frame update
    void Start()
    {
        pickupManager = GameObject.Find("player").GetComponent<PickupManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            pickupManager.PickUpThePickUp(pickUpType);
            Destroy(gameObject);
        }
    }
}
