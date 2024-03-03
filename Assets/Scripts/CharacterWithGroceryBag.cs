using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterWithGroceryBag : MonoBehaviour
{

    public Sprite s1, s2;
    public GroceryBagScript groceryBagScript;

    private void Update()
    {
        if (groceryBagScript.isGroceryBagTaken)
        {
            GetComponent<SpriteRenderer>().sprite = s1;
        }
        if (!groceryBagScript.isGroceryBagTaken)
        {
            GetComponent<SpriteRenderer>().sprite = s2;
        }

    }
}
