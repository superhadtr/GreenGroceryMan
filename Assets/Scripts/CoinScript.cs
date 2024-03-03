using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public CoinScript coinScript;
    public int value;


    void OnTriggerEnter2D(Collider2D other) //Coin kod ornegi
    {
        if (other.gameObject.CompareTag("Player"))
        {
            CoinCounterScript.instance.IncreaseCoins(value);
            Destroy(gameObject);
        }
    }
}
