using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CannonController : MonoBehaviour
{
    public event Action<CannonController> onBarrelMove;
    public event Action<CannonController> onShot;

    public GameObject pivotPoint;
    public GameObject barrelStart;
    public GameObject barrel;
    public float direction = 0.0f;

    void Update()
    {
        direction = Input.GetAxisRaw("Horizontal");
        onBarrelMove?.Invoke(this);

        if (Input.GetKeyDown(KeyCode.Space))
            onShot?.Invoke(this);
    }
}
