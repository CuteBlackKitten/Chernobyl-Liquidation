using UnityEngine;

public static class GlobalVariableHolder
{
    private static int CurrentLevel;

    public static void ChangeCurrentLevel(int num)
    {
        CurrentLevel = num;
    }

    public static int ReturnCurrentLevel()
    {
        return CurrentLevel;
    }
}
