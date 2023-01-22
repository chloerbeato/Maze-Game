using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoffeeArea : MonoBehaviour
{
    public TMP_Text winText;
    public TMP_Text loseText;
    float startTime;
    //public TMP_Text timerText;

    void Start()
    {
        startTime = Time.time;
        winText.gameObject.SetActive(false);
        loseText.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       // if (collision.CompareTag("Player"))
       // {
           // if (Time.time - startTime <= timeLimit)
           // {
             //   winText.gameObject.SetActive(true);
                //timerText.gameObject.SetActive(false);
         //   }
          //  else
          //  {
              //  loseText.gameObject.SetActive(true);
           // }
       // }
    }
}
