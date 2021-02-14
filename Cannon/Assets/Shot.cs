using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public CannonController mainObject;
    public GameObject shell;

    private void Start()
    {
        mainObject.onShot += ShotHandler;
    }

    public void ShotHandler(CannonController controller)
    {
        Instantiate(shell, controller.barrelStart.transform.position + new Vector3(1, 1, 0), controller.barrel.transform.rotation);
    }
}
