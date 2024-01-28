using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ItemSlot : MonoBehaviour , IDropHandler
{
    public GameObject correctText;
    public Animator animator;

    private int correctTextCounter = 0;

    private void Awake()
    {
        correctText.SetActive(false);
    }
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("On Drop");
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().localPosition = GetComponent<RectTransform>().localPosition;

            eventData.pointerDrag.SetActive(false);

            StartCoroutine(showCorrectText());
        }
    }

   private IEnumerator showCorrectText()
    {
        correctText.SetActive(true);

        yield return new WaitForSeconds(1.0f);

        correctText.SetActive(false);

        // Increment the counter when correctText is displayed
        correctTextCounter++;

        // Check if correctText has been displayed 4 times
        if (correctTextCounter >= 4)
        {
            // Reset the counter for future use
            correctTextCounter = 0;

            // Start the LoadNextLevelWithDelay coroutine
            StartCoroutine(LoadNextLevelWithDelay());
        }
    }

    private IEnumerator LoadNextLevelWithDelay()
    {
        yield return new WaitForSeconds(1.5f);
        animator.SetTrigger("Fade_Out");

        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Level 10");
    }

}
