using System;
using UnityEngine;
using UnityEngine.UI;

public class Rotate : MonoBehaviour
{
    public CannonController mainObject;

    private float maxAngle = 180;
    private float minAngle = 0;

    private float angle = 90.0f;
    private float angleCoefficient = -0.3f;
    
    public Text AngleText;

    private void Start()
    {
        mainObject.onBarrelMove += RotateHandler;
        transform.eulerAngles = new Vector3(0,0,0);
    }

    private void RotateHandler(CannonController controller)
    {
        if (controller.direction != 0)
        {
            if (
                angle < maxAngle && angle > minAngle
                || (angle <= minAngle && controller.direction == -1)
                || (angle >= maxAngle && controller.direction == 1)
            )
            {
                RotateBarrel(controller);
            }
        }
    }

    private void RotateBarrel(CannonController controller)
    {
        var deltaAngle = angleCoefficient * controller.direction;
        angle += deltaAngle;
        transform.RotateAround(controller.pivotPoint.transform.position, Vector3.forward, deltaAngle);

        Vector2 toVector = controller.barrelStart.transform.position - controller.pivotPoint.transform.position;
        AngleText.text = $"{Math.Round(Vector2.Angle(Vector2.right, toVector), 3)}";
        Debug.DrawLine(controller.pivotPoint.transform.position, controller.barrelStart.transform.position, Color.green, 3);
    }
}
