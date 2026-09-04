using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraFOVController : MonoBehaviour
{
    Camera cam;
    
    private void Awake()
    {
        cam = GetComponent<Camera>();
        if (cam != null ) 
        {
            UpdateCameraFOV();
        }
    }

    private void Update()
    {
        if (cam != null && SceneManager.GetActiveScene().buildIndex == 0) 
        {
            UpdateCameraFOV();
        }
    }

    private void UpdateCameraFOV()
    {
        cam.fieldOfView = GlobalVariableHolder.GetSettingValue(2);
    }
}
