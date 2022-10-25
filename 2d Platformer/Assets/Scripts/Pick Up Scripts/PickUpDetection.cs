using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpDetection : MonoBehaviour
{
    [SerializeField]
    private int pickUpType;//which pickup this is in a range from 0-9

    private PickupManager pickupManager;
    // Start is called before the first frame update
    void Start()
    {
        pickupManager = GameObject.Find("player").GetComponent<PickupManager>();//reference the pickup manager on the player
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))//only pick up if the other object has tag "Player"
        {
            pickupManager.PickUpThePickUp(pickUpType);//add pickup to inventory
            Destroy(gameObject);//delete pickup
        }
    }
}
