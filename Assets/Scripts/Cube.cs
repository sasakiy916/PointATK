using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public GameDirector gm;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gm.StartCoroutine("activeCube", this.gameObject);
            this.gameObject.SetActive(false);
        }
    }
}
