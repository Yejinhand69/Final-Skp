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

    public GameObject Level1Completed;
    public GameObject Level2Completed;
    public GameObject Level3Completed;
    public GameObject Level4Completed;
    public GameObject Level5Completed;

    public GameObject Level6Completed;
    public GameObject Level7Completed;
    public GameObject Level8Completed;
    public GameObject Level9Completed;
    public GameObject Level10Completed;

    public GameObject page1;
    public GameObject page2;
    public GameObject page3;
    public GameObject page4;

    public GameObject backButton;
    public GameObject nextButton;

    public bool lvl1completed = false;
    public bool lvl2completed = false;
    public bool lvl3completed = false;
    public bool lvl4completed = false;
    public bool lvl5completed = false;
    public bool lvl6completed = false;
    public bool lvl7completed = false;
    public bool lvl8completed = false;
    public bool lvl9completed = false;
    public bool lvl10completed = false;

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
            if (!lvl1completed)
            {
                Level1.SetActive(true);
                Level1Completed.SetActive(false);
            }
            else if (lvl1completed)
            {
                Level1.SetActive(false);
                Level1Completed.SetActive(true);
            }

            if (!lvl2completed)
            {
                Level2.SetActive(true);
                Level2Completed.SetActive(false);
            }
            else if (lvl2completed)
            {
                Level2.SetActive(false);
                Level2Completed.SetActive(true);
            }

            if (!lvl3completed)
            {
                Level3.SetActive(true);
                Level3Completed.SetActive(false);
            }
            else if (lvl3completed)
            {
                Level3.SetActive(false);
                Level3Completed.SetActive(true);
            }

            Level4.SetActive(false);
            Level4Completed.SetActive(false);

            Level5.SetActive(false);
            Level5Completed.SetActive(false);

            Level6.SetActive(false);
            Level6Completed.SetActive(false);

            Level7.SetActive(false);
            Level7Completed.SetActive(false);

            Level8.SetActive(false);
            Level8Completed.SetActive(false);

            Level9.SetActive(false);
            Level9Completed.SetActive(false);

            Level10.SetActive(false);
            Level10Completed.SetActive(false);

            backButton.SetActive(false);
            nextButton.SetActive(true);

            page1.SetActive(true);
            page2.SetActive(false);
            page3.SetActive(false);
            page4.SetActive(false);

        }
        else if (pageNum == 2)
        {
            if (!lvl4completed)
            {
                Level4.SetActive(true);
                Level4Completed.SetActive(false);
            }
            else if (lvl4completed)
            {
                Level4.SetActive(false);
                Level4Completed.SetActive(true);
            }

            if (!lvl5completed)
            {
                Level5.SetActive(true);
                Level5Completed.SetActive(false);
            }
            else if (lvl5completed)
            {
                Level5.SetActive(false);
                Level5Completed.SetActive(true);
            }

            if (!lvl6completed)
            {
                Level6.SetActive(true);
                Level6Completed.SetActive(false);
            }
            else if (lvl6completed)
            {
                Level6.SetActive(false);
                Level6Completed.SetActive(true);
            }

            Level1.SetActive(false);
            Level1Completed.SetActive(false);

            Level2.SetActive(false);
            Level2Completed.SetActive(false);

            Level3.SetActive(false);
            Level3Completed.SetActive(false);

            Level7.SetActive(false);
            Level7Completed.SetActive(false);

            Level8.SetActive(false);
            Level8Completed.SetActive(false);

            Level9.SetActive(false);
            Level9Completed.SetActive(false);

            Level10.SetActive(false);
            Level10Completed.SetActive(false);

            backButton.SetActive(true);
            nextButton.SetActive(true);

            page1.SetActive(false);
            page2.SetActive(true);
            page3.SetActive(false);
            page4.SetActive(false);
        }
        else if (pageNum == 3)
        {
            if (!lvl7completed)
            {
                Level7.SetActive(true);
                Level7Completed.SetActive(false);
            }
            else if (lvl7completed)
            {
                Level7.SetActive(false);
                Level7Completed.SetActive(true);
            }

            if (!lvl8completed)
            {
                Level8.SetActive(true);
                Level8Completed.SetActive(false);
            }
            else if (lvl8completed)
            {
                Level8.SetActive(false);
                Level8Completed.SetActive(true);
            }

            if (!lvl9completed)
            {
                Level9.SetActive(true);
                Level9Completed.SetActive(false);
            }
            else if (lvl9completed)
            {
                Level9.SetActive(false);
                Level9Completed.SetActive(true);
            }

            Level1.SetActive(false);
            Level1Completed.SetActive(false);

            Level2.SetActive(false);
            Level2Completed.SetActive(false);

            Level3.SetActive(false);
            Level3Completed.SetActive(false);

            Level4.SetActive(false);
            Level4Completed.SetActive(false);

            Level5.SetActive(false);
            Level5Completed.SetActive(false);

            Level6.SetActive(false);
            Level6Completed.SetActive(false);

            Level10.SetActive(false);
            Level10Completed.SetActive(false);

            backButton.SetActive(true);
            nextButton.SetActive(true);

            page1.SetActive(false);
            page2.SetActive(false);
            page3.SetActive(true);
            page4.SetActive(false);
        }
        else if (pageNum == 4)
        {

            if (!lvl10completed)
            {
                Level10.SetActive(true);
                Level10Completed.SetActive(false);
            }
            else if (lvl10completed)
            {
                Level10.SetActive(false);
                Level10Completed.SetActive(true);
            }
            Level1.SetActive(false);
            Level1Completed.SetActive(false);

            Level2.SetActive(false);
            Level2Completed.SetActive(false);

            Level3.SetActive(false);
            Level3Completed.SetActive(false);

            Level4.SetActive(false);
            Level4Completed.SetActive(false);

            Level5.SetActive(false);
            Level5Completed.SetActive(false);

            Level6.SetActive(false);
            Level6Completed.SetActive(false);

            Level7.SetActive(false);
            Level7Completed.SetActive(false);

            Level8.SetActive(false);
            Level8Completed.SetActive(false);

            Level9.SetActive(false);
            Level9Completed.SetActive(false);



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
        SceneManager.LoadScene("Level 1");
    }
    public void Level2Select()
    {
        SceneManager.LoadScene("Level 2");
    }
    public void Level3Select()
    {
        SceneManager.LoadScene("Level 3");
    }
}
