using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KylttiPause : MonoBehaviour
{
    AvaaKyltti kylttiRef;

    

     public void Start()
    {
        
        kylttiRef = GameObject.Find("KysymysM").GetComponent<AvaaKyltti>();
    }
   public void Resume()
    {
        kylttiRef.IsoKyltti.SetActive(false);   // Pistää Ison kyltin pois käytön jälkeen.
        Time.timeScale = 1f;
        kylttiRef.SuomiPaperi.SetActive(false);      // Pistää kyltin pois käytön jälkeen
    }
   public void Pause()
    {
        kylttiRef.IsoKyltti.SetActive(true);
        Time.timeScale = 0f;
    }

}
