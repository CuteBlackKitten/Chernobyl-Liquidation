using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FFUIController : MonoBehaviour
{
    public TextMeshProUGUI[] FireStatusTexts = new TextMeshProUGUI[5];

    private void Update()
    {
        bool allExtinguished = true;
        
        for (int i = 0; i < FireStatusTexts.Length; i++)
        {
            int FireID = i + 1;
            int FireStatus = GlobalVariableHolder.ReturnFireStatus(FireID);
            
            if (FireStatus <= 1)
            {
                FireStatusTexts[i].text = "Extinguished";
            }
            else
            {
                FireStatusTexts[i].text = $"Fire{FireID}: {FireStatus}";
                allExtinguished = false;
            }
        }

        if (allExtinguished)
        {
            SceneManager.LoadScene(1);
        }
    } 
}
