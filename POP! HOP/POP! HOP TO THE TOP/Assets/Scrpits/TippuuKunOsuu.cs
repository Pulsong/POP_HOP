using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TippuuKunOsuu : MonoBehaviour
{
    public Rigidbody2D rb;
    Vector2 startPos;
    public float fallDelay;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            rb.isKinematic = false;
            rb.velocity = new Vector3(0, 0, 0);
            GetComponent<Collider2D>().isTrigger = false;

        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject)
        {

 
            Destroy(gameObject);

        }
    }





}
