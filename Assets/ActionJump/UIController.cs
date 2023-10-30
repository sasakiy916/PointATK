using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    // List<GameObject> textList;
    List<RectTransform> textList;
    // Start is called before the first frame update
    void Start()
    {
        // textList = new List<GameObject>();
        textList = new List<RectTransform>();
        for (int i = 0; i < transform.childCount; i++)
        {
            textList.Add(transform.GetChild(i).GetComponent<RectTransform>());
            // Debug.Log(textList[i].GetComponent<Text>().text);
            // Debug.Log(textList[i].GetComponent<RectTransform>().anchoredPosition3D);
            // Debug.Log(textList[i].GetComponent<RectTransform>().sizeDelta.y);
            // Debug.Log(textList[i].GetComponent<RectTransform>().anchorMax);
            // Debug.Log(textList[i].GetComponent<RectTransform>().anchorMin);
            // Debug.Log(textList[i].GetComponent<RectTransform>().anchoredPosition);
            // Debug.Log(textList[i].GetComponent<RectTransform>().root.name);
        }
        // StartCoroutine(move(textList[0], 2));
        StartCoroutine(moves(textList, 0.5f));
    }
    // Update is called once per frame
    float timer = 0;
    public float totaltime = 2f;

    void Update()
    {
        if (timer <= totaltime)
        {
            timer += Time.deltaTime;
            // foreach (GameObject text in textList)
            // {
            //     // yield return new WaitForSeconds(0.5f);
            //     text.GetComponent<RectTransform>().anchoredPosition = new Vector2(
            //         easeInSine(timer, totaltime, text.GetComponent<RectTransform>().anchoredPosition.x, 100),
            //         text.GetComponent<RectTransform>().anchoredPosition.y
            //     );
            // }

            // Debug.Log(timer + "秒");
        }

    }
    IEnumerator moves(List<RectTransform> rects, float delay)
    {
        foreach (RectTransform rect in rects)
        {
            yield return new WaitForSeconds(delay);
            StartCoroutine(EaseInSine(rect, 0.2f));
        }
    }
    IEnumerator EaseInSine(RectTransform rect, float totaltime)
    {
        float time = 0;
        while (time <= 1)
        {
            yield return new WaitForEndOfFrame();

            float x = 1 - Mathf.Cos((time * Mathf.PI) / 2);

            rect.anchoredPosition = new Vector2(((100 - 10) * x) + 10, rect.anchoredPosition.y);
            time += Time.deltaTime / totaltime;
        }
        rect.anchoredPosition = new Vector2(100, rect.anchoredPosition.y);
    }
}
