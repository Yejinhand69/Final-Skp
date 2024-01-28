using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEditor.Progress;
using static UnityEngine.Rendering.DebugUI;

public class Level3 : MonoBehaviour
{
    public GameObject bg;
    public GameObject doorClose;
    public GameObject doorOpen;
    public GameObject carryingFish;
    public GameObject catHouse;
    public GameObject cat1;
    public GameObject diving;
    public GameObject dog;
    public GameObject fish1;
    public GameObject fish2;
    public GameObject giveShark;
    public GameObject happyFace;
    public GameObject sadFace;
    public GameObject holdingCat;
    public GameObject holdingShark;
    public GameObject holdingDog;
    public GameObject uDefault;
    public GameObject gFDefault;
    public GameObject uRunning;
    public GameObject fishTank;
    public GameObject title;
    public GameObject block;
    public Animator animator;

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
    public void Option4()
    {
        StartCoroutine(Phase4());
    }

    IEnumerator Prephase()
    {
        yield return new WaitForSeconds(4);
        uDefault.SetActive(true);
        gFDefault.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        doorClose.SetActive(false);
        doorOpen.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        doorOpen.SetActive(false);
        doorClose.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        block.SetActive(false);
        title.SetActive(true);

    }

    IEnumerator Phase1()
    {
        uDefault.SetActive(false);
        fish1.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        fish1.SetActive(false);
        fish2.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        fish1.SetActive(true);
        fish2.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        fish1.SetActive(false);
        fish2.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        fish1.SetActive(true);
        fish2.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        gFDefault.SetActive(false);
        sadFace.SetActive(true);
        fish1.SetActive(false);
        fish2.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        fish1.SetActive(true);
        fish2.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        fish1.SetActive(false);
        fish2.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        fish1.SetActive(true);
        fish2.SetActive(false);
        animator.SetTrigger("Fade_Out");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Level 4");

    }

    IEnumerator Phase2()
    {
        doorOpen.SetActive(true);
        doorClose.SetActive(false);
        yield return new WaitForSeconds(1);
        uDefault.SetActive(false);
        uRunning.SetActive(true);
        yield return new WaitForSeconds(1);
        uRunning.SetActive(false);
        diving.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        diving.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        diving.SetActive(true);
        carryingFish.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        diving.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        carryingFish.SetActive(false);
        holdingShark.SetActive(true);
        yield return new WaitForSeconds(1);
        gFDefault.SetActive(false);
        happyFace.SetActive(true);
        yield return new WaitForSeconds(1);
        animator.SetTrigger("Fade_Out");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Level 4");
    }

    IEnumerator Phase3()
    {
        cat1.SetActive(false);
        holdingCat.SetActive(true);
        uDefault.SetActive(false);
        yield return new WaitForSeconds(1);
        gFDefault.SetActive(false);
        sadFace.SetActive(true);
        yield return new WaitForSeconds(1);
        animator.SetTrigger("Fade_Out");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Level 4");
    }
    
    IEnumerator Phase4()
    {
        dog.SetActive(false);
        holdingDog.SetActive(true);
        uDefault.SetActive(false);
        yield return new WaitForSeconds(1);
        gFDefault.SetActive(false);
        sadFace.SetActive(true);
        yield return new WaitForSeconds(1);
        animator.SetTrigger("Fade_Out");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Level 4");
    }

}
