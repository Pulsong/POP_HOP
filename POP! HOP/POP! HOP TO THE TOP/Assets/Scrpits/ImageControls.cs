using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ImageControls : MonoBehaviour
{
    float timer = 0f;
    float picTime = 3f;
    bool timeOn=false;

    public GameObject game;
    public GameObject pic;

    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            game.SetActive(false);
            pic.SetActive(true);
            timeOn = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (timeOn == true)
        {
            timer += Time.deltaTime;
        }


        if(timer>=picTime)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
