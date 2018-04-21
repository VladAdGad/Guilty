using UnityEngine;

public class ObjectRotate : MonoBehaviour
{
    private const float RotSpeed = 200;

    private void OnMouseDrag()
    {
        float rotX = Input.GetAxis("Mouse X") * RotSpeed * Mathf.Deg2Rad;
        float rotY = Input.GetAxis("Mouse Y") * RotSpeed * Mathf.Deg2Rad;

        transform.Rotate(Vector3.up, -rotX);
        transform.Rotate(Vector3.right, rotY);
    }
}