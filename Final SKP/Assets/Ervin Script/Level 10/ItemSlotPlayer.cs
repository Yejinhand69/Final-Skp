using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlotPlayer : MonoBehaviour, IDropHandler
{
    
    public GameObject newPlayerSunglasses;
    public GameObject newPlayerClothes;
    public GameObject newPlayerMic;
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("On Drop");
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().localPosition = GetComponent<RectTransform>().localPosition;

            eventData.pointerDrag.SetActive(false);

           if(eventData.pointerDrag.CompareTag("Sunglasses"))
            {
               
                newPlayerSunglasses.SetActive(true);
               ;
            }

            if (eventData.pointerDrag.CompareTag("Clothes"))
            {

                newPlayerClothes.SetActive(true);
            }
            if (eventData.pointerDrag.CompareTag("Mic"))
            {

                newPlayerMic.SetActive(true);
            }

        }
    }
}
