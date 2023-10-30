using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceObject : MonoBehaviour
{
    public float power;
    Rigidbody rd;
    bool isPressKey;

    void Start()
    {
        rd = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // spaceキーを押してる間、isPressをtrueにする
        isPressKey = Input.GetKey("space");
    }

    void FixedUpdate()
    {
        // isPressがtrueなら、オブジェクトに力を前方に加える
        rd.AddForce(transform.forward * power);
        if (rd.velocity.magnitude >= 30.00f) rd.velocity = rd.velocity.normalized * 30.00f;
    }
}
