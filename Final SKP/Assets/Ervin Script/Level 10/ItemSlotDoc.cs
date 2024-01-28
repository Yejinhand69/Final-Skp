using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlotDoc : MonoBehaviour, IDropHandler
{

    public GameObject newDocSunglasses;
    public GameObject newDocClothes;
    public GameObject newDocMic;
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("On Drop");
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().localPosition = GetComponent<RectTransform>().localPosition;

            eventData.pointerDrag.SetActive(false);

            if (eventData.pointerDrag.CompareTag("Sunglasses"))
            {

                newDocSunglasses.SetActive(true);
                ;
            }

            if (eventData.pointerDrag.CompareTag("Clothes"))
            {

                newDocClothes.SetActive(true);
            }
            if (eventData.pointerDrag.CompareTag("Mic"))
            {

                newDocMic.SetActive(true);
            }

        }
    }
}
