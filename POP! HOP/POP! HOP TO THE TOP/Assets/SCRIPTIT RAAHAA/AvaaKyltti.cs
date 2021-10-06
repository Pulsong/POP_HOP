using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvaaKyltti : MonoBehaviour
{
    public GameObject IsoKyltti;


    KylttiPause Avaus;
    public float timer = 0f;
    public float timelimit = 2.0f;
    public bool KosketusOn;
    void Start()
    {
        Avaus = GameObject.Find("Kyltit").GetComponent<KylttiPause>();
        KosketusOn = false;
    }

    private void Update()
    {
        if (KosketusOn == true)
        {
            timer += Time.deltaTime;
        }
        if (timelimit < timer)
        {
            timer = 0f;
            KosketusOn = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && timer == 0)
        {
            KosketusOn = true;

            //KylttiPause.Pause();
            Avaus.Pause();
        }
    }
}
