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
        kylttiRef.IsoKyltti.SetActive(false);   // Pist�� Ison kyltin pois k�yt�n j�lkeen.
        Time.timeScale = 1f;
        kylttiRef.SuomiPaperi.SetActive(false);      // Pist�� kyltin pois k�yt�n j�lkeen
    }
   public void Pause()
    {
        kylttiRef.IsoKyltti.SetActive(true);
        Time.timeScale = 0f;
    }

}
