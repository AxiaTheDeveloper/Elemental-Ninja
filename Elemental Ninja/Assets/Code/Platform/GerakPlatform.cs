using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerakPlatform : MonoBehaviour
{

    [SerializeField] private Transform atas, bawah, awal;
    [SerializeField] private float kecepatanPlt, timer;
    private float simpan;
    Vector3 tujuan;
    
    // Start is called before the first frame update
    void Start()
    {
        tujuan = awal.position;
        simpan = timer;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position == atas.position)
        {
            
            timer -= 0.009f;
            if (timer <= 0)
            {
                tujuan = bawah.position;
                timer = simpan;
            }
        }
        else if (transform.position == bawah.position)
        {
            timer -= 0.009f;
            if (timer <= 0)
            {
                tujuan = atas.position;
                timer = simpan;
            }
        }

        //gerak
        transform.position = Vector3.MoveTowards(transform.position, tujuan, kecepatanPlt * Time.deltaTime);
          
    }

  
}
