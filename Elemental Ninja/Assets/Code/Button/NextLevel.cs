using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class NextLevel : MonoBehaviour
{
    [SerializeField] private GameObject Thanks;
    private bool starttimer;
    private float tiemer;
    // Start is called before the first frame update
    private void Start()
    {
        starttimer = false;
        tiemer = 5f;
    }



    // Update is called once per frame
    void Update()
    {
        if (starttimer == true)
        {
            tiemer -= 0.009f;
            if (tiemer <= 0)
            {
                starttimer = true;
                tiemer = 5f;
                Thanks.gameObject.SetActive(false);
            }
        }
    }
    public void Nextlvl()
    {
        SceneManager.LoadScene("Level_1");
        Time.timeScale = 1f;
    }
    public void Nextlvl2()
    {
        SceneManager.LoadScene("Level_2");
        Time.timeScale = 1f;
    }

    public void end()
    {
        Thanks.gameObject.SetActive(true);
        starttimer = true;
    }
}
