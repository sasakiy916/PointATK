using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 startPos;
    public float speed;
    public float amplitude;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        float move = amplitude * Mathf.Sin(Time.time * speed);
        transform.localPosition = startPos + new Vector3(move, 0, 0);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.transform.SetParent(this.transform);

        }
    }
    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.transform.SetParent(null);
        }
    }
}
