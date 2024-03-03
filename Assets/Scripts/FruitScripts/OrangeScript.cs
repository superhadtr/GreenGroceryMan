using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeScript : MonoBehaviour //Meyve yerine gidip almakla ilgili kodlar
{
    private int maxUsage = 100; //Max Kullanım Sınırı
    private int remainingUsage;
    public GroceryBagScript grocerybagscript;
    public WeighingMachineScript weighingMachineScript;

    public int Orange = 0;

    private bool isInTrigger = false;

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


    void Start()
    {
        remainingUsage = maxUsage;
    }

    void Update()
    {
        if (isInTrigger && Input.GetKeyDown(KeyCode.Space) && grocerybagscript.isGroceryBagTaken)
        {
            if(remainingUsage > 0)
            {
                TakeOrange();
                remainingUsage--;
            }
        }
    }

    void TakeOrange()
    {
        Orange++;
            Debug.Log("Portakal");
        weighingMachineScript.canWeight = true;
    }
}
