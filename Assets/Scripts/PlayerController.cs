using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public GameObject player;
    public GameObject coffee;
    public TMP_Text winText;
    public TMP_Text loseText;
    public TMP_Text timerText;
    public AudioClip winMusic;
    public AudioClip loseMusic;
    AudioSource audioSource;
    public AudioSource winLoseMusic;
    public GameObject butterfliesEffectPrefab;

    

    private float startTime;

    void Start()
    {
        startTime = Time.time;
        winText.gameObject.SetActive(false);
        loseText.gameObject.SetActive(false);
        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySound(AudioClip clip)
{
    audioSource.PlayOneShot(clip);
}
   
   void Update()
   {
       float horizontal = Input.GetAxis("Horizontal");
       float vertical = Input.GetAxis("Vertical");
       Vector2 position = transform.position;
       position.x = position.x + 8.0f * horizontal * Time.deltaTime;
       position.y = position.y + 8.0f * vertical * Time.deltaTime;
       transform.position = position;
       float timePassed = Time.time - startTime;

     if (timePassed < 10)
    {
        timerText.text = string.Format("{0:0.00} seconds", timePassed);
    }
    else
    {
        timerText.gameObject.SetActive(false);
       // loseText.gameObject.SetActive(true);
    }

    }
     private void OnTriggerEnter2D(Collider2D collision)
    {
        float timePassed = Time.time - startTime;

        if (collision.CompareTag("Coffee"))
        {
            if (timePassed < 10)
            {
                winText.gameObject.SetActive(true);
                timerText.gameObject.SetActive(false);
                loseText.gameObject.SetActive(false);
                 winLoseMusic.clip = winMusic;
                 winLoseMusic.Play(); 
                GameObject butterfliesEffectObject = Instantiate(butterfliesEffectPrefab, transform.position, Quaternion.identity);
            }
            else
            {
                loseText.gameObject.SetActive(true);
                 winLoseMusic.clip = loseMusic;
                 winLoseMusic.Play();
            }
        }
    
    }
   }
