using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShurikenAir : MonoBehaviour
{
    //[SerializeField] private AudioSource ancur;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name != "Ninja")
        {
            if (collision.gameObject.name == "ObsAir")
            {
                //if (!ancur.isPlaying) ancur.Play();
                collision.GetComponent<ObstacleAir>().dead(true);
                
            }
            Destroy(gameObject);
        }


    }
}
