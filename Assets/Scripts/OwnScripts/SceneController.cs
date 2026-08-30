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
        Time.timeScale = 1f;
    }

    public void EnterGameFF()
    {
        SceneManager.LoadScene(4);
        GlobalVariableHolder.ChangeCurrentLevel(1);
        Time.timeScale = 1f;
    }

    public void EnterTheMenu()
    {
        SceneManager.LoadScene(0);
        GlobalVariableHolder.ChangeCurrentLevel(0);
        Time.timeScale = 1f;
    }
    public void Retry()
    {
        if (GlobalVariableHolder.ReturnCurrentLevel() == 1)
        {
            SceneManager.LoadScene(4);
            Time.timeScale = 1f;
        }
        if (GlobalVariableHolder.ReturnCurrentLevel() == 3)
        {
            SceneManager.LoadScene(3);
            Time.timeScale = 1f;
        }
    }
}
