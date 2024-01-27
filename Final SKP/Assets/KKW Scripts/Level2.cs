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
    public GameObject waiter1;
    public GameObject waiterOp1;
    public GameObject waiterOp2;
    public GameObject waiterOp3;
    public GameObject player;
    public GameObject playerOp3;
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
        options.SetActive(false);
        title.SetActive(false);
        bgTrans.SetActive(false);
        waiter.SetActive(false);
        waiterOp1.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        player.SetActive(false);
        openDoor.SetActive(false);
        closeDoor.SetActive(true);
        yield return new WaitForSeconds(2);
        animator.SetTrigger("Fade_Out");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Level 3");

    }

    IEnumerator Phase2()
    {
        options.SetActive(false);
        title.SetActive(false);
        bgTrans.SetActive(false);
        waiter.SetActive(false);
        waiter.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        player.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        waiter.SetActive(false);
        waiterOp2.SetActive(true);
        yield return new WaitForSeconds(2);
        animator.SetTrigger("Fade_Out");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Level 3");
    }

    IEnumerator Phase3()
    {
        options.SetActive(false);
        title.SetActive(false);
        bgTrans.SetActive(false);
        waiter.SetActive(false);
        waiter.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        player.SetActive(false);
        playerOp3.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        waiter.SetActive(false); 
        waiterOp3.SetActive(true);
        yield return new WaitForSeconds(2);
        animator.SetTrigger("Fade_Out");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Level 3");
    }

}
