using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public Text t;

    void Update()
    {
        Camera camera = this.GetComponent<Camera>();
        // float x = camera.ScreenToViewportPoint(new Vector2(Input.mousePosition.x, 0)).x;
        // t.text = $"mouseX:{x}";
    }
    public float speed;
    Vector3 v;
    private void FixedUpdate()
    {
        Camera camera = this.GetComponent<Camera>();
        // float x = camera.ScreenToViewportPoint(new Vector2(player.transform.position.x, 0)).x;
        float x = camera.WorldToViewportPoint(new Vector2(player.transform.position.x, 0)).x;
        Vector3 x1 = camera.WorldToViewportPoint(player.transform.position);
        Vector3 x2 = camera.ViewportToWorldPoint(x1 + new Vector3(0.3f, 0, 0));
        Vector3 x3 = camera.ViewportToWorldPoint(x1 - new Vector3(0.3f, 0, 0));
        transform.position = new Vector3(
            // Mathf.Clamp(Mathf.Lerp(transform.position.x, player.transform.position.x, Time.deltaTime * speed), player.transform.position.x - 5, player.transform.position.x + 5),
            Mathf.Clamp(Mathf.Lerp(transform.position.x, player.transform.position.x, Time.deltaTime * speed), x3.x, x2.x),
            transform.position.y,
            transform.position.z
        );
        // t.text = $"mouseX:{x2}\n";
        // t.text += $"mouseX:{x1}";
    }
    private void OnTransformChildrenChanged()
    {
        Debug.Log("test");
    }
}
