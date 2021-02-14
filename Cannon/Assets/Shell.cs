using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{
    private Rigidbody2D rb;

    public GameObject pivotPoint;
    public GameObject barrelStart;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        pivotPoint = GameObject.Find("Rotate");
        barrelStart = GameObject.Find("BarrelStart");

        //Debug.Log(rb.centerOfMass);
        //rb.centerOfMass = new Vector2(1,1);
        var v = (barrelStart.transform.position - pivotPoint.transform.position).normalized;
        rb.AddForce(v * 6, ForceMode2D.Impulse);
        Destroy(gameObject, 5f);
    }

    private void FixedUpdate()
    {
        // update the rotation of the projectile during trajectory motion
        transform.rotation = Quaternion.LookRotation(Vector3.forward, rb.velocity);
    }
}
