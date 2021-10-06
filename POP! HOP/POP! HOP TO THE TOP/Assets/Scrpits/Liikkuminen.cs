using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Liikkuminen : MonoBehaviour
{
    public float movementSpeed;
    public Rigidbody2D rb;

    float mx;
    private void Update(){
        Input.GetAxisRaw("Horizontal");

    }
    private void FixedUpdate()
    {
        Vector2 movement = new Vector2(mx * movementSpeed, rb.velocity.y);

        rb.velocity = movement;
    }
}
