using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loppuscreeni : MonoBehaviour
{
    private float picTime = 5f;
    private float timer;
    private float endTime = 17f;

    public GameObject loppuKuvaUI;
    public GameObject video;

    // Update is called once per frame
    private void Update()
    {
        timer += Time.deltaTime;

        if(timer>picTime)
        {
            //kuvan poistaminen näkyvistä ja animaation aloitus
            loppuKuvaUI.SetActive(false);

            video.SetActive(true);
            
        }

        if(timer>endTime)
        {
            SceneManager.LoadScene(0);
        }
    }
}
