using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkeySound : MonoBehaviour
{
    [SerializeField] bool OnRangella;

    void Start()
    {
        OnRangella = true;
    }
    private void Update()
    {
        if (OnRangella == false)
        {
            Debug.Log("Range  = true");
            FindObjectOfType<AudioManager>().Play("Monkey");
        }
  
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            OnRangella = true;

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            OnRangella = false;
        }
        
    }

}
