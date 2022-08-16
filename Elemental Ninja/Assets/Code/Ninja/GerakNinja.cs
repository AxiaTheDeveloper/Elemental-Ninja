using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerakNinja : MonoBehaviour
{
    // Start is called before the first frame update

    //buat ngecek ada di tanah + jalan ga biar suara jalan gas
    

    //gerakkanan kiri
    [SerializeField] public int kecepatan;

    //loncat
    [SerializeField] private float loncatTinggi;
    private bool bisaLoncat;

    //animasi bergerak
    [SerializeField] private AudioSource jalanAudio;
    [SerializeField] private AudioSource loncatAudio;
    [SerializeField] private AudioSource finaldedAudio;
    void Start()
    {
        bisaLoncat = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        //gerak kiri kanan
        Jalan();
        
        arahBadan();

        //loncat
        if (Input.GetKeyDown(KeyCode.Space) && bisaLoncat == true)
        {
            Loncat();
            
        }
        GetComponent<Animator>().SetBool("Berdiri", bisaLoncat);


    }

    //loncat
    private void Loncat()
    {
        bisaLoncat = false;
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 1) * loncatTinggi * 100);
        GetComponent<Animator>().SetTrigger("Loncat");
        loncatAudio.Play();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       // if (collision.gameObject.name == "Tilemap")
       // {
            bisaLoncat = true;
             
        // }
    }
   
    //gerak
    private void arahBadan()
    {
        float keyPress = Input.GetAxisRaw("Horizontal");
        if(keyPress == 1)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (keyPress == -1)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
    }
    private void Jalan()
    {
        float keyPress = Input.GetAxis("Horizontal");

        Vector3 perpindahan = new Vector3(keyPress, 0, 0);
        transform.position += (perpindahan * kecepatan * Time.deltaTime * 1/10);

        GetComponent<Animator>().SetBool("Walk", keyPress != 0);
        if (bisaLoncat == true && keyPress != 0)
        {
            if (!jalanAudio.isPlaying) jalanAudio.Play();
        }
        else
        {
            jalanAudio.Stop();
        }

    }

    public void matis()
    {
        kecepatan = 0;
        finaldedAudio.Play();
    }

}


