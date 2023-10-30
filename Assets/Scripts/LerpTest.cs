using UnityEditor.Recorder;
using UnityEngine;

public class LerpTest : MonoBehaviour
{
    public Transform start;
    public Transform end;

    public float arrivalTime; // ゴール地点に到達するのにかかる時間（秒）
    bool isReturn = false; // falseはゴール、trueはスタートに向かう
    float rate = 0.0f; // 現在地の割合（0.0がスタート地点、1.0になるとゴールに到達）

    void Update()
    {
        // スタートとゴールの間の移動処理
        rate += isReturn ? -Time.deltaTime / arrivalTime : Time.deltaTime / arrivalTime;
        transform.position = Vector3.Lerp(start.position, end.position, rate);

        // スタート、ゴールに到達したら移動方向を逆にする
        if (rate >= 1.0f) isReturn = true;
        if (rate <= 0.0f) isReturn = false;
    }
}
