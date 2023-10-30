using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStraight : MonoBehaviour
{
    public Transform start; // スタート地点
    public Transform end; // ゴール地点
    public float arrivalTime = 2.0f; // ゴール地点に到達するのにかかる時間（秒）
    float rate = 0.0f; // 現在地の距離割合（0.0がスタート地点、1.0に近い程ゴールに近づく）

    void Update()
    {
        if (rate <= 1.0f)
        {
            rate += Time.deltaTime / arrivalTime;
            transform.position = Vector3.Lerp(start.position, end.position, rate);
        }
    }
    private void OnGUI()
    {
        GUI.matrix = Matrix4x4.Scale(Vector3.one * 5);
        GUI.Label(new Rect(50, 50, 100, 30), $"rate:{rate:F1}");
    }
}
