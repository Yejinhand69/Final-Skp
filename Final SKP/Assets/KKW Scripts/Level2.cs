using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2 : MonoBehaviour
{

    public GameObject pic1;
    public GameObject pic2;
    public GameObject pic3;
    public GameObject pic4;
    public GameObject pic5;

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
        //StartCoroutine(Phase1());
        levelSelection.lvl2completed = true;
        Debug.Log(levelSelection.lvl2completed);
        SceneManager.LoadScene("LevelSelection");
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
        yield return new WaitForSeconds(5);
        pic1.SetActive(false);
        pic2.SetActive(false);
        pic3.SetActive(true);
        yield return new WaitForSeconds(5);
        pic5.SetActive(true);
    }

    IEnumerator Phase1()
    {
        yield return new WaitForSeconds(5);
        pic1.SetActive(false);
        pic2.SetActive(false);
        pic3.SetActive(true);
        yield return new WaitForSeconds(5);
        pic5.SetActive(true);
    }

    IEnumerator Phase2()
    {
        yield return new WaitForSeconds(5);
        pic1.SetActive(false);
        pic2.SetActive(false);
        pic3.SetActive(true);
        yield return new WaitForSeconds(5);
        pic5.SetActive(true);
    }

    IEnumerator Phase3()
    {
        yield return new WaitForSeconds(5);
        pic1.SetActive(false);
        pic2.SetActive(false);
        pic3.SetActive(true);
        yield return new WaitForSeconds(5);
        pic5.SetActive(true);
    }

}
