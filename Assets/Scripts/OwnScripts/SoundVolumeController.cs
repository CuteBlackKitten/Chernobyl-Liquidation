using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundVolumeController : MonoBehaviour
{
    private AudioSource audio;
    public bool isMusic;

    private void Awake()
    {
        audio = GetComponent<AudioSource>();
        if (audio != null) 
        {
            UpdateVolume();
        }
        else 
        {
            Debug.Log("Couldn't find audiosource");
        }
    }

    private void Update()
    {
        if (audio != null && SceneManager.GetActiveScene().buildIndex == 0) 
        {
            UpdateVolume();
        }
    }

    private void UpdateVolume() 
    {
        float MasterVolume = GlobalVariableHolder.GetSettingValue(1) / 100f;
        if (isMusic)
        {
            float soundVolume = GlobalVariableHolder.GetSettingValue(4) / 100f;
            audio.volume = soundVolume * MasterVolume;
        }
        else
        {
            float soundVolume = GlobalVariableHolder.GetSettingValue(3) / 100f;
            audio.volume = soundVolume * MasterVolume;
        }
    }
}
