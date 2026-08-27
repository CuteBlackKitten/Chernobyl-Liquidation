using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void Close()
    {
        Application.Quit();
    }

    public void EnterGameGCO()
    {
        SceneManager.LoadScene(3);
        GlobalVariableHolder.ChangeCurrentLevel(3);
    }

    public void EnterGameFF()
    {
        SceneManager.LoadScene(4);
        GlobalVariableHolder.ChangeCurrentLevel(1);
    }

    public void EnterTheMenu()
    {
        SceneManager.LoadScene(0);
        GlobalVariableHolder.ChangeCurrentLevel(0);
    }
    public void Retry()
    {
        if (GlobalVariableHolder.ReturnCurrentLevel() == 1)
        {
            SceneManager.LoadScene(5);
        }
        if (GlobalVariableHolder.ReturnCurrentLevel() == 3)
        {
            SceneManager.LoadScene(3);
        }
    }
}
