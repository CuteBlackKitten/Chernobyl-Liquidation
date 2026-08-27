using UnityEngine;

public class ShlangController : MonoBehaviour
{
    private BuldozerMovement controller;
    Transform shlang;
    Transform shlangShooters;
    public GameObject waterDropPrefab;
    public GameObject shootingPoint1;
    public GameObject shootingPoint2;
    private bool isLeft;

    private void Awake()
    {      
        controller = new BuldozerMovement();
        shlang = transform.Find("Shlang");
        if (shlang == null)
        {
            Debug.LogError("Shlang not found.");
            return;
        }
        shlangShooters = shlang.transform.Find("ShlangShooters");
        if (shlangShooters == null)
            Debug.LogError("ShlangShooters not found.");
    }

    private void FixedUpdate()
    {
        if (controller == null || shlang == null || shlangShooters == null)
            return;

        if (controller.Buldozer.TowerLeft.ReadValue<float>() > 0.5f)
        {
            shlang.transform.Rotate(Vector3.up, -40 * Time.fixedDeltaTime);
        }
        if (controller.Buldozer.TowerRight.ReadValue<float>() > 0.5f)
        {
            shlang.transform.Rotate(Vector3.up, 40 * Time.fixedDeltaTime);
        }
        if (controller.Buldozer.ShlangDown.ReadValue<float>() > 0.5f)
        {
            if (shlangShooters.rotation.x != 1.3f)
            {
                shlangShooters.transform.Rotate(Vector3.right, 5 * Time.fixedDeltaTime);
            }
        }
        if (controller.Buldozer.ShlangUp.ReadValue<float>() > 0.5f)
        {
            if (shlangShooters.rotation.x != -10.5)
            {
                shlangShooters.transform.Rotate(Vector3.right, -5 * Time.fixedDeltaTime);
            }
        }
        if (controller.Buldozer.ShootShlang.ReadValue<float>() > 0.5f) 
        {
            ShootWater();
        }
    }

    private void OnEnable()
    {
        controller.Buldozer.Enable();
    }

    private void OnDisable()
    {
        controller.Buldozer.Disable();
    }

    private void ShootWater() 
    {
        if (waterDropPrefab == null || shootingPoint1 == null || shootingPoint2 == null)
            return;

        if (isLeft)
        {
            var waterDrop = Instantiate(waterDropPrefab, shootingPoint1.transform.position, Quaternion.identity);
            var waterDroprb = waterDrop.GetComponent<Rigidbody>();
            waterDroprb.AddForce(shootingPoint1.transform.forward * 50, ForceMode.Impulse);
            isLeft = !isLeft;
            Destroy(waterDrop, 3f);
        }

        if (!isLeft)
        {
            var waterDrop = Instantiate(waterDropPrefab, shootingPoint2.transform.position, Quaternion.identity);
            var waterDroprb = waterDrop.GetComponent<Rigidbody>();
            waterDroprb.AddForce(shootingPoint2.transform.forward * 50, ForceMode.Impulse);
            isLeft = !isLeft;
            Destroy(waterDrop, 3f);
        }
    }
}
