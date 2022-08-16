using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shuriken : MonoBehaviour
{
    [SerializeField] float gerak;
    int jarak = 250; //jrk dr dia muncul trus ntr dia diancurin
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = transform.right * gerak;

    }

    // Update is called once per frame
    void Update()
    {
        jarakTembak();

    }

    private void jarakTembak()
    {
        jarak--;
        if (jarak == 0)
        {
            Destroy(gameObject);
        }
    }
}
