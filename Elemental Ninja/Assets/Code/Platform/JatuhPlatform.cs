using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JatuhPlatform : MonoBehaviour
{
    public static JatuhPlatform statis;
    [SerializeField] private Transform bawah, awal;
    [SerializeField] private float kecepatanPlt, timer;
    private float simpan;
    Vector3 tujuan;
    public bool cek;
    public bool hit;
    // Start is called before the first frame update
    void Start()
    {
        tujuan = awal.position;
        simpan = timer;
        cek = false;
        hit = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(cek == true)
        {
            timer -= 0.009f;
            if (timer <= 0)
            {
                tujuan = bawah.position;
                cek = false;
            }
        }
        if (transform.position == bawah.position)
        {
            hit = false;
        }
        transform.position = Vector3.MoveTowards(transform.position, tujuan, kecepatanPlt * Time.deltaTime);
    }
}
