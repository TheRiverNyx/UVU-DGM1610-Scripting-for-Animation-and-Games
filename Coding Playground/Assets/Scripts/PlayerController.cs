using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Variables for player controller
    public float speed = 10.00f;
    
    public float rotSpeed = 50.0f;
    
    private Rigidbody playerRB;
    
    //input variables
    private float hInput;

    private float vInput;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Get Keyboard inputs
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");
        //move the Player forward and backward
        transform.Translate(Vector3.forward * (vInput * speed * Time.deltaTime));
        //rotate the player left and right
        transform.Rotate(Vector3.up, hInput * rotSpeed * Time.deltaTime);
    }
}
