using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkeySound : MonoBehaviour
{
    [SerializeField] bool OnRangella;
    [SerializeField]
    private float MonkeyTimer;
    bool timerOn = false;

    void Start()
    {
        OnRangella = false;
        MonkeyTimer = 0;
        
    }
    private void Update()
    {
        if (OnRangella == true)
        {
            timerOn = true;
        }
            if(timerOn)
            {
            MonkeyTimer += Time.deltaTime;

            if (MonkeyTimer >= 5)
            {
            Debug.Log("Range  = true ja timer toimii");
            FindObjectOfType<AudioManager>().Play("Monkey");
                MonkeyTimer = 0;
            }
            }

  
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            FindObjectOfType<AudioManager>().Play("Monkey");
            OnRangella = true;

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            
            OnRangella = false;
            
            if (OnRangella == false)
            {
                timerOn = false;

            }
            MonkeyTimer = 0;
        }
        
    }

}
