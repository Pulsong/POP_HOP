using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvaaKyltti : MonoBehaviour
{
    // Papereista pit‰‰ tehd‰ taulukko, joka m‰‰ritt‰‰, mik‰ paperi/paperit n‰ytet‰‰n kyseisen kyltin kohdalla.
    public GameObject SuomiPaperi;
    public GameObject RuotsiPaperi;
    public GameObject EnglantiPaperi;
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
            if (MenuControls.ValittuMaa == "Suomi")
            {
            SuomiPaperi.SetActive(true);     // Pist‰‰ kyseisen paperin n‰kyv‰ksi
            }
            else if (MenuControls.ValittuMaa == "Ruotsi")
            {
                RuotsiPaperi.SetActive(true);
            }
            else if (MenuControls.ValittuMaa == "Englanti")
            {
                EnglantiPaperi.SetActive(true);
            }

            //KylttiPause.Pause();
            Avaus.Pause();
        }
    }
}
