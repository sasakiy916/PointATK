using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    public float speed;
    Rigidbody rd;

    private void Start()
    {
        rd = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 movedir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * speed * Time.deltaTime;
        // this.transform.position += movedir;
        rd.AddForce(movedir, ForceMode.Acceleration);

        this.transform.forward = Vector3.Slerp(this.transform.forward, movedir, Time.deltaTime * 10f);
        Debug.Log(rd.velocity);
        // this.GetComponent<Rigidbody>().AddForce(Vector3.forward, ForceMode.Force);
        // this.GetComponent<Rigidbody>().AddTorque(, ForceMode.Acceleration);
    }

}
