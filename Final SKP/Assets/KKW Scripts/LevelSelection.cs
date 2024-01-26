using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour
{
    public int pageNum;
    public GameObject Level1;
    public GameObject Level2;
    public GameObject Level3;
    public GameObject Level4;
    public GameObject Level5;
        
    public GameObject Level6;
    public GameObject Level7;
    public GameObject Level8;
    public GameObject Level9;
    public GameObject Level10;

    public GameObject page1;
    public GameObject page2;
    public GameObject page3;
    public GameObject page4;

    public GameObject backButton;
    public GameObject nextButton;


    // Start is called before the first frame update
    void Start()
    {
        pageNum = 1;
        Debug.Log("pageNum");
    }
    void Update()
    {
        if (pageNum == 1) 
        {
            Level1.SetActive(true);
            Level2.SetActive(true);
            Level3.SetActive(true);

            Level4.SetActive(false);
            Level5.SetActive(false);
            Level6.SetActive(false);

            Level7.SetActive(false);
            Level8.SetActive(false);
            Level9.SetActive(false);

            Level10.SetActive(false);

            backButton.SetActive(false);
            nextButton.SetActive(true);

            page1.SetActive(true);
            page2.SetActive(false);
            page3.SetActive(false);
            page4.SetActive(false);

        }
        else if (pageNum == 2)
        {
            Level1.SetActive(false);
            Level2.SetActive(false);
            Level3.SetActive(false);

            Level4.SetActive(true);
            Level5.SetActive(true);
            Level6.SetActive(true);

            Level7.SetActive(false);
            Level8.SetActive(false);
            Level9.SetActive(false);

            Level10.SetActive(false);

            backButton.SetActive(true);
            nextButton.SetActive(true);

            page1.SetActive(false);
            page2.SetActive(true);
            page3.SetActive(false);
            page4.SetActive(false);
        }
        else if (pageNum == 3)
        {
            Level1.SetActive(false);
            Level2.SetActive(false);
            Level3.SetActive(false);

            Level4.SetActive(false);
            Level5.SetActive(false);
            Level6.SetActive(false);

            Level7.SetActive(true);
            Level8.SetActive(true);
            Level9.SetActive(true);

            Level10.SetActive(false);

            backButton.SetActive(true);
            nextButton.SetActive(true);

            page1.SetActive(false);
            page2.SetActive(false);
            page3.SetActive(true);
            page4.SetActive(false);
        }
        else if (pageNum == 4)
        {
            Level1.SetActive(false);
            Level2.SetActive(false);
            Level3.SetActive(false);

            Level4.SetActive(false);
            Level5.SetActive(false);
            Level6.SetActive(false);

            Level7.SetActive(false);
            Level8.SetActive(false);
            Level9.SetActive(false);

            Level10.SetActive(true);

            backButton.SetActive(true);
            nextButton.SetActive(false);

            page1.SetActive(false);
            page2.SetActive(false);
            page3.SetActive(false);
            page4.SetActive(true);
        }
    }

    public void NextPage()
    {
        pageNum += 1;
        Debug.Log("pageNum");
    }

    public void BackPage()
    {
        pageNum -= 1;
        Debug.Log("pageNum");
    }

    public void Level1Select()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Level2Select()
    {
        SceneManager.LoadScene("Level2");
    }
    public void Level3Select()
    {
        SceneManager.LoadScene("Level3");
    }
}
