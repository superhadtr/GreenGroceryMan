using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeTravelScript : MonoBehaviour
{
    public Sprite sp1, sp2;
    public DayAndNightScript dayAndNightScript;

    private void Update()
    {
        if (dayAndNightScript.isItDay)
        {
            GetComponent<SpriteRenderer>().sprite = sp1;
        }
        if(!dayAndNightScript.isItDay)
        {
            GetComponent<SpriteRenderer>().sprite = sp2;
        }
        
    }
}
