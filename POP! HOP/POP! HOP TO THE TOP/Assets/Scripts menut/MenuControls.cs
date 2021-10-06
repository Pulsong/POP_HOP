using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControls : MonoBehaviour
{
    //luodaan käsky jolla ladataan haluttu scene jokaiselle kielelle
    public void PlayGameSuomi()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PlayGameRuotsi()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PlayGameEnglanti()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    //luodaan koodi jolla sovelluksen käyttö lopetetaan
    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
