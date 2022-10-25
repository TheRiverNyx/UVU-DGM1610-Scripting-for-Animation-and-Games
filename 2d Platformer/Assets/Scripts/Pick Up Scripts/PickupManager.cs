using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class PickupManager : MonoBehaviour
{
    [SerializeField]
    private string[] pickups;
    
    //start with 0 pickups
    private int pickUp1Amount;
    private int pickUp2Amount;
    private int pickUp3Amount ;
    private int pickUp4Amount;
    private int pickUp5Amount;
    private int pickUp6Amount;
    private int pickUp7Amount;
    private int pickUp8Amount;
    private int pickUp9Amount;
    private int pickUp0Amount;
    
    //reference the text for the pickup counters
    public TextMeshProUGUI pickUp1Text;
    public TextMeshProUGUI pickUp2Text;
    public TextMeshProUGUI pickUp3Text;
    public TextMeshProUGUI pickUp4Text;
    public TextMeshProUGUI pickUp5Text;
    public TextMeshProUGUI pickUp6Text;
    public TextMeshProUGUI pickUp7Text;
    public TextMeshProUGUI pickUp8Text;
    public TextMeshProUGUI pickUp9Text;
    public TextMeshProUGUI pickUp0Text;
    
    // Start is called before the first frame update
    
    /*void Start()
    {

    }*/

    private void Update()
    {
        //detects if any number key on the top of the alphanumeric keyboard is pressed
        if (Input.GetKeyDown(KeyCode.Alpha0)||Input.GetKeyDown(KeyCode.Alpha1)||Input.GetKeyDown(KeyCode.Alpha2)||Input.GetKeyDown(KeyCode.Alpha3)||Input.GetKeyDown(KeyCode.Alpha4)||Input.GetKeyDown(KeyCode.Alpha5)||Input.GetKeyDown(KeyCode.Alpha6)||Input.GetKeyDown(KeyCode.Alpha7)||Input.GetKeyDown(KeyCode.Alpha8)||Input.GetKeyDown(KeyCode.Alpha9))
        {
            UsePickUp(Input.inputString);//Uses corresponding pickup
        }
    }

    public void PickUpThePickUp(int pickUpType)//adds the pickup to player inventory
    {
        switch (pickUpType)
        {
            case 1:
                pickUp1Amount += 1;
                UpdatePickUpText(pickUp1Text,pickUp1Amount);
                break;
            case 2:
                pickUp2Amount += 1;
                UpdatePickUpText(pickUp2Text,pickUp2Amount);
                break;
            case 3:
                pickUp3Amount += 1;
                UpdatePickUpText(pickUp3Text,pickUp3Amount);
                break;
            case 4:
                pickUp4Amount += 1;
                UpdatePickUpText(pickUp4Text,pickUp4Amount);
                break;
            case 5:
                pickUp5Amount += 1;
                UpdatePickUpText(pickUp5Text,pickUp5Amount);
                break;
            case 6:
                pickUp6Amount += 1;
                UpdatePickUpText(pickUp6Text,pickUp6Amount);
                break;
            case 7:
                pickUp7Amount += 1;
                UpdatePickUpText(pickUp7Text,pickUp7Amount);
                break;
            case 8:
                pickUp8Amount += 1;
                UpdatePickUpText(pickUp8Text,pickUp8Amount);
                break;
            case 9:
                pickUp9Amount += 1;
                UpdatePickUpText(pickUp9Text,pickUp9Amount);
                break;
            case 0:
                pickUp0Amount += 1;
                UpdatePickUpText(pickUp0Text,pickUp0Amount);
                break;
            default:
                Debug.Log("not a valid pickup ID");
                break;
        }
    }

    private void UsePickUp(string input)//activates pickups in player inventory
    {
        switch (input)//switch statement to use selected pick up
        {
            case "1":
                PickUp1();
                break;
            case "2":
                PickUp2();
                break;
            case "3":
                PickUp3();
                break;
            case "4":
                PickUp4();
                break;
            case "5":
                PickUp5();
                break;
            case "6":
                PickUp6();
                break;
            case "7":
                PickUp7();
                break;
            case "8":
                PickUp8();
                break;
            case "9":
                PickUp9();
                break;
            case "0":
                PickUp0();
                break;
            default:
                Debug.Log("Error! Not a valid pick up");
                break;
        }
    }

    private void UpdatePickUpText(TextMeshProUGUI pickUpText, int pickUpAmount)//updates pickup text
    {
        pickUpText.text = "" + pickUpAmount;
    }

    //individual pickup functions that also remove pickup from inventory when used
    //Debug.Log is just filler until actual pickup functions are added 
    private void PickUp1()
    {
        if (pickUp1Amount > 0)
        {
            pickUp1Amount -= 1;
            UpdatePickUpText(pickUp1Text,pickUp1Amount);
            Debug.Log("Used Pick Up Number1");
        }
    }

    private void PickUp2()
    {
        if (pickUp2Amount > 0)
        {
            pickUp2Amount -= 1;
            UpdatePickUpText(pickUp2Text,pickUp2Amount);
            Debug.Log("Used Pick Up Number2");
        }
    }
    private void PickUp3()
    {
        if (pickUp3Amount > 0)
        {
            pickUp3Amount -= 1;
            UpdatePickUpText(pickUp3Text,pickUp3Amount);
            Debug.Log("Used Pick Up Number3");
        }
    }
    private void PickUp4()
    {
        if (pickUp4Amount > 0)
        {
            pickUp4Amount -= 1;
            UpdatePickUpText(pickUp4Text,pickUp4Amount);
            Debug.Log("Used Pick Up Number4");
        }
    }
    private void PickUp5()
    {
        if (pickUp5Amount > 0)
        {
            pickUp5Amount -= 1;
            UpdatePickUpText(pickUp5Text,pickUp5Amount);
            Debug.Log("Used Pick Up Number5");
        }
    }
    private void PickUp6()
    {
        if (pickUp6Amount > 0)
        {pickUp6Amount -= 1;
            UpdatePickUpText(pickUp6Text,pickUp6Amount);
            Debug.Log("Used Pick Up Number6");
        }
    }
    private void PickUp7()
    {
        if (pickUp7Amount > 0)
        {
            pickUp7Amount -= 1;
            UpdatePickUpText(pickUp7Text,pickUp7Amount);
            Debug.Log("Used Pick Up Number7");
        }
    }
    private void PickUp8()
    {
        if (pickUp8Amount > 0)
        {
            pickUp8Amount -= 1;
            UpdatePickUpText(pickUp8Text,pickUp8Amount);
            Debug.Log("Used Pick Up Number8");
        }
    }
    private void PickUp9()
    {
        if (pickUp9Amount > 0)
        {
            pickUp9Amount -= 1;
            UpdatePickUpText(pickUp9Text,pickUp9Amount);
            Debug.Log("Used Pick Up Number9");
        }
    }
    private void PickUp0()
    {
        if (pickUp0Amount > 0)
        {
            pickUp0Amount -= 1;
            UpdatePickUpText(pickUp0Text,pickUp0Amount);
            Debug.Log("Used Pick Up Number0");
        }
    }
}
