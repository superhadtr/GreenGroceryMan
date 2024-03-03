using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightInteractivesScript : MonoBehaviour
{
    public DayAndNightScript dayAndNightScript;
    private Vector3 savedPosition;

    private void Start()
    {
        savedPosition = transform.position;
    }
    void GoToSavedPosition()
    {
        transform.position =savedPosition;
    }

    private void Update()
    {
        if(dayAndNightScript.isItDay)
        {
            transform.position = new Vector3(999, 999, 999);
        }
        else
        {
            GoToSavedPosition();
        }
    }
}
