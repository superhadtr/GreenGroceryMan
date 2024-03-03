using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCounterScript : MonoBehaviour //Coin Sayaci
{
    public Upgrade1 upgrade1;
    public CustomerTimerScript customerTimerScript;
    public CharacterMovement characterMovement;
    public CoinScript coinScript;
    public CoinCounterScript coinCounterScript;
    public static CoinCounterScript instance;
    public TMP_Text coinText;
    public int currentCoins = 0;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        coinText.text = " " + currentCoins.ToString();
    }

    public void IncreaseCoins(int v)
    {
        
        currentCoins += v;
        coinText.text = " " + currentCoins.ToString();
    }
    public void FirstUpgrade(int f)
    {
        if(currentCoins >= 35)
        {
            currentCoins -= f;
            coinText.text = " " + currentCoins.ToString();
            characterMovement.movSpeed += 2;
            Debug.Log("HizArtti");
        }
    }
    public void SecondUpgrade(int f)
    {
        if(currentCoins >= 60)
        {
            coinScript.value += 10;
            currentCoins -= f;
            coinText.text = " " + currentCoins.ToString();
            
            Debug.Log("FiyatlarArtti");
        }
    }
}
