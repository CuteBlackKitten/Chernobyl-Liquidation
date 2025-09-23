using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public static class GlobalVariableHolder
{
    private static int CurrentLevel;

    // Firefight mission global variables
    private static int FireStatus1;
    private static int FireStatus2;
    private static int FireStatus3;
    private static int FireStatus4;
    private static int FireStatus5;

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
        switch (ID) 
        {
            case 1:
                return FireStatus1;

            case 2:
                return FireStatus2;

            case 3:
                return FireStatus3;

            case 4:
                return FireStatus4;

            case 5:
                return FireStatus5;

            default:
                Debug.LogWarning("Tried getting a value of a non-existent fire ID.");
                return 0;
        }
    }

    public static void ChangeFireStatus(int ID, int num) 
    {
        switch (ID)
        {
            case 1:
                FireStatus1 = num;
                break;

            case 2:
                FireStatus2 = num;
                break;

            case 3:
                FireStatus3 = num;
                break;

            case 4:
                FireStatus4 = num;
                break;

            case 5:
                FireStatus5 = num;
                break;

            default:
                Debug.LogWarning("Tried setting a value for a non-existent fire ID.");
                break;
        }
    }
}
