using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectAnimation : MonoBehaviour
{
    PlayerMovement HuomaaAnim;
    public Animator animaattori;
    void Start()
    {
        HuomaaAnim = GameObject.Find("PoppiKaija").GetComponent<PlayerMovement>();
        animaattori = GetComponent<Animator>();
        
    }
    



// Update is called once per frame
void Update()
    {
        if (HuomaaAnim.KilvenKelloOn == true)
        {
            animaattori.SetBool("KilpiOnValmis",true);
        }
        else
        {
            animaattori.SetBool("KilpiOnValmis", false);
        }


        if (HuomaaAnim.SulkaNull != 0)
        {
            animaattori.SetBool("ToinenSulka", true);
            HuomaaAnim.SulkaNull = 0;
        }
        else
        {
            animaattori.SetBool("ToinenSulka", false);
        }
        if (HuomaaAnim.KilpiNull != 0)
        {
            animaattori.SetBool("ToinenKilpi", true);
            HuomaaAnim.KilpiNull = 0;
        }
        else
        {
            animaattori.SetBool("ToinenKilpi", false);
        }


        if (HuomaaAnim.AjastinOn == true)
        {
            animaattori.SetBool("SulkaOnValmis", true);
        }
        else
        {
            animaattori.SetBool("SulkaOnValmis", false);
        }


    }

}
