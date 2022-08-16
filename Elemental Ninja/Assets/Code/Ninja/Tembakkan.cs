using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tembakkan : MonoBehaviour
{
    public Transform Shuriken;
    //ini yg nembak
    public GameObject S_api;
    public GameObject S_air;
    public GameObject S_lis;
    public GameObject S_tnm;

    //ini yg di ui ganti ganti
    public GameObject api;
    public GameObject air;
    public GameObject lis;
    public GameObject tnm;

    Animator atek;

    [SerializeField] private AudioSource Tembakaudio;
    [SerializeField] private AudioSource gantiAudio;

    int n = 0;//0-api,1-es,2-listrik,3-tanaman
    // Start is called before the first frame update
    void Start()
    {
        api.gameObject.SetActive(true);
        air.gameObject.SetActive(false);
        lis.gameObject.SetActive(false);
        tnm.gameObject.SetActive(false);
        atek = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        gantih();
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Tembakaudio.Play();
            atek.SetTrigger("Atk");
            if(atek.GetCurrentAnimatorStateInfo(0).IsName("Atk") == false)
            {
                Tembak();
            }
            
      
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            gantiAudio.Play();
            n++;
            if (n == 4)
            {
                n = 0;
            }

        }
        
    }

    private void Tembak()
    {
        
        if (n == 0)
        {
            Instantiate(S_api, Shuriken.position, Shuriken.rotation);
        }
        if (n == 1)
        {
            Instantiate(S_air, Shuriken.position, Shuriken.rotation);
        }
        if (n == 2)
        {
            Instantiate(S_lis, Shuriken.position, Shuriken.rotation);
        }
        if (n == 3)
        {
            Instantiate(S_tnm, Shuriken.position, Shuriken.rotation);
        }

    }

    

    private void gantih()
    {

        if (n == 0)
        {
            api.gameObject.SetActive(true);
            air.gameObject.SetActive(false);
            lis.gameObject.SetActive(false);
            tnm.gameObject.SetActive(false);
        }
        if (n == 1)
        {
            api.gameObject.SetActive(false);
            air.gameObject.SetActive(true);
            lis.gameObject.SetActive(false);
            tnm.gameObject.SetActive(false);
        }
        if (n == 2)
        {
            api.gameObject.SetActive(false);
            air.gameObject.SetActive(false);
            lis.gameObject.SetActive(true);
            tnm.gameObject.SetActive(false);
        }
        if (n == 3)
        {
            api.gameObject.SetActive(false);
            air.gameObject.SetActive(false);
            lis.gameObject.SetActive(false);
            tnm.gameObject.SetActive(true);
        }
    }
}
