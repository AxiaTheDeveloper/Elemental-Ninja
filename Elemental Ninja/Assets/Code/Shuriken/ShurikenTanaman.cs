using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShurikenTanaman : MonoBehaviour
{
    //[SerializeField] private AudioSource ancur;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name != "Ninja")
        {
            if (collision.gameObject.name == "ObsTnmn")
            {
                //if (!ancur.isPlaying) ancur.Play();
                collision.GetComponent<ObstacleTanaman>().dead(true);
                
            }
            Destroy(gameObject);
        }


    }
}
