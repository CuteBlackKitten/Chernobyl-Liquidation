using UnityEngine;
using UnityEngine.InputSystem.XR;

public class FollowMouseDirection : MonoBehaviour
{
    private BuldozerMovement controller;
    public float Speed;

    private void Awake()
    {
        controller = new BuldozerMovement();
    }

    private void Update()
    {

    }
}
