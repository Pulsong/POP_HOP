using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskuKelloScript : MonoBehaviour
{
    Vesi_movement hidastaVedenNopeutta;


    private void Start()
    {
        hidastaVedenNopeutta = GameObject.Find("Vesi").GetComponent<Vesi_movement>();
        hidastaVedenNopeutta.TimerOn = false;
    }




         void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
               hidastaVedenNopeutta.TimerOn = true;
                hidastaVedenNopeutta.timer = 0;
                hidastaVedenNopeutta.speed -= 0.9f;
                Destroy(gameObject);
        }
        }
    
}
