using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    private Rigidbody rb;
    public bool HasKey;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void OnMouseDown()
    {
        if (HasKey)
        {
            rb.constraints = RigidbodyConstraints.None;
            rb.AddForce(transform.forward * 200f);
        }
    }
}
