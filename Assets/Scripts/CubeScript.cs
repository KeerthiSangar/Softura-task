using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    Rigidbody rb;
    //can change in inspector
    public float speed = 5f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = Vector3.forward * speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = Vector3.back * speed;
        }
    }

}
