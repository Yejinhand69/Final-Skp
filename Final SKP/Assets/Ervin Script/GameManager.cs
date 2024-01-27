using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    public GameObject episodeImage;

    private void Awake()
    {
        StartCoroutine(DestroyEpisodeImage());

        // If an instance already exists, destroy the new one
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }

        // Set the instance to this script
        instance = this;

        // Don't destroy this GameObject when loading a new scene
        DontDestroyOnLoad(gameObject);
    }

    private IEnumerator DestroyEpisodeImage()
    {
        yield return new WaitForSeconds(4f);

        Destroy(episodeImage);
    }

}
