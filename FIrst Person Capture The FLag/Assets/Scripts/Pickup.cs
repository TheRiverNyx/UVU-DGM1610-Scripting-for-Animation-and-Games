using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public PickUpType type;

    public int value;
    public GameObject particleSystem;
    [Header("Bobbing Motion")] 
    public float rotationSpeed;
    public float bobSpeed;
    public float bobHeight;
    private bool bobbingUp;
    private Vector3 startPos;
    public AudioClip pickupSFX;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }
    public enum PickUpType
    {
        Health,
        Ammo,
        PowerUp
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerController player = other.GetComponent<PlayerController>();
            switch (type)//decide whether the powerup gives health or ammo
            {
                case PickUpType.Ammo:
                    player.GiveAmmo(value);//calls GiveAmmo
                    break;
                case PickUpType.Health://Calls GiveHealth
                    player.GiveHealth(value);
                    break;
                default:
                    print("PickUp type is not valid");
                    break;
            }

            AudioSource.PlayClipAtPoint(pickupSFX,transform.position);//plays audio clip at position when picked up
            Instantiate(particleSystem);
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        Vector3 offset = (bobbingUp == true ? new Vector3(0, bobHeight / 2, 0) : new Vector3(0, -bobHeight / 2, 0));

        transform.position = Vector3.MoveTowards(transform.position, startPos + offset, bobSpeed * Time.deltaTime);
        if (transform.position == startPos + offset)
            bobbingUp = !bobbingUp;
    }
}
