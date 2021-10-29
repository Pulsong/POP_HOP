using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knockback_enemy : MonoBehaviour
{
    public float knockbackPower = 100;
    public float knockbackDuration = 1;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(PlayerMovement.instance.Knockback(knockbackDuration, knockbackPower, this.transform));
        }
    }

}
