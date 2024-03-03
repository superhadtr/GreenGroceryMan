using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DayAndNightScript : MonoBehaviour
{
    public Upgrade1 upgrade1;
    public NightInteractivesScript nightInteractivesScript;
    public BananaScript bananaScript;
    public OrangeScript orangeScript;
    public StrawberryScript strawberryScript;
    public static DayAndNightScript Level;
    public static DayAndNightScript Customer;
    public CoinCounterScript coinCounterScript;
    public int CurrentLevel = 0;
    public int CurrentCustomer = 0;
    private bool isInTrigger = false;
    public bool isItDay = false;
    public bool isTurnEnded = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isInTrigger = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isInTrigger = false;
        }
    }

    void Start()
    {
        CurrentCustomer = CurrentLevel + 5;
        Debug.Log(CurrentLevel);
    }

    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            CurrentCustomer--;
            Debug.Log("MusteriAzaldi");
        }


        if (isInTrigger && Input.GetKeyDown(KeyCode.Space)) //Sabah Akşam döngü butonu
        {
             if(!isItDay) //Tuşa basılınca Sabah yapar
             {
                DayTime();
             }
             else if (isItDay && CurrentCustomer == 0) //  Tuşa basılınca müşteri yoksa Akşam yapar
            {
                NightTime();   
             }
        }
    }
    
    void DayTime() //Sabahken oyuncu rounda başlayacak, müşteriler gelecek, level atlayacak
    {
        CurrentCustomer = CurrentLevel + 5;
        CurrentLevel++;
        isItDay = true;
        isTurnEnded = false;


    }

    void NightTime() //Akşam oyuncu satın almalar yapabilecek ve yeni rounda hazırlanacak, müşteri gelmeyecek
    {
        isItDay = false;
        Debug.Log("Aksam");
    }
}
