using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tippuva_taso : MonoBehaviour
{

    public Rigidbody2D rb;
    Vector2 startPos;

    public bool respawns = true;
    public float fallDelay;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startPos = transform.position;
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            rb.isKinematic = false;
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            StartCoroutine(Fall());

        }
    }
    IEnumerator Fall()
    {
        yield return new WaitForSeconds(fallDelay);
        GetComponent<Collider2D>().isTrigger = true;
        yield return 0;

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bounds" && respawns)
        {
            rb.isKinematic = true;
            rb.velocity = new Vector3(0, 0, 0);
            transform.position = startPos;
            GetComponent<Collider2D>().isTrigger = false;

        }
    }

}
