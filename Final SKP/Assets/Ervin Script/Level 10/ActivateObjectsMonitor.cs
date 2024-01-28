using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ActivateObjectsMonitor : MonoBehaviour
{
    public GameObject[] objectsToMonitor;
    private int activatedObjectCount = 0;

    //set to false
    public GameObject originPlayer;
    public GameObject originDoc;
    public GameObject closeCeiling;

    //set to true
    public GameObject playerDance;
    public GameObject docDance;
    public GameObject openCeiling;
    public GameObject discoBall;

    public Animator animator;

    private void Start()
    {
        // Initialize the count of activated objects at the start
        foreach (GameObject obj in objectsToMonitor)
        {
            if (obj.activeSelf)
            {
                activatedObjectCount++;
            }
        }
    }

    private void Update()
    {
        // Check for activation status changes in each frame
        CheckActivationStatus();
    }

    private void CheckActivationStatus()
    {
        int newActivatedObjectCount = 0;

        // Count the currently activated objects
        foreach (GameObject obj in objectsToMonitor)
        {
            if (obj.activeSelf)
            {
                newActivatedObjectCount++;
            }
        }

        // Check if the count of activated objects has changed
        if (newActivatedObjectCount != activatedObjectCount)
        {
            activatedObjectCount = newActivatedObjectCount;

            // Trigger something when all six objects are active
            if (activatedObjectCount == 6)
            {
                // Replace the following line with the action you want to perform
                Debug.Log("All six objects are active. Perform your action here!");

                originPlayer.SetActive(false);
                originDoc.SetActive(false);
                closeCeiling.SetActive(false);

                playerDance.SetActive(true);
                docDance.SetActive(true);
                openCeiling.SetActive(true);
                discoBall.SetActive(true);

                StartCoroutine(LoadNextLevelWithDelay());
            }
        }
    }

    private IEnumerator LoadNextLevelWithDelay()
    {
        yield return new WaitForSeconds(1.5f);
        animator.SetTrigger("Fade_Out");

        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("LevelSelection");
    }

}
