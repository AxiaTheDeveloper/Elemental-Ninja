using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetSaveFiles : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ResetPanel;
    public GameObject Texts;
    private bool resetdone;
    private float timer;
    void Start()
    {
        ResetPanel.gameObject.SetActive(false);
        Texts.gameObject.SetActive(false);
        resetdone = false;
        timer = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        if(resetdone == true)
        {
            timer -= 0.009f;
        }
        if(timer <= 0)
        {
            Texts.gameObject.SetActive(false);
            timer = 5f;
        }
    }
    public void buka()
    {
        Debug.Log("OPEN");
        ResetPanel.gameObject.SetActive(true);
    }
    public void tutup()
    {
        ResetPanel.gameObject.SetActive(false);
    }
    public void Resetfile()
    {
        PlayerPrefs.SetInt("boolTutorial", 1);
        PlayerPrefs.SetInt("LevelTutorial", 0);
        PlayerPrefs.SetInt("boollvl1", 0);
        PlayerPrefs.SetInt("Level1", 0);
        PlayerPrefs.SetInt("boollvl2", 0);
        PlayerPrefs.SetInt("Level2", 0);
        Texts.gameObject.SetActive(true);
        resetdone = true;
    }
}
