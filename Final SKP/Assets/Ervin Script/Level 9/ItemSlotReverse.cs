using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlotReverse : MonoBehaviour, IDropHandler
{
    private Vector2 originalPosition;

    public GameObject wrongText;

    private void Awake()
    {
        wrongText.SetActive(false);
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        // Store the original position before the drag starts
        originalPosition = GetComponent<RectTransform>().anchoredPosition;
    }

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("On Drop");
        if (eventData.pointerDrag != null)
        {
            // Set the item's position back to its original position
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = originalPosition;
            StartCoroutine(showWrongText());
        }
    }

    private IEnumerator showWrongText()
    {
        wrongText.SetActive(true);

        yield return new WaitForSeconds(1.0f);

        wrongText.SetActive(false);
    }
}
