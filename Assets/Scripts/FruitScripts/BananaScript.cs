using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaScript : MonoBehaviour //Meyve yerine gidip almakla ilgili kodlar
{
    private int maxUsage = 100; //Max Kullanım Sınırı
    private int remainingUsage;
    public GroceryBagScript grocerybagscript;
    public WeighingMachineScript weighingMachineScript;

    public int Banana = 0;

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
                TakeBanana();
                remainingUsage--;
            }
        }
    }

    void TakeBanana()
    {
        Banana++;
            Debug.Log("Muz");
        weighingMachineScript.canWeight = true;
    }
}
