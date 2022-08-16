using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LevelSelections : MonoBehaviour
{
    [SerializeField] private bool unlocked;
    public Image unlockimage;
    public GameObject stars0;
    public GameObject stars1;
    public GameObject stars2;
    public GameObject stars3;


    //mau akses player prefs
    [SerializeField] private string levelapa,statuslocked;
    private int levels, statuses;

    private void Start()
    {
        
        stars0.gameObject.SetActive(false);
        stars1.gameObject.SetActive(false);
        stars2.gameObject.SetActive(false);
        stars3.gameObject.SetActive(false);
    }
    private void Update()
    {
        UpdateLevelImage();
        loadLevel();
        //UpdateLevelStatus();
    }

    //private void UpdateLevelStatus()
    //{
    //int previousLevelNum = int.Parse(gameObject.name) - 1;
    //if(PlayerPrefs.GetInt("Lv" + previousLevelNum) > 0)
    //{
    //unlocked = true;
    //}
    //}

    public void loadLevel()
    {
        levels = PlayerPrefs.GetInt(levelapa);
        statuses = PlayerPrefs.GetInt(statuslocked);
        if (statuses == 1)
        {
            unlocked = true;
        }
        else
        {
            unlocked = false;
        }
    }

    private void UpdateLevelImage()
    {
        if (!unlocked)
        {
            unlockimage.gameObject.SetActive(true);

        }
        else if (unlocked)
        {
            
            unlockimage.gameObject.SetActive(false);
            if (levels == 0)
            {
                stars0.gameObject.SetActive(true);
            }
            else if (levels == 1)
            {
                stars1.gameObject.SetActive(true);
            }
            else if (levels == 2)
            {
                stars2.gameObject.SetActive(true);
            }
            else if (levels == 3)
            {
                stars3.gameObject.SetActive(true);
            }
        }
    }

    public void PressSelection(string _levelName)
    {
        if(unlocked)
        {
            SceneManager.LoadScene(_levelName);
        }
    }
}
