using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class OrderWindowScript : MonoBehaviour
{
    public OrderScript orderScript;
    public OrangeScript orangeScript;
    public BananaScript bananaScript;
    public StrawberryScript strawberryScript;
    public GameObject CoinSpawn;
    public GroceryBagScript groceryBagScript;
    public WeighingMachineScript weighingMachineScript;
    public DayAndNightScript dayAndNightScript;
    public CustomerTimerScript customerTimerScript;

    private bool isInTrigger = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && dayAndNightScript.isItDay)
        {
            isInTrigger = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isInTrigger = false;
        }
    }

    void Update()
    {
        if (isInTrigger && Input.GetKeyDown(KeyCode.Space) && weighingMachineScript.WeightCheck)
        {
            if (bananaScript.Banana!=orderScript.needBanana)
            {
                OrderWrong();
                
            }
            else if(orangeScript.Orange!=orderScript.needOrange)
            {
                OrderWrong();
            }
            else if (strawberryScript.Strawberry!=orderScript.needStrawberry)
            {
                OrderWrong();
            }
            else
            {
                OrderCompleted();
            }
        }
    }
    void OrderCompleted()
    {
        weighingMachineScript.WeightCheck = false;
        weighingMachineScript.canWeight = false;
        groceryBagScript.isGroceryBagTaken = false;

        orangeScript.Orange = 0;
        bananaScript.Banana = 0;
        strawberryScript.Strawberry = 0;

        dayAndNightScript.CurrentCustomer--;
        customerTimerScript.timeRemaining = 8;
        orderScript.isThereCustomer = false;

        Instantiate(CoinSpawn, transform.position, Quaternion.identity);

        Debug.Log("SiparişTamam");
    }
    void OrderWrong()
    {
        customerTimerScript.timeRemaining = 0;
        dayAndNightScript.CurrentCustomer--;
        groceryBagScript.isGroceryBagTaken = false;
        weighingMachineScript.WeightCheck = false;
        Debug.Log("SiparişYanlış");
    }
}

