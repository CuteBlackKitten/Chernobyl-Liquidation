using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ZoneController : MonoBehaviour
{
    public GameObject Buldozer;
    public GameObject Graphite;
    public TextMeshProUGUI TextMPGUI;
    public bool isGood = false;
    public GameObject Firetruck;

    private int GCscore = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (GlobalVariableHolder.ReturnCurrentLevel() == 1) 
        {
            if (isGood) 
            {
                if (other.transform.root.gameObject == Firetruck) 
                {
                    SceneManager.LoadScene(5);
                }
            }
            else 
            {
                if (other.transform.root.gameObject == Firetruck)
                {
                    SceneManager.LoadScene(2);
                }
            }
        }
        else if (GlobalVariableHolder.ReturnCurrentLevel() == 3) 
        {
            if (other.transform.root.gameObject == Buldozer)
            {
                SceneManager.LoadScene(2);
            }

            if (other.transform.root.name == "Graphite(Clone)")
            {
                ++GCscore;
                other.gameObject.SetActive(false);
                TextMPGUI.text = $"Score: {GCscore}";
            }
        }
    }

    private void FixedUpdate()
    {
        if (GlobalVariableHolder.ReturnCurrentLevel() == 1)
        {
            if (GCscore >= 690)
            {
                SceneManager.LoadScene(1);
            }
        }
    }
}
