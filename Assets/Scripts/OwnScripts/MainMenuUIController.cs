using System;
using UnityEngine;

public class MainMenuUIController : MonoBehaviour
{
    public RectTransform titleRect;
    public RectTransform mainMenuRect;
    public RectTransform optionsMenuRect;
    public RectTransform changelogRect;
    public RectTransform startMenuRect;
    
    public void ShiftToOptions() 
    {
        if (titleRect != null && mainMenuRect != null && optionsMenuRect != null && changelogRect != null)
        {
            titleRect.anchoredPosition = new Vector3(0, 321, 0);
            mainMenuRect.anchoredPosition = new Vector3(-680, 0, 0);
            optionsMenuRect.anchoredPosition = new Vector3(0, 0, 0);
            changelogRect.anchoredPosition = new Vector3(-1000, 423.0018f, 0);
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
            titleRect.anchoredPosition = new Vector3(0, -67.64775f, 0);
            mainMenuRect.anchoredPosition = new Vector3(0, -48, 0);
            optionsMenuRect.anchoredPosition = new Vector3(651, 0, 0);
            startMenuRect.anchoredPosition = new Vector3(0, -500, 0);
            changelogRect.anchoredPosition = new Vector3(-277.1197f, 423.0018f, 0);
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
            titleRect.anchoredPosition = new Vector3(0, 321, 0);
            mainMenuRect.anchoredPosition = new Vector3(-680, 0, 0);
            startMenuRect.anchoredPosition = new Vector3(0, 0, 0);
            changelogRect.anchoredPosition = new Vector3(-1000, 423.0018f, 0);
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
            changelogRect.anchoredPosition = new Vector3(-277.1197f, -42, 0);
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
            changelogRect.anchoredPosition = new Vector3(-277.1197f, 423.0018f, 0);
        }
        else
        {
            Debug.LogWarning("A RectTransform value is missing!");
        }
    }
}