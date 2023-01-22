using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{

float startTime;
public TMP_Text timerText;
public TMP_Text loseText;

void Start()
{
    startTime = Time.time;
}

void Update()
{
    float timePassed = Time.time - startTime;
    if (timePassed < 10)
    {
        timerText.text = string.Format("Time Passed: {0:0.00} seconds", timePassed);
    }
    else
    {
        timerText.gameObject.SetActive(false);
        loseText.gameObject.SetActive(true);


    }
}
}