using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeBase : MonoBehaviour
{
    private GameManager gm;

    private Renderer flagRend;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        flagRend = GameObject.Find("FlagHome").GetComponent<Renderer>();
        flagRend.enabled = false;
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && gm.hasFlag)//checks if other is player and also has flag
        {
            Debug.Log("Player has reached homebase!");
            gm.PlaceFlag();// runs place flag function
            flagRend.enabled = true;// make flag visible
            
        }
    }
}
