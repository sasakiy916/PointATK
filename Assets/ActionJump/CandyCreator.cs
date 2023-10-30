using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyCreator : MonoBehaviour
{
    public GameObject candyPrefab;

    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            Instantiate(candyPrefab, transform.position, Quaternion.identity);
        }
    }
}
