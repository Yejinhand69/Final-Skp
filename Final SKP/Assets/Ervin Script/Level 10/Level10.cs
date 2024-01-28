using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level10 : MonoBehaviour
{
    public GameObject openShelf;
    public GameObject mic01;
    public GameObject mic02;

    private void Awake()
    {
        openShelf.SetActive(false);
        mic01.SetActive(false);
        mic02.SetActive(false);
    }

    public void clickOnShelf()
    {
        openShelf.SetActive(true);
        mic01.SetActive(true);
        mic02.SetActive(true);
    }
}
