using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ZoneController : MonoBehaviour
{
    public GameObject Buldozer;
    public GameObject Graphite;
    public TextMeshProUGUI TextMPGUI;

    private int score = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.root.gameObject == Buldozer)
        {
            SceneManager.LoadScene(2);
        }
        
        if (other.transform.root.name == "Graphite(Clone)")
        {
            ++score;
            other.gameObject.SetActive(false);
            TextMPGUI.text = $"Score: {score}";
        }

        //Debug.Log($"{other} touched the trigger");
    }

    private void FixedUpdate()
    {
        if (GlobalVariableHolder.ReturnCurrentLevel() == 3)
        {
            if (score >= 690)
            {
                SceneManager.LoadScene(3);
            }
        }
        if (GlobalVariableHolder.ReturnCurrentLevel() == 4)
        {
            if (score >= 690)
            {
                SceneManager.LoadScene(3);
            }
        }
    }
}
