using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeighingMachineScript : MonoBehaviour
{

    private bool isInTrigger = false;
    public bool WeightCheck = false;
    public bool canWeight = false;
    public DayAndNightScript dayAndNightScript;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")&&dayAndNightScript.isItDay)
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
        if (isInTrigger && Input.GetKeyDown(KeyCode.Space) && canWeight)
        {
            WeightCheck = true;
            Debug.Log("Tartıldı");
            
        }
    }

}
