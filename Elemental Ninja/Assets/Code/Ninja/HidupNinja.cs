using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HidupNinja : MonoBehaviour
{
    //si ninja
    [SerializeField] private int health;
    [SerializeField] private int life;
    public GameObject GemOver;
    Animator mati;
    public Timer tiemer;

    

    //hati di ui...
    [SerializeField] private GameObject Hati1;
    [SerializeField] private GameObject Hati2;
    [SerializeField] private GameObject Hati3;
    [SerializeField] private GameObject HatiK1;
    [SerializeField] private GameObject HatiK2;
    [SerializeField] private GameObject HatiK3;

    [SerializeField] private AudioSource lifeAudio;
    [SerializeField] private AudioSource deadAudio;
    
    // Start is called before the first frame update
    void Start()
    {
        life = 3;
        GemOver.gameObject.SetActive(false);
        mati = gameObject.GetComponent<Animator>();
        

        Hati1.gameObject.SetActive(true);
        Hati2.gameObject.SetActive(true);
        Hati3.gameObject.SetActive(true);
        HatiK1.gameObject.SetActive(true);
        HatiK2.gameObject.SetActive(true);
        HatiK3.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Death")
        {
            if (life == 3)
            {
                Hati1.gameObject.SetActive(false);
            }
            if (life == 2)
            {
                Hati2.gameObject.SetActive(false);
            }
            if (life == 1)
            {
                Hati3.gameObject.SetActive(false);
            }

            life--;
            if(life > 0)
            {
                deadAudio.Play();
                LevelChecker.statis.Resp();
                
            }
            if(life == 0)
            {
                mati.SetTrigger("Ded");
                
            
                
                
            }
        }
      
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "hati")
        {
            if(life < 3)
            {
                collision.GetComponent<Hati>().dead(true);
                lifeAudio.Play();
                if (life == 1)
                {
                    Hati2.gameObject.SetActive(true);
                }
                if (life == 2)
                {
                    Hati1.gameObject.SetActive(true);
                }
                life++;
            }
            
            
        }
        if (collision.gameObject.tag == "Api")
        {
            if (life == 3)
            {
                Hati1.gameObject.SetActive(false);
            }
            if (life == 2)
            {
                Hati2.gameObject.SetActive(false);
            }
            if (life == 1)
            {
                Hati3.gameObject.SetActive(false);
            }

            life--;
            if (life > 0)
            {
                deadAudio.Play();

            }
            if (life == 0)
            {
                mati.SetTrigger("Ded");

            }
        }
    }


    private void showGemover()
    {
        GemOver.gameObject.SetActive(true);
        Time.timeScale = 0f;
    }
}
