using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayTest : MonoBehaviour
{
    public GameObject myPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.right);
            

            if (hit.collider != null)
            {
                Debug.Log(hit.collider.name);
                //Debug.DrawRay(worldPoint, Vector2.right, Color.green, 5, false);
                Debug.DrawLine(worldPoint, hit.point, Color.green, 5, false);
                //Instantiate(myPrefab, hit.transform);
            }
        }
    }
}
