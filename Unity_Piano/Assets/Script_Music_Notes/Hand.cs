using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    public Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
        
    private void Update()
    {
        rb.AddRelativeForce(Vector3.up * 10);
        
        if (Input.GetKey("left"))
        {
            transform.Translate(Vector3.left * Time.deltaTime);
        }
        
        if (Input.GetKey("right"))
        {
            transform.Translate(Vector3.right * Time.deltaTime);
        }
    }
}
