using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private bool dirRight = true;
    public float speed = 2.0f;

    void Update()
    {
        if (dirRight)
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        else
            transform.Translate(-Vector2.right * speed * Time.deltaTime);

        if (transform.position.x >= 4.0f)
        {
            dirRight = false;
        }

        if (transform.position.x <= -4)
        {
            dirRight = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.CompareTag("Bounds"))
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
