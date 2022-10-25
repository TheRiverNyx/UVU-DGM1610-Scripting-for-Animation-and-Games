using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDropDown : MonoBehaviour
{
    private PlatformEffector2D effector2D;

    public float waitTime;
    // Start is called before the first frame update
    void Start()
    {
        effector2D = GetComponent<PlatformEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //resets the wait time when key is released
        if (Input.GetKeyUp(KeyCode.DownArrow)||Input.GetKeyUp(KeyCode.S))
        {
            waitTime = 0.5f;
        }
        //flipping effector down
        if (Input.GetKey(KeyCode.DownArrow)||Input.GetKey(KeyCode.S))
        {
            if (waitTime <= 0)
            {
                effector2D.rotationalOffset = 180f;
                waitTime = 0.5f;
            }
            else
            {
                waitTime -= Time.deltaTime;//reduces waittime over time
            }
        }
        //flip effector back up
        if (Input.GetKey(KeyCode.UpArrow)||Input.GetKey(KeyCode.W))
        {
            effector2D.rotationalOffset = 0;
        }
    }
}
