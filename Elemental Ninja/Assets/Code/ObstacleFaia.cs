using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleFaia : MonoBehaviour
{
    [SerializeField] private GameObject apinya;
    [SerializeField] private float timer1,timer2;
    private float simpan1,simpan2;
    Animator api;
    //public bool cek;
    // Start is called before the first frame update
    void Start()
    {
        apinya.gameObject.SetActive(false);
        api = gameObject.GetComponent<Animator>();
        simpan1 = timer1;
        simpan2 = timer2;
    }

    // Update is called once per frame
    void Update()
    {
        if (apinya.gameObject.activeSelf == true)
        {

            timer2 = simpan2;
            timer1 -= 0.009f;
            
            if (timer1 <= 0)
            {
                //Debug.Log("gone");
                api.Play("Hilang");
                
                //apinya.gameObject.SetActive(false);

            }
        }
        if (apinya.gameObject.activeSelf == false)
        {

            timer1 = simpan1;
            timer2 -= 0.009f;
            if (timer2 <= 0)
            {
                api.Play("Muncul");
                //Debug.Log("poof");
                //apinya.gameObject.SetActive(true);

            }
        }
    }

    void hilangs()
    {
        apinya.gameObject.SetActive(false);
    }
    void munculs()
    {
        apinya.gameObject.SetActive(true);
    }
}
