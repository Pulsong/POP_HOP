using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Side_enemy_movement : MonoBehaviour
{

    private bool dirRight = true;
    public float speed = 2.0f;


    void Update()
    {
        if (dirRight)
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        else
            transform.Translate(-Vector2.right * speed * Time.deltaTime);

        if (transform.position.x >= 50.0f)
        {
            dirRight = false;
            transform.localScale = new Vector3(0.25f, 0.23f, 0f);
        }

        if (transform.position.x <= -4)
        {
            dirRight = true;
            transform.localScale = new Vector3(-0.25f, 0.23f, 0f);

        }


    }


}
