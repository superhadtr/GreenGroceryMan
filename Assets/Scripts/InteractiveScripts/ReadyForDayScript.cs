using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReadyForDayScript : MonoBehaviour
{
    private bool isInTrigger = false;
    public DayAndNightScript dayAndNightScript;
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
    void Update()
    {
        if (isInTrigger && Input.GetKeyDown(KeyCode.Space))
        {
            dayAndNightScript.CurrentLevel++;
            SceneManager.LoadScene("DayTimeScene");
            Debug.Log("SabahOldu");

        }
    }
}
