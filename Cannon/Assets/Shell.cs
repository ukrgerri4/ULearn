using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{
    public Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Debug.Log(rb.centerOfMass);
        rb.centerOfMass = new Vector2(1,1);
        rb.AddForce(new Vector2(1, 1) * 5, ForceMode2D.Impulse);
        Destroy(gameObject, 5f);
    }
}
