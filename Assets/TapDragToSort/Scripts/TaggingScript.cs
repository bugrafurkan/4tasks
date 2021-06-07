using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaggingScript : MonoBehaviour
{
    public GameObject pot1;
    public GameObject pot2;
    public GameObject pot3;
    public GameObject pot4;


  
    // Update is called once per frame
    void Update()
    {
        if (pot1.tag == "RedPot" && pot2.tag == "RedPot" && pot3.tag == "RedPot" && pot4.tag == "RedPot"){
            Debug.Log("hello");
        }
    }
}
