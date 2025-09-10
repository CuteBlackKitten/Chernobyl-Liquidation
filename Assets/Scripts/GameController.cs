using UnityEngine;
using System.Threading;
using UnityEngine.SocialPlatforms.Impl;

public class GameController : MonoBehaviour
{
    public GameObject graphite;

    private void Awake()
    {
        if (GlobalVariableHolder.ReturnCurrentLevel() == 3) 
        {
            CreateGraphite();
        }
        if (GlobalVariableHolder.ReturnCurrentLevel() == 4)
        {
            CreateGraphite2();
        }
    }

    public void CreateGraphite()
    {
        for (int i = 0; i < 100; i++)
        {
            Instantiate(graphite, new Vector3(Random.Range(-11.71f, 9.68f), 200, Random.Range(-22.35f, 22.12f)), Quaternion.identity);
        }
    }

    public void CreateGraphite2() 
    {
        for (int i = 0; i < 200; i++)
        {
            Instantiate(graphite, new Vector3(Random.Range(54.45f, 93.58f), 173, Random.Range(-43.7f, -140.78f)), Quaternion.identity);
        }
    }
}
