using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KuulaScriptVasemmalle : MonoBehaviour
{
    public float speed = 2.0f;


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.otherCollider)
        {
            Destroy(gameObject);
        }
    }
}
