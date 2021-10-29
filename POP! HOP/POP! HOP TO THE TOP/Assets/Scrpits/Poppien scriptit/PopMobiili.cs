using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopMobiili : MonoBehaviour
{
    public GameObject POP_MOBIILI;
    public Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PopAvain"))
        {
            Debug.Log("Colliding with PopAvain and PopMobiili");
            POP_MOBIILI.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
            anim.SetBool("OnKutistunut",true);
            FindObjectOfType<AudioManager>().Play("Jee");
        }
        else
        {
            anim.SetBool("OnKutistunut", false);
        }
        
    }
}
