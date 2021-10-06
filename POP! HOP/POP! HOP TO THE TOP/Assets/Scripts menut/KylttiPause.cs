using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KylttiPause : MonoBehaviour
{
    AvaaKyltti kylttiRef;

    public GameObject[] Paperit; 

     public void Start()
    {
        
        kylttiRef = GameObject.Find("KysymysM").GetComponent<AvaaKyltti>();
    }
   public void Resume()
    {
        kylttiRef.IsoKyltti.SetActive(false);
        Time.timeScale = 1f;
    }
   public void Pause()
    {
        kylttiRef.IsoKyltti.SetActive(true);
        Time.timeScale = 0f;
    }

}
