using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager1 : MonoBehaviour
{
    public GameObject player;
    void Start()
    {
        DontDestroyOnLoad(player);
        for (int i = 0; i < 100; i++)
        {
            Debug.Log(Random.Range(0, 10));
            Debug.Log(Random.Range(0.0f, 10.0f));
            Debug.Log(Random.Range(0.0f, 10.0f));

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("b"))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
