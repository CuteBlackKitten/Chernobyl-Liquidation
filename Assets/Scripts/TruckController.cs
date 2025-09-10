using NUnit.Framework.Constraints;
using UnityEngine;

public class FireTruckController : MonoBehaviour
{
    private BuldozerMovement controller;
    Rigidbody rb;
    AudioSource audioSource;

    private void Awake()
    {
        controller = new BuldozerMovement();
        rb = GetComponent<Rigidbody>();
        var Base = transform.Find("Engine");
        var SoundObject = Base.Find("SoundObject");
        audioSource = SoundObject.GetComponent<AudioSource>();
        if (audioSource == null)
        {
            Debug.Log("No AudioSource found.");
        }
    }

    private void FixedUpdate()
    {
        if (controller.Buldozer.Move.ReadValue<float>() > 0.5f)
        {
            rb.AddForce(transform.forward * 15, ForceMode.Impulse);
            audioSource.pitch = 1.2F;
        }
        else
        {
            audioSource.pitch = 1F;
        }
        if (controller.Buldozer.RotateLeft.ReadValue<float>() > 0.5f)
        {
            transform.Rotate(Vector3.up, -50 * Time.fixedDeltaTime);
            audioSource.pitch = 1.2F;
        }        
        if (controller.Buldozer.RotateRight.ReadValue<float>() > 0.5f)
        {
            transform.Rotate(Vector3.up, 50 * Time.fixedDeltaTime);
            audioSource.pitch = 1.2F;
        }        
        if (controller.Buldozer.Backward.ReadValue<float>() > 0.5f)
        {
            rb.AddForce(transform.forward * -15, ForceMode.Impulse);
            audioSource.pitch = 1.2F;
        }        

        //transform.position = transform.position + new Vector3(moveDirection.x * 3, 0, moveDirection.y * 3) * Time.fixedDeltaTime;
    }

    private void OnEnable()
    {
        controller.Buldozer.Enable();
    }
}
