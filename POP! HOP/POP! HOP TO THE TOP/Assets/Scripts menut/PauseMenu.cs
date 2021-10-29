using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
   
   public GameObject SuomiPauseMenuUI;
    public GameObject RuotsiPauseMenuUI;
    public GameObject EnglantiPauseMenuUI;

    public void Resume()
    {
        if (MenuControls.ValittuMaa == "Suomi")
        {
        SuomiPauseMenuUI.SetActive(false);
        Time.timeScale = 1f;

        }
        else if (MenuControls.ValittuMaa == "Ruotsi")
        {
            RuotsiPauseMenuUI.SetActive(false);
            Time.timeScale = 1f;
        }
        else if (MenuControls.ValittuMaa == "Englanti")
        {
            EnglantiPauseMenuUI.SetActive(false);
            Time.timeScale = 1f;
        }
    }
    public void Pause()
    {
        if (MenuControls.ValittuMaa == "Suomi")
        {
            SuomiPauseMenuUI.SetActive(true);
            Time.timeScale = 0f;

        }
        else if (MenuControls.ValittuMaa == "Ruotsi")
        {
            RuotsiPauseMenuUI.SetActive(true);
            Time.timeScale = 0f;
        }
        else if (MenuControls.ValittuMaa == "Englanti")
        {
            EnglantiPauseMenuUI.SetActive(true);
            Time.timeScale = 0f;
        }

    }

    public void Return()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;

    }
}
