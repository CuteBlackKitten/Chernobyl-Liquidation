using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryFunction : MonoBehaviour
{
    public void Retry() 
    {
        if (GlobalVariableHolder.ReturnCurrentLevel() == 1)
        {
            SceneManager.LoadScene(3);
        }
        if (GlobalVariableHolder.ReturnCurrentLevel() == 2)
        {
            SceneManager.LoadScene(4);
        }
    }
}
