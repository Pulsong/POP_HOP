using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroControls : MonoBehaviour
{
    float timer = 0f;
    float picTime = 5f;

    public GameObject game;
    public GameObject pic;
    
    void Update()
    {
        timer += Time.deltaTime;

        if(timer>=picTime)
        {
            pic.SetActive(false);
            game.SetActive(true);
        }
    }
}
