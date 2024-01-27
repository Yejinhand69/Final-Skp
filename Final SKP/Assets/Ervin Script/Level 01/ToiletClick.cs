using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ToiletClick : MonoBehaviour, IPointerDownHandler
{
    public Animator animator;

    public GameObject person01LookRight;
    public GameObject person03LookLeft;
    public GameObject person03LookRight;

    public GameObject person02Player;
    public GameObject person04Player;
    public GameObject person05Player;

    private static bool clicked = false;

    private void Awake()
    {
        person01LookRight.SetActive(false);
        person03LookLeft.SetActive(false);
        person03LookRight.SetActive(false);

        person02Player.SetActive(false);
        person04Player.SetActive(false);
        person05Player.SetActive(false);

        clicked = false;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (clicked == false)
        {

            if (gameObject.CompareTag("Toilet02"))
            {
                
                Debug.Log("Clicking on 02");
                person01LookRight.SetActive(true);
                person03LookLeft.SetActive(true);
                person02Player.SetActive(true);

                StartCoroutine(LoadNextLevelWithDelay());
                //Two people will look at you logic
            }

            if (gameObject.CompareTag("Toilet04"))
            {
               
                Debug.Log("Clicking on 04");
                person04Player.SetActive(true);
                person03LookRight.SetActive(true);

                StartCoroutine(LoadNextLevelWithDelay());
                //You look at 03 logic 
            }

            if (gameObject.CompareTag("Toilet05"))
            {
               
                Debug.Log("Clicking on 05");
                person05Player.SetActive(true);

                StartCoroutine(LoadNextLevelWithDelay());
                //Correct logic
            }
        }

        clicked = true;
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
