using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreenController : MonoBehaviour
{
    public void PlayAgainSuomi()
    {
        SceneManager.LoadScene(LifeSystem.sceneNum);
    }

    public void PlayAgainRuotsi()
    {
        SceneManager.LoadScene(LifeSystem.sceneNum);
    }

    public void PlayAgainEnglanti()
    {
        SceneManager.LoadScene(LifeSystem.sceneNum);
    }

    public void ReturnMenu()
    {
        SceneManager.LoadScene(0);
    }
}
