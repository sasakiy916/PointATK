using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallGround : MonoBehaviour
{
    Rigidbody rd;
    void Start()
    {
        rd = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            rd.isKinematic = false;
        }
    }
}
