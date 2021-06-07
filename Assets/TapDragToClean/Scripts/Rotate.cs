using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    float speed = 50.0f;


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,speed * Time.deltaTime);    
    }
}
