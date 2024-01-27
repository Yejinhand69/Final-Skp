using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level5 : MonoBehaviour
{
    public GameObject bg;
    public GameObject ppl1;
    public GameObject ppl2;
    public GameObject ppl3;
    public GameObject f1;
    public GameObject f2;
    public GameObject f3;
    public GameObject op1;
    public GameObject op2;
    public GameObject op3;
    public GameObject op1s;
    public GameObject op2s;
    public GameObject op3s;
    public GameObject ppl4;
    public GameObject table;
    public GameObject title;
    public Animator animator;
    public GameObject player;

    LevelSelection levelSelection;
    // Start is called before the first frame update
    void Start()
    {
        op1.SetActive(false);
        op2.SetActive(false);
        op3.SetActive(false);
        op1s.SetActive(false);
        op2s.SetActive(false);
        op3s.SetActive(false);
        title.SetActive(false);
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
        yield return new WaitForSeconds(6);
        op1.SetActive(true);
        op2.SetActive(true);
        op3.SetActive(true);
        title.SetActive(true);
    }

    IEnumerator Phase1()
    {
        player.SetActive(false);
        op1.SetActive(false);
        op2.SetActive(false);
        op3.SetActive(false);
        title.SetActive(false);
        op1s.SetActive(true);
        yield return new WaitForSeconds(2);
        f1.SetActive(true);
        f2.SetActive(true);
        f3.SetActive(true);
        yield return new WaitForSeconds(2);
        animator.SetTrigger("Fade_Out");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Level 6");

    }

    IEnumerator Phase2()
    {
        player.SetActive(false);
        op1.SetActive(false);
        op2.SetActive(false);
        op3.SetActive(false);
        title.SetActive(false);
        op2s.SetActive(true);
        yield return new WaitForSeconds(2);
        f2.SetActive(true);
        f3.SetActive(true);
        yield return new WaitForSeconds(2);
        animator.SetTrigger("Fade_Out");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Level 6");
    }

    IEnumerator Phase3()
    {
        player.SetActive(false);
        op1.SetActive(false);
        op2.SetActive(false);
        op3.SetActive(false);
        title.SetActive(false);
        op3s.SetActive(true);
        yield return new WaitForSeconds(4);
        animator.SetTrigger("Fade_Out");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Level 6");
    }

}
