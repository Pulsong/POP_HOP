using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class avaimenGrafiikat : MonoBehaviour
{
    public AIPath aiPath;
    public Animator anim;
    // Kompassi
    Kompassi OnkoTavannutPop;

    // Update is called once per frame
    private void Start()
    {
        anim = GetComponent<Animator>();
        OnkoTavannutPop = GameObject.Find("KompassiParentti").GetComponent<Kompassi>();
    }
    void Update()
    {
        if (aiPath.desiredVelocity.x >= 0.01f)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        else if (aiPath.desiredVelocity.x <= -0.01)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (aiPath.canSearch == false)
            {
            FindObjectOfType<AudioManager>().Play("Jee");

            }
            aiPath.canSearch = true;
            OnkoTavannutPop.vaihdaKohdetta = true;

        }
        if (collision.gameObject.CompareTag("PopMobiili"))
        {
            aiPath.canSearch = false;
            anim.SetBool("Osunut", true);
            FindObjectOfType<AudioManager>().Play("Jee");
        }
        else
        {
            anim.SetBool("Osunut", false);
        }
    }
}
