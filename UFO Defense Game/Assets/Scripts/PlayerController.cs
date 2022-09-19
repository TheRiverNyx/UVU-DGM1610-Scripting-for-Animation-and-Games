using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float hInput;

    public float moveSpeed;//speed that the player moves

    public float xRange=11.00f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

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
    }
}
