using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public RectTransform titleRect;
    public RectTransform mainMenuRect;
    public RectTransform optionsMenuRect;
    public RectTransform changelogRect;
    public RectTransform startMenuRect;
    public RectTransform pauseMenuRect;
    
    public void ShiftToOptions() 
    {
        if (titleRect != null && mainMenuRect != null && optionsMenuRect != null && changelogRect != null)
        {
            titleRect.anchoredPosition = new Vector2(0, 321);
            mainMenuRect.anchoredPosition = new Vector2(-680, 0);
            optionsMenuRect.anchoredPosition = Vector2.zero;
            changelogRect.anchoredPosition = new Vector2(-1000, 423.0018f);
        }
        else 
        {
            Debug.LogWarning("A RectTransform value is missing!");
        }
    }

    public void ShiftToMainMenu()
    {
        if (titleRect != null && mainMenuRect != null && optionsMenuRect != null && changelogRect != null && startMenuRect != null) 
        { 
            titleRect.anchoredPosition = new Vector2(0, -67.64775f);
            mainMenuRect.anchoredPosition = new Vector2(0, -48);
            optionsMenuRect.anchoredPosition = new Vector2(651, 0);
            startMenuRect.anchoredPosition = new Vector2(0, -500);
            changelogRect.anchoredPosition = new Vector2(-277.1197f, 423.0018f);
        }
        else 
        {
            Debug.LogWarning("A RectTransform value is missing!");
        }
    }

    public void ShiftToStartMenu()
    {
        if (titleRect != null && mainMenuRect != null && optionsMenuRect != null && changelogRect != null && startMenuRect != null)
        {
            titleRect.anchoredPosition = new Vector2(0, 321);
            mainMenuRect.anchoredPosition = new Vector2(-680, 0);
            startMenuRect.anchoredPosition = Vector2.zero;
            changelogRect.anchoredPosition = new Vector2(-1000, 423.0018f);
        }
        else
        {
            Debug.LogWarning("A RectTransform value is missing!");
        }
    }

    public void OpenChangelog() 
    {
        if (changelogRect != null) 
        {
            changelogRect.anchoredPosition = new Vector2(-277.1197f, -42);
        }
        else 
        {
            Debug.LogWarning("A RectTransform value is missing!");
        }
    }
    public void CloseChangelog() 
    {
        if (changelogRect != null)
        {
            changelogRect.anchoredPosition = new Vector2(-277.1197f, 423.0018f);
        }
        else
        {
            Debug.LogWarning("A RectTransform value is missing!");
        }
    }

    public void OpenPauseMenu()
    {
        if (pauseMenuRect != null) 
        {
            pauseMenuRect.anchoredPosition = new Vector2(0, 4.5f);
            Time.timeScale = 0f;
        }
        else 
        {
            Debug.LogWarning("A RectTransform value is missing!");
        }
    }

    public void ClosePauseMenu() 
    {
        if (pauseMenuRect != null) 
        {
            if (SceneManager.GetActiveScene().buildIndex == 5)
            {
                pauseMenuRect.anchoredPosition = new Vector2(0, 419);
                Time.timeScale = 1f;
            }
            else
            {
                pauseMenuRect.anchoredPosition = new Vector2(0, 570);
                Time.timeScale = 1f;
            }
        }
        else 
        {
            Debug.LogWarning("A RectTransform value is missing!");
        }
    }
}