using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bender : MonoBehaviour
{
    public static Bender statis;
    public GameObject FinishBox;
    public Poin poinCheck;
    public Timer tiemer;

    public GameObject Coret1;
    public GameObject Coret2;
    public GameObject Coret3;

    public GameObject B1;
    public GameObject B2;
    public GameObject B3;

    bool cek;
    float finishctr;

    //playerprefs
    [SerializeField] private string levelapa, statuslocked;
    private int totalbintang,cekbintang;

    // Start is called before the first frame update
    private void Awake()
    {
        //tiemer = GetComponent<Timer>();
    }

    void Start()
    {
        FinishBox.gameObject.SetActive(false);
        Coret1.gameObject.SetActive(false);
        Coret2.gameObject.SetActive(false);
        Coret3.gameObject.SetActive(false);
        cek = false;
        finishctr = 2f;

        B1.gameObject.SetActive(false);
        B2.gameObject.SetActive(false);
        B3.gameObject.SetActive(false);

        cekbintang = PlayerPrefs.GetInt(levelapa);
    }


    // Update is called once per frame
    void Update()
    {
        //Debug.Log(finishctr);
        if (cek == true)
        {
            finishctr -= 0.009f;
            
        }
        if (finishctr <= 0)
        {
            cek = false;
            Coret1.gameObject.SetActive(true);
            if(poinCheck.pscroll == poinCheck.TotalScroll)
            {
                Coret3.gameObject.SetActive(true);
                
            }
            if(tiemer.GetSaatIni() > 0)
            {
               Coret2.gameObject.SetActive(true);
            }

            B1.gameObject.SetActive(true);
            if(poinCheck.pscroll == poinCheck.TotalScroll && tiemer.GetSaatIni() > 0)
            {
                B2.gameObject.SetActive(true);
                B3.gameObject.SetActive(true);
                totalbintang = 3;
            }
            else if(poinCheck.pscroll == poinCheck.TotalScroll || tiemer.GetSaatIni() > 0)
            {
                B2.gameObject.SetActive(true);
                totalbintang = 2;
            }

            if(cekbintang < totalbintang)
            {
                PlayerPrefs.SetInt(levelapa, totalbintang);
            }
            
            
        }
    }
    public void selesai(bool hit)
    {
        if (hit == true)
        {
            FinishBox.gameObject.SetActive(true);
            Time.timeScale = 0f;
            cek = true;
            if(statuslocked != "boollvl3")
            {
                PlayerPrefs.SetInt(statuslocked, 1);
            }
            totalbintang = 1;
        }
    }
}
