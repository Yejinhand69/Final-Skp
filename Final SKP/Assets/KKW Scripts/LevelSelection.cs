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

    public GameObject Level1Completed;
    public GameObject Level2Completed;
    public GameObject Level3Completed;
    public GameObject Level4Completed;
    public GameObject Level5Completed;

    public GameObject Level6Completed;
    public GameObject Level7Completed;

    public GameObject page1;
    public GameObject page2;
    public GameObject page3;

    public GameObject backButton;
    public GameObject nextButton;

    public bool lvl1completed;
    public bool lvl2completed;
    public bool lvl3completed;
    public bool lvl4completed;
    public bool lvl5completed;
    public bool lvl6completed;
    public bool lvl7completed;

    // Start is called before the first frame update
    void Start()
    {

        pageNum = 1;
        Debug.Log("lvl2" + lvl2completed);
    }
    void Update()
    {
        if (pageNum == 1)
        {
            lvl1completed = PlayerPrefs.GetInt("lvl1completed") == 1;
            Debug.Log("lvl1: " + lvl1completed);
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
            lvl2completed = PlayerPrefs.GetInt("lvl2completed") == 1;
            Debug.Log("lvl2: " + lvl2completed);
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
            lvl3completed = PlayerPrefs.GetInt("lvl3completed") == 1;
            Debug.Log("lvl3: " + lvl3completed);
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
            backButton.SetActive(false);
            nextButton.SetActive(true);

            page1.SetActive(true);
            page2.SetActive(false);
            page3.SetActive(false);

        }
        else if (pageNum == 2)
        {
            lvl4completed = PlayerPrefs.GetInt("lvl4completed") == 1;
            Debug.Log("lvl4: " + lvl4completed);
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
            lvl5completed = PlayerPrefs.GetInt("lvl5completed") == 1;
            Debug.Log("lvl5: " + lvl5completed);
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
            lvl6completed = PlayerPrefs.GetInt("lvl6completed") == 1;
            Debug.Log("lvl6: " + lvl6completed);
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
            backButton.SetActive(true);
            nextButton.SetActive(true);

            page1.SetActive(false);
            page2.SetActive(true);
            page3.SetActive(false);
        }
        else if (pageNum == 3)
        {
            lvl7completed = PlayerPrefs.GetInt("lvl7completed") == 1;
            Debug.Log("lvl7: " + lvl7completed);
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


            backButton.SetActive(true);
            nextButton.SetActive(true);

            page1.SetActive(false);
            page2.SetActive(false);
            page3.SetActive(true);

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
    public void Level4Select()
    {
        SceneManager.LoadScene("Level 4");
    }
    public void Level5Select()
    {
        SceneManager.LoadScene("Level 5");
    }
    public void Level6Select()
    {
        SceneManager.LoadScene("Level 6");
    }
    public void Level7Select()
    {
        SceneManager.LoadScene("Level 7");
    }
}
