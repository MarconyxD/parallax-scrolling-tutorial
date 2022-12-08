using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    private float length, startpos;
    public float parallaxEffect;
    public GameObject cam;
    private Vector3 initialBackgroundPosition;

    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position.x; 
        length = GetComponent<SpriteRenderer>().bounds.size.x; 
        initialBackgroundPosition = transform.position; 
    }

    void FixedUpdate()
    {
        float temp = (cam.transform.position.x * (1 - parallaxEffect)); 
        float dist = (cam.transform.position.x * parallaxEffect); 

        transform.position = new Vector3(startpos + dist, initialBackgroundPosition.y, transform.position.z);

        if (temp > startpos + length) startpos += length;
        else if (temp < startpos) startpos -= length;
    }
}
