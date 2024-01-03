using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleOrbit : MonoBehaviour
{
    public Transform sun; // Inspector üzerinden Güneş objesini buraya sürükleyip bırakın.
    public float orbitSpeed = 10.0f; // Yörünge hızını buradan ayarlayabilirsiniz.

    void Update()
    {
        // Gezegeni Güneş etrafında y ekseninde döndür.
        transform.RotateAround(sun.position, Vector3.up, orbitSpeed * Time.deltaTime);
    }
}

