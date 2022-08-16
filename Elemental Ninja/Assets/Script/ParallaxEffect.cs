using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxEffect : MonoBehaviour
{
    float length, startX;
    public GameObject Cam;
    public float parallaxX;
    // Start is called before the first frame update
    void Start()
    {
        startX = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }
    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-3 * Time.deltaTime, 0);
        float temp = (Cam.transform.position.x * (1 - parallaxX));
        float distX = (Cam.transform.position.x * parallaxX);
        transform.position = new Vector3(startX + distX, transform.position.y, transform.position.z);

        if (temp > startX + length) startX += length;
        else if (temp < startX - length) startX -= length;
    }
}
