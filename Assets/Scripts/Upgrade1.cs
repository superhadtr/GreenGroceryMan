using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class Upgrade1 : MonoBehaviour
{
    private bool isInTrigger = false;
    public int FirstUpgradePrice=35;
    public CoinCounterScript coinCounterScript;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
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
        if (isInTrigger && Input.GetKeyDown(KeyCode.Space))
        {
            CoinCounterScript.instance.FirstUpgrade(FirstUpgradePrice);
            Debug.Log("almayacalis");
        }
    }
}
