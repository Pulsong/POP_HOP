using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteButton : MonoBehaviour
{
    public AudioSource music;
    public GameObject on;
    public GameObject off;
    
    // Start is called before the first frame update
    
    public void MuteOn()
    {
        music.playOnAwake=false;
        off.SetActive(true);
        on.SetActive(false);
    }

    // Update is called once per frame
    public void MuteOff()
    {
        music.playOnAwake = true;
        on.SetActive(true);
        off.SetActive(false);
    }
}
