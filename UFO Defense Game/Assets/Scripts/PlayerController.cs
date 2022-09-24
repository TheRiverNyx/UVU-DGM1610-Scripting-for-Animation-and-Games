using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float hInput;

    public float moveSpeed;//speed that the player moves

    public float xRange=22.00f;

    public GameObject laserBolt; //GameObject projectile to shoot 

    public Transform blaster; //point of origin for the laser bolt
    
    // Update is called once per frame
    void Update()
    {
        //set horizontal input to retrieve values from the keyboard keymap Horizontal
        hInput = Input.GetAxis("Horizontal");
        
        //move the player left and right
        transform.Translate(Vector3.right * (hInput * moveSpeed * Time.deltaTime));
        
        //keep player in set bounds
        if (transform.position.x > xRange)//keep player within right wall at set xRange
        {
            transform.position = new Vector3(xRange, transform.position.y,transform.position.z);
        }
        
        if (transform.position.x < -xRange)//keep player within left wall at set -xRange
        {
            transform.position = new Vector3(-xRange, transform.position.y,transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(laserBolt, blaster.transform.position, laserBolt.transform.rotation);//Instantiate laserBolt gameObject at blaster position
        }
        
    }
    //delete any object with a trigger that hits the player
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
