using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    public int totalWkt;//dlm menit
    float saatIni; //waktu yg pas itu, jd float biar deltatiem jalan
 
    bool countdouwn;
    public Text saatIniCtr;
    public static Timer statis;

    public float GetSaatIni()
    {
        return saatIni;
    }

    


    // Start is called before the first frame update
    void Start()
    {
        saatIni = totalWkt; //cuma itung detik;
        countdouwn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (countdouwn)
        {
            saatIni -= Time.deltaTime;
            if(saatIni <= 0)
            {
                TANDATIMER(false);
            }
        }

        

        saatIniCtr.text = Mathf.Round(saatIni).ToString();
        
    }

    public void TANDATIMER(bool cdwn)
    {
        countdouwn = cdwn;
    }
}
