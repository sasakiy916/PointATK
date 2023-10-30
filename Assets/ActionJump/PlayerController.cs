using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    Rigidbody rd;

    List<string> list;
    void Start()
    {
        rd = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetKey("w"))
            transform.Translate(transform.forward * speed * Time.deltaTime);
        // transform.position += transform.forward * speed * Time.deltaTime;
    }
    void FixedUpdate()
    {
        // rd.AddForce(transform.forward * speed);
        rd.velocity = transform.forward * speed;
    }
}
