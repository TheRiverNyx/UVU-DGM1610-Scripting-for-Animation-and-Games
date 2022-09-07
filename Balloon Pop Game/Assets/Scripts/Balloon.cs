using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int clickToPop=3;//how many clicks until the balloon pops

    public float scaleToInflate = 0.10f;//the scale amount a balloon inflates each time it is clicked.
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        clickToPop -= 1;//Reduce clicks by one
        //inflate the balloon every click by a percentage
        transform.localScale+=Vector3.one*scaleToInflate;
        //destroy game object if clickToPop is equal to 0
        if (clickToPop == 0)
        {
            Destroy(gameObject);
        }
    }
}
