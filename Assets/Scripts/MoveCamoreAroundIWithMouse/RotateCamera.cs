using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    float rotationX = 0f;
    float rotationY = 0f;

    public float sensitivity = 10f;
    void Update()
    {
        if (Input.GetMouseButton(1)) 
        {
            rotationX -= Input.GetAxis("Mouse Y") * sensitivity;
            rotationY += Input.GetAxis("Mouse X") * sensitivity;
            transform.localEulerAngles = new Vector3 (rotationX, rotationY, 0f);
        }
    }
}
