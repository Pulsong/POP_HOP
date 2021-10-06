using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vesi_movement : MonoBehaviour
{
    private bool dirUp = true;
    public float speed = 2.0f;
    float targetTime = 10f;
    public bool TimerOn;
    public float timer = 0;


    private void Start()
    {
        
        TimerOn = false;

    }

    void Update()
    {
        if (TimerOn == true)
        {
            
            timer += Time.deltaTime;
            if (timer >= targetTime)
            {
                speed += 0.9f;
                TimerOn = false;
                targetTime = 0;
            }
        }

        if (dirUp)
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        

        if (transform.position.y >= 300.0f)
        {
            dirUp = false;
        }

        if (transform.position.y <= -4)
        {
            dirUp = true;
        }
    }
}
