using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Poin : MonoBehaviour
{

    [SerializeField] public int pscroll = 0;
    [SerializeField] public int TotalScroll = 0;
    [SerializeField] private Text scrollCtr;
    [SerializeField] private Text scrollTtlCtr;
    public Timer tiemer;
    public static Poin statis;

    //buat countdown biar music ga ke mute lsg abis slsai
    float counter = 0.5f;
    bool ayo = false;

    [SerializeField] private AudioSource poinAudio;
    [SerializeField] private AudioSource finsihAudio;
    
    // Start is called before the first frame update
    void Start()
    {
        scrollTtlCtr.text = TotalScroll.ToString();
        ayo = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (ayo == true)
        {
            counter -= 0.009f;


        }
        if (counter <= 0)
        {
            AudioSource[] audios = FindObjectsOfType<AudioSource>();
            foreach (AudioSource adio in audios)
            {
                adio.mute = true;

            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.name == "gscroll")
        {
            collision.GetComponent<Scroll>().dead(true);
            poinAudio.Play();
            pscroll++;
            scrollCtr.text = pscroll.ToString();
        }

        if (collision.gameObject.name == "Finsih")
        {
            collision.GetComponent<Bender>().selesai(true);
            finsihAudio.Play();
            ayo = true;
            
            

            tiemer.TANDATIMER(false);
            
        }

        if(collision.gameObject.name == "StartTimer")
        {
            collision.GetComponent<Timer>().TANDATIMER(true);

        }
        




    }

    
}
