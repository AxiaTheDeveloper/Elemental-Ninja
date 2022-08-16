using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLevelButton : MonoBehaviour
{
    [SerializeField] private GameObject Panel;
    [SerializeField] private GameObject Hal1;
    [SerializeField] private GameObject startbutton;
    bool MulaiLevel;



    void Start()
    {
        MulaiLevel = false;

        Panel.gameObject.SetActive(true);
        Hal1.gameObject.SetActive(true);
        startbutton.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (MulaiLevel == false)
        {
            Time.timeScale = 0f;
            AudioSource[] audios = FindObjectsOfType<AudioSource>();
            foreach (AudioSource adio in audios)
            {

                adio.mute = true;
            }
        }
        if (MulaiLevel == true)
        {
            Panel.gameObject.SetActive(false);
            Hal1.gameObject.SetActive(false);
            startbutton.gameObject.SetActive(false);
        }

    }
   

    public void gas()
    {
        MulaiLevel = true;

    }
}
