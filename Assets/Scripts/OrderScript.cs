using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using System.Threading;

public class OrderScript : MonoBehaviour
{

    public CustomerTimerScript customerTimerScript;
    public DayAndNightScript dayAndNightScript;

    public int needBanana = 0;
    public int needStrawberry = 0;
    public int needOrange = 0;
    public int customerCount = 0;
    public int fruitIndex = 1;

    public TMP_Text CustomerText;


    public bool isThereCustomer = false;


    public string[] fruitTypes2 = { "Strawberry", "Orange", "Banana" };


    void Update()
    {
        if (dayAndNightScript.isItDay)
        {
            if (!isThereCustomer)
            {
                string RandomFruit = fruitTypes2[Random.Range(0, fruitTypes2.Length)];
                int HowMany = Random.Range(1, 3);
                CustomerText.text = HowMany.ToString() + " " + RandomFruit;

                isThereCustomer = true;
                customerTimerScript.timeIsRunning = true;

                if (HowMany == 1)
                {
                    if (RandomFruit == "Strawberry")
                    {
                        needStrawberry = 1;
                        needBanana = 0;
                        needOrange = 0;
                        Debug.Log("Çilekİstiyorum");
                    }
                    else if (RandomFruit == "Orange")
                    {
                        needOrange = 1;
                        needBanana = 0;
                        needStrawberry = 0;
                        Debug.Log("Portakalİstiyorum");
                    }
                    else if (RandomFruit == "Banana")
                    {
                        needOrange = 0;
                        needBanana = 1;
                        needStrawberry = 0; ;
                        Debug.Log("Muzİstiyorum");
                    }
                }
                else if (HowMany == 2)
                {
                    if (RandomFruit == "Strawberry")
                    {
                        needStrawberry = 2;
                        needBanana = 0;
                        needOrange = 0;
                        Debug.Log("2Çilekİstiyorum");
                    }
                    else if (RandomFruit == "Orange")
                    {
                        needOrange = 2;
                        needBanana = 0;
                        needStrawberry = 0;
                        Debug.Log("2Portakalİstiyorum");
                    }
                    else if (RandomFruit == "Banana")
                    {
                        needOrange = 0;
                        needBanana = 2;
                        needStrawberry = 0;
                        Debug.Log("2Muzİstiyorum");
                    }
                }

            }
            else if (customerTimerScript.timeRemaining <= 0) //Süre biterse
            {
                Debug.Log("MüşteriKaçtı");
                isThereCustomer = false;
                dayAndNightScript.CurrentCustomer--;
                CustomerText.text = "";
                customerTimerScript.timeRemaining=8;
            }
            else if (dayAndNightScript.CurrentCustomer == 0)
            {
                Debug.Log("MüşteriKalmadı");
                CustomerText.gameObject.SetActive(false);
                customerTimerScript.timeIsRunning=false;
                dayAndNightScript.isTurnEnded = true;
            }
        }
    }
}

