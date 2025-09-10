using UnityEngine;

public class AnimatorControl : MonoBehaviour
{
    public void ShiftToOptions() 
    {
        var RectInMainMenu = transform.parent.parent.GetComponent<RectTransform>();
        if (RectInMainMenu != null ) 
        {
            RectInMainMenu.anchoredPosition = new Vector3(-680, 0, 0);
        }
        var Title = transform.parent.parent.parent.Find("Title");
        if (Title != null)
        {
            var RectInTitle = Title.GetComponent<RectTransform>();
            if (RectInTitle != null) { RectInTitle.anchoredPosition = new Vector3(0, 321, 0); }
        }
        var OptionsMenu = transform.parent.parent.parent.Find("OptionsPanel");
        if (OptionsMenu != null) 
        {
            var RectInOptionsMenu = OptionsMenu.GetComponent<RectTransform>();
            if (RectInOptionsMenu != null) { RectInOptionsMenu.anchoredPosition = new Vector3(0, 0, 0); }
        }
        var Changelog = transform.parent.parent.parent.Find("Changelog");
        if (Changelog != null)
        {
            var RectInChangelog = Changelog.GetComponent<RectTransform>();
            if (RectInChangelog != null) { RectInChangelog.anchoredPosition = new Vector3(-1000, 423.0018f, 0); }
        }
    }

    public void ShiftToMainMenu()
    {
        var MainMenuPanel = transform.parent.parent.parent.Find("MainMenuPanel");
        if (MainMenuPanel != null) 
        {
            var RectInMainMenu = MainMenuPanel.GetComponent<RectTransform>();
            if (RectInMainMenu != null)
            {
                RectInMainMenu.anchoredPosition = new Vector3(0, -48, 0);
            }
        }
        var Title = transform.parent.parent.parent.Find("Title");
        if (Title != null)
        {
            var RectInTitle = Title.GetComponent<RectTransform>();
            if (RectInTitle != null) { RectInTitle.anchoredPosition = new Vector3(0, -67.64775f, 0); }
        }
        var OptionsMenu = transform.parent.parent.parent.Find("OptionsPanel");
        if (OptionsMenu != null)
        {
            var RectInOptionsMenu = OptionsMenu.GetComponent<RectTransform>();
            if (RectInOptionsMenu != null) { RectInOptionsMenu.anchoredPosition = new Vector3(651, 0, 0); }
        }
        var StartMenu = transform.parent.parent.parent.Find("StartPanel");
        if (StartMenu != null)
        {
            var RectInStartMenu = StartMenu.GetComponent<RectTransform>();
            if (RectInStartMenu != null) { RectInStartMenu.anchoredPosition = new Vector3(0, -500, 0); }
        }
        var Changelog = transform.parent.parent.parent.Find("Changelog");
        if (Changelog != null)
        {
            var RectInChangelog = Changelog.GetComponent<RectTransform>();
            if (RectInChangelog != null) { RectInChangelog.anchoredPosition = new Vector3(-277.1197f, 423.0018f, 0); }
        }
    }

    public void ShiftToStartMenu()
    {
        var RectInMainMenu = transform.parent.parent.GetComponent<RectTransform>();
        if (RectInMainMenu != null)
        {
            RectInMainMenu.anchoredPosition = new Vector3(-680, 0, 0);
        }
        var Title = transform.parent.parent.parent.Find("Title");
        if (Title != null)
        {
            var RectInTitle = Title.GetComponent<RectTransform>();
            if (RectInTitle != null) { RectInTitle.anchoredPosition = new Vector3(0, 321, 0); }
        }
        var StartMenu = transform.parent.parent.parent.Find("StartPanel");
        if (StartMenu != null)
        {
            var RectInStartMenu = StartMenu.GetComponent<RectTransform>();
            if (RectInStartMenu != null) { RectInStartMenu.anchoredPosition = new Vector3(0, 0, 0); }
        }
        var Changelog = transform.parent.parent.parent.Find("Changelog");
        if (Changelog != null) 
        {
            var RectInChangelog = Changelog.GetComponent<RectTransform>();
            if (RectInChangelog != null) { RectInChangelog.anchoredPosition = new Vector3(-1000, 423.0018f, 0); }
        }
    }

    public void OpenChangelog() 
    {
        var RectInChangelog = transform.parent.parent.GetComponent<RectTransform>();
        if (RectInChangelog != null) 
        {
            RectInChangelog.anchoredPosition = new Vector3(-277.1197f, -42, 0);
        }
    }
    public void CloseChangelog() 
    {
        var RectInChangelog = transform.parent.parent.GetComponent<RectTransform>();
        if (RectInChangelog != null) 
        {
            RectInChangelog.anchoredPosition = new Vector3(-277.1197f, 423.0018f, 0);
        }
    }
}