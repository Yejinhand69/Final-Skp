using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ToiletClick : MonoBehaviour, IPointerDownHandler
{
    public Animator animator;
    public void OnPointerDown(PointerEventData eventData)
    {
        if(gameObject.CompareTag("Toilet02"))
        {
            Debug.Log("Clicking on 02");
            StartCoroutine(LoadNextLevelWithDelay());
            //Two people will look at you logic
        }

        if (gameObject.CompareTag("Toilet04"))
        {
            Debug.Log("Clicking on 04");
            //You look at 03 logic 
        }

        if (gameObject.CompareTag("Toilet05"))
        {
            Debug.Log("Clicking on 05");
            //Correct logic
        }

    }

    private IEnumerator LoadNextLevelWithDelay()
    {
        yield return new WaitForSeconds(2f);
        animator.SetTrigger("Fade_Out");

        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("SampleScene");

        //load next scene logic
    }

}
