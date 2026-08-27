using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Audio;

public class Car : MonoBehaviour
{
    public Rigidbody rb;
    public WheelCollider wc1, wc2, wc3, wc4;
    public float steerSpeed, driveSpeed;
    float horizontalInput, verticalInput;
    public AudioSource audioSource;

    public void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        if (Input.GetAxis("Vertical") != 0) 
        {
            audioSource.pitch = 1.2F;
        }
        else
        {
            audioSource.pitch = 1F;
        }
    }

    public void FixedUpdate()
    {
        float motor = Input.GetAxis("Vertical") * driveSpeed;
        wc1.motorTorque = motor;
        wc2.motorTorque = motor;
        wc3.motorTorque = motor;
        wc4.motorTorque = motor;
        wc1.steerAngle = steerSpeed * horizontalInput;
        wc2.steerAngle = steerSpeed * horizontalInput;
    }
}
