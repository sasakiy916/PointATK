using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    public IEnumerator activeCube(GameObject cube)
    {
        yield return new WaitForSeconds(3);
        cube.SetActive(true);
    }
}
