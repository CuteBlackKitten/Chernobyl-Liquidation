using NUnit.Framework;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public static class GlobalVariableHolder
{
    private static int CurrentLevel = 0;
    
    // Firefight fires array
    private static int[] FireStatusList = new int[5];

    public static void ChangeCurrentLevel(int num)
    {
        CurrentLevel = num;
    }

    public static int ReturnCurrentLevel()
    {
        return CurrentLevel;
    }

    public static int ReturnFireStatus(int ID) 
    {
        if (1 <= ID && ID <= 5) 
        {
            return FireStatusList[ID - 1];
        }
        Debug.LogWarning($"Tried getting a value of a nonexsitent fire ID. {ID} is not a valid fire ID");
        return 0;
    }

    public static void ChangeFireStatus(int ID, int num) 
    {
        if (1 <= ID && ID <= 5)
        {
            FireStatusList[ID - 1] = num;
        }
        else
        {
            Debug.LogWarning("Tried setting a value for a nonexistent fire ID.");
        }
    }
}
