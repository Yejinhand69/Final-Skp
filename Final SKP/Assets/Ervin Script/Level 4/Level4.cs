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

    public GameObject playerCloseDoor;
    public GameObject people01LookRight;
    public GameObject people02LookRight;

    public GameObject leftDoorClose;
    public GameObject rightDoorClose;

    public GameObject innerLift;
    public GameObject outerLift;
    public GameObject people01;
    public GameObject people02;
    public GameObject leftDoorOpen;
    public GameObject rightDoorOpen;

    // Start is called before the first frame update
    void Start()
    {
        Option.SetActive(false);

        player.SetActive(true);
        playerOpeningDoor.SetActive(false);
        runningPeople.SetActive(true);
        newPeopleStanding.SetActive(false);

        playerCloseDoor.SetActive(false);
        people01LookRight.SetActive(false);
        people02LookRight.SetActive(false);

        leftDoorClose.SetActive(false);
        rightDoorClose.SetActive(false);

        innerLift.SetActive(true);
        outerLift.SetActive(false);
        people01.SetActive(true);
        people02.SetActive(true);
        leftDoorOpen.SetActive(true);
        rightDoorOpen.SetActive(true);

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

        player.SetActive(false);
        playerCloseDoor.SetActive(true);
        people01LookRight.SetActive(true);
        people02LookRight.SetActive(true);

        leftDoorClose.SetActive(true);
        rightDoorClose.SetActive(true);

        StartCoroutine(LoadNextLevelWithDelay());
    }

    public void Option03()
    {
        Option.SetActive(false);

        innerLift.SetActive(false);
        outerLift.SetActive(true);
        people01.SetActive(false);
        people02.SetActive(false);
        runningPeople.SetActive(false);
        player.SetActive(false);
        leftDoorOpen.SetActive(false);
        rightDoorOpen.SetActive(false);

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