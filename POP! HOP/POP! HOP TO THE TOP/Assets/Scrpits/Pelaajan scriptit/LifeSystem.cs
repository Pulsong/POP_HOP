using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LifeSystem : MonoBehaviour
{
    public static int sceneNum;

    public int health;
    public int numOfLeafs;
    public Image[] Leafs;

    public Sprite fullLeafs;

    PlayerMovement OnkoKelloOn;
   

    private bool dead;

    public Animator anim;
    //dmg ajastin
    public bool AikaJonaEiDmg;
    public float AikaRaja = 1f;
    public float DmgAjastin = 0f;

    private void Start()
    {
        sceneNum = SceneManager.GetActiveScene().buildIndex;
        Debug.Log(sceneNum);

        OnkoKelloOn = GetComponent<PlayerMovement>();
        AikaJonaEiDmg = false;
    }
    

   public void Update()
    {
        if (health > numOfLeafs)
        {
            health = numOfLeafs;
        }

        if (AikaJonaEiDmg == true)
        {
        DmgAjastin += Time.deltaTime;
            if (AikaRaja <= DmgAjastin)
            {
                AikaJonaEiDmg = false;
                DmgAjastin = 0;
            }
        }

        for (int i = 0; i < Leafs.Length; i++)
        {
            if (i < health)
            {
                Leafs[i].sprite = fullLeafs;
            }

            if (i < numOfLeafs)
            {
                Leafs[i].enabled = true;
            }
            else
            {
                Leafs[i].enabled = false;
            }
        }

        if (dead == true)
        {

            //sceneNum = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(5);
 
        }
    }
    

    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (OnkoKelloOn.KilvenKelloOn == true || AikaJonaEiDmg == true)
        {

            
        }
        else if (collision.gameObject.CompareTag("Enemy"))
        {
            if (numOfLeafs >= 1) // Estää errorin, ei yritä enää turhia kertoja hakea toimintoa
            {
                numOfLeafs -= 1;
                if (collision.gameObject.CompareTag("Enemy"))
                {
                    AikaJonaEiDmg = true;

                }
                anim.SetTrigger("taking_dmg");
                if (numOfLeafs < 1)
                {
                    dead = true;
                    anim.SetTrigger("Pop_death");
             
                    

                }
            }
        }

        if (collision.gameObject.CompareTag("Leaf"))
        {


            numOfLeafs += 1;

        }

    }


}
