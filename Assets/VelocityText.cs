using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VelocityText : MonoBehaviour
{
    public Rigidbody rd;
    Text velocityText;
    void Start()
    {
        velocityText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        velocityText.text = $"移動速度：{Mathf.FloorToInt(rd.velocity.magnitude)}m/s";
    }
}
