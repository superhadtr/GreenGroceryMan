using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade2 : MonoBehaviour
{
    public bool isUpgrade2Taken = false;
    private bool isInTrigger = false;
    public int SecondUpgradePrice = 60;
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
            isUpgrade2Taken = true;
            CoinCounterScript.instance.SecondUpgrade(SecondUpgradePrice);
            Debug.Log("almayacalis2");
        }
    }
}