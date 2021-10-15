using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject target;
    public bool onRange;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 1, 2);
        onRange = false;
    }

void Spawn()
    {
        Instantiate(target, transform.position, transform.rotation);

        if (onRange == true)
        {
        FindObjectOfType<AudioManager>().Play("Cannon");

            
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            onRange = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            onRange = false;
        }

    }
 

}
