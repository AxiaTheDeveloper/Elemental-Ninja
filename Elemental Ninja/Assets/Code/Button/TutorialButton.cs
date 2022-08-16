using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialButton : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject Panel;
    [SerializeField] private GameObject Hal1;
    [SerializeField] private GameObject Hal2;
    [SerializeField] private GameObject Next;
    [SerializeField] private GameObject Prev;
    [SerializeField] private GameObject startbutton;
    bool MulaiLevel;

    

    void Start()
    {
        MulaiLevel = false;
        
        Panel.gameObject.SetActive(true);
        Hal1.gameObject.SetActive(true);
        Next.gameObject.SetActive(true);
        Hal2.gameObject.SetActive(false);
        Prev.gameObject.SetActive(false);
        startbutton.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(MulaiLevel == false)
        {
            Time.timeScale = 0f;
            AudioSource[] audios = FindObjectsOfType<AudioSource>();
            foreach (AudioSource adio in audios)
            {
                
                adio.mute=true;
            }
        }
        if (MulaiLevel == true)
        {
            Panel.gameObject.SetActive(false);
            Hal1.gameObject.SetActive(false);
            Next.gameObject.SetActive(false);
            Hal2.gameObject.SetActive(false);
            Prev.gameObject.SetActive(false);
            startbutton.gameObject.SetActive(false);
        }

    }
    public void next()
    {
        Hal1.gameObject.SetActive(false);
        Next.gameObject.SetActive(false);
        Hal2.gameObject.SetActive(true);
        Prev.gameObject.SetActive(true);
        startbutton.gameObject.SetActive(true);
    }
    public void prev()
    {
        
        Hal1.gameObject.SetActive(true);
        Next.gameObject.SetActive(true);
        Hal2.gameObject.SetActive(false);
        Prev.gameObject.SetActive(false);
        startbutton.gameObject.SetActive(false);
    }

    public void gas()
    {
        MulaiLevel = true;
        
    }

}
