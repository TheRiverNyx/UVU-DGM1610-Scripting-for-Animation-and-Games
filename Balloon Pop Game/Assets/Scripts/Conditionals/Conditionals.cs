using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour
{
    private int howMany = 10;//sets how many to 10

    private float floatNumberThing = 14.76f; //random float number

    private bool isItTrue = true;

    private string statement1 = "this is a statement";

    private string statement2 = "this is also a statement";

    private int counterThing = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (howMany == 10)//if howMany is equal to 10 print howMany
        {
            Console.WriteLine(howMany);
        }

        if (floatNumberThing > 3)//if floatNumberThing is greater than 3 print statement
        {
            Console.WriteLine(floatNumberThing+" is greater than 3");
        }

        if (isItTrue)//if isItTrue == true prints line yes
        {
            Console.WriteLine("yes");
        }

        if (statement1==statement2)//checks if strings are the same
        {
            Console.WriteLine("these statements match");
        }
        else
        {
            Console.WriteLine("These statements dont match");
        }

        if (counterThing<10)//counts to 10 than resets 
        {
            counterThing += 1;
        }
        else
        {
            counterThing = 0;
        }
        
    }
}
