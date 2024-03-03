using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroceryBagScript : MonoBehaviour
{
    private bool isInTrigger = false;
    public bool isGroceryBagTaken = false;
    public DayAndNightScript dayAndNightScript;
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


    void Start()
    {

    }


    void Update()
    {
        if (isInTrigger && Input.GetKeyDown(KeyCode.Space) && !isGroceryBagTaken)
        {
            isGroceryBagTaken=true;
            Debug.Log("PosetAlindi");
        }
    }

}
