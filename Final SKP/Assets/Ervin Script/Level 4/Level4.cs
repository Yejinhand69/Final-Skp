using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level4 : MonoBehaviour
{
    public GameObject Option;
    public Animator animator;

    public GameObject player;
    public GameObject playerOpeningDoor;
    public GameObject runningPeople;
    public GameObject newPeopleStanding;

    // Start is called before the first frame update
    void Start()
    {
        Option.SetActive(false);

        player.SetActive(true);
        playerOpeningDoor.SetActive(false);
        runningPeople.SetActive(true);
        newPeopleStanding.SetActive(false);

        StartCoroutine(ShowOptionAfterDelay());
    }

   private IEnumerator ShowOptionAfterDelay()
    {
        yield return new WaitForSeconds(6f);

        Option.SetActive(true);

    }

    public void Option01()
    {
        Option.SetActive(false);

        player.SetActive(false);
        playerOpeningDoor.SetActive(true);
        runningPeople.SetActive(false);
        newPeopleStanding.SetActive(true);

        StartCoroutine(LoadNextLevelWithDelay());
    }

    public void Option02()
    {
        Option.SetActive(false);

        StartCoroutine(LoadNextLevelWithDelay());
    }

    public void Option03()
    {
        Option.SetActive(false);

        StartCoroutine(LoadNextLevelWithDelay());
    }


    private IEnumerator LoadNextLevelWithDelay()
    {
        yield return new WaitForSeconds(2f);
        animator.SetTrigger("Fade_Out");

        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Level 5");
    }

}
