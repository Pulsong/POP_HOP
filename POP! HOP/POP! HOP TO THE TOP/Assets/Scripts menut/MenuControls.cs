using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControls : MonoBehaviour
{
    public float IntroTimer = 0;
    public bool IntroStart;
    public GameObject kuva;
    public bool StartPicture;
    public static string ValittuMaa;
    public GameObject audioManager;

    private void Start()
    {
        IntroStart = false;
        kuva.SetActive(false);
        StartPicture = false;
    }
    public void Update()
    {
        if (StartPicture == true)
        {
        IntroTimer += Time.deltaTime;
        audioManager.SetActive(false);

        }
        if (IntroTimer >= 2.5)
        {
            IntroStart = true;
            if (ValittuMaa == "Suomi")
            {
                PlayGameSuomi();
                
            }
            if (ValittuMaa == "Ruotsi")
            {
                PlayGameRuotsi();
                
            }
            if (ValittuMaa == "Englanti")
            {
                PlayGameEnglanti();
                
            }
        }
    }

    //luodaan käsky jolla ladataan haluttu scene jokaiselle kielelle
    public void PlayGameSuomi()
    {
        ValittuMaa = "Suomi";
        StartPicture = true;
        kuva.SetActive(true);
        if (IntroStart == true)
        {
        SceneManager.LoadScene(1);
        }
    }

    public void PlayGameRuotsi()
    {
        ValittuMaa = "Ruotsi";
        StartPicture = true;
        kuva.SetActive(true);
        if (IntroStart == true)
        {
            SceneManager.LoadScene(1);
        }
    }

    public void PlayGameEnglanti()
    {
        ValittuMaa = "Englanti";
        StartPicture = true;
        kuva.SetActive(true);
        if (IntroStart == true)
        {
            SceneManager.LoadScene(1);
        }
    }
    //luodaan koodi jolla sovelluksen käyttö lopetetaan
    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
