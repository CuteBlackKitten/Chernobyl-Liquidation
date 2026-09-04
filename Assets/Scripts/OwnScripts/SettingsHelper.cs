using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SettingsHelper : MonoBehaviour
{
    public Slider[] SlidersList = new Slider[4];
    public string[] SliderNames = new string[4];
    public TextMeshProUGUI[] settingsTexts = new TextMeshProUGUI[4];

    private void Update()
    {
        for (int i = 0; i < settingsTexts.Length; i++) 
        {
            GlobalVariableHolder.SetSettingValue(i+1, SlidersList[i].value);
            settingsTexts[i].text = $"{SliderNames[i]}: {SlidersList[i].value}";
        }
    }
}
