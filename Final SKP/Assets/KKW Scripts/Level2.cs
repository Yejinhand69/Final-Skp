using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2 : MonoBehaviour
{

    public GameObject bg;
    public GameObject fren1;
    public GameObject fren2;
    public GameObject fren3;
    public GameObject waiter;
    public GameObject player;
    public GameObject openDoor;
    public GameObject closeDoor;
    public GameObject options;
    public GameObject title;
    public GameObject bgTrans;
    public Animator animator;

    LevelSelection levelSelection;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Prephase());
        Debug.Log(levelSelection.lvl2completed);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Option1()
    {
        StartCoroutine(Phase1());
    }
    public void Option2()
    {
        StartCoroutine(Phase2());
    }
    public void Option3()
    {
        StartCoroutine(Phase3());
    }



    IEnumerator Prephase()
    {
        yield return new WaitForSeconds(4);
        fren1.SetActive(true);
        fren2.SetActive(true);
        fren3.SetActive(true);
        yield return new WaitForSeconds(5);
        fren1.SetActive(false);
        fren2.SetActive(false);
        fren3.SetActive(false);
        waiter.SetActive(true); 
        yield return new WaitForSeconds(1);
        options.SetActive(true);
        title.SetActive(true);
        bgTrans.SetActive(true);
    }

    IEnumerator Phase1()
    {
        animator.SetTrigger("Fade_Out");
        yield break;

    }

    IEnumerator Phase2()
    {
        animator.SetTrigger("Fade_Out");
        yield break;
    }

    IEnumerator Phase3()
    {
        animator.SetTrigger("Fade_Out");

        yield break;
    }

}
