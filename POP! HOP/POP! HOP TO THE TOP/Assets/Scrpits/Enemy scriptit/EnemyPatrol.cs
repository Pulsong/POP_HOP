using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyPatrol : MonoBehaviour
{
    public float speed = 2f;
    public Rigidbody2D rb;
    public LayerMask groundLayers;

    public Transform groundCheck;

    
    bool isFacingRigth = true;
    RaycastHit2D hit;



    public void Update()
    {
        hit = Physics2D.Raycast(groundCheck.position, -transform.up, 1f, groundLayers);
 
    }



    public void FixedUpdate()
    {
        if (hit.collider != false)
        {
            if (isFacingRigth)
            {
                rb.velocity = new Vector2(speed, rb.velocity.y);
            }
            else
            {
                rb.velocity = new Vector2(-speed, rb.velocity.y);
            }
        }
        else
        {
            isFacingRigth =! isFacingRigth;
            transform.localScale = new Vector3(-transform.localScale.x,0.15f, 0.2f);
        }
    }
}
