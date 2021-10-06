using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    public static PlatformManager instance = null;

    [SerializeField]
    GameObject platformPrefab;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        Instantiate(platformPrefab, new Vector2(-2.5f, -2.5f), platformPrefab.transform.rotation);
        Instantiate(platformPrefab, new Vector2(0f, -2.5f), platformPrefab.transform.rotation);
        Instantiate(platformPrefab, new Vector2(3.5f, -2.5f), platformPrefab.transform.rotation);
    }

    IEnumerator SpawnPlatform(Vector2 spawnPosition)
    {
        yield return new WaitForSeconds(2f);
        Instantiate(platformPrefab, spawnPosition, platformPrefab.transform.rotation);
    }
}
