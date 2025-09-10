using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryFunction : MonoBehaviour
{
    public void Retry() 
    {
        if (GlobalVariableHolder.ReturnCurrentLevel() == 3)
        {
            SceneManager.LoadScene(1);
        }
        if (GlobalVariableHolder.ReturnCurrentLevel() == 4)
        {
            SceneManager.LoadScene(4);
        }
    }
}
