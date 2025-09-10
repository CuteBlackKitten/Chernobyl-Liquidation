using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterGame : MonoBehaviour
{    
    public void EnterGameGCO()
    {
        SceneManager.LoadScene(1);
        GlobalVariableHolder.ChangeCurrentLevel(3);
    }

    public void EnterGameGCT() 
    {
        SceneManager.LoadScene(4);
        GlobalVariableHolder.ChangeCurrentLevel(4);
    }
}
