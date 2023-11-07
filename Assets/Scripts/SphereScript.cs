using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{
    Color defaultcolor;
    private void Start()
    {
        defaultcolor = this.GetComponent<Renderer>().material.color;
    }
    private void OnTriggerEnter(Collider other)
    {
        //Change default object colour to red
        this.GetComponent<Renderer>().material.color = Color.red;


    }
    private void OnTriggerExit(Collider other)
    {
        //Change object  to default colour
        this.GetComponent<Renderer>().material.color = defaultcolor;
    }

}
