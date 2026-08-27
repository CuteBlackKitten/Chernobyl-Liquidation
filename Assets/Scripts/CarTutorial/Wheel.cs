using UnityEngine;

public class Wheel : MonoBehaviour
{
    public WheelCollider wc;
    public Transform wheelMesh;

    private void Update()
    {
        wheelMesh.Rotate(0, wc.rpm / 60 * 360 * Time.deltaTime, 0);
    }
}
