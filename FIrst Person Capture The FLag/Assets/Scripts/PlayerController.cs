using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    [Header("Player Movement")]
    public float moveSpeed;
    public float jumpForce;
    [Header("Camera")]
    public float lookSensitivity;
    public float maxLookX;
    public float minLookX;

    private float rotX;

    private Camera camera;

    private Rigidbody rigb;

    private void Awake()
    {
        camera = Camera.main;
        rigb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        CameraLook();
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }

    void Move()
    {
        float x = Input.GetAxis("Horizontal")*moveSpeed;//left and right
        float z = Input.GetAxis("Vertical")*moveSpeed;//forward and back

        rigb.velocity = new Vector3(x, rigb.velocity.y, z);
    }

    void CameraLook()
    {
        float y = Input.GetAxis("Mouse X")*lookSensitivity;//look up and down
        rotX += Input.GetAxis("Mouse Y") * lookSensitivity;//look left and right
        
    }

    void Jump()
    {
        Ray ray = new Ray(transform.position, Vector3.down);

        if (Physics.Raycast(ray, 1.1f))
        {
            rigb.AddForce(Vector3.up*jumpForce,ForceMode.Impulse);
        }
    }
}
