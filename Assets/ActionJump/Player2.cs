using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public float speed;
    public float jumpPower;
    Rigidbody rd;
    bool isJump;
    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        Vector3 dir = new Vector3(x, 0, 0);
        rd.AddForce(dir * speed * Time.deltaTime, ForceMode.Force);
        transform.forward = Vector3.Slerp(transform.forward, dir, Time.deltaTime * 10f);
        if (Input.GetKeyDown("space"))
        {
            rd.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        }
    }
}
