using UnityEngine;
using System.Threading;
using UnityEngine.SocialPlatforms.Impl;

public class GraphiteSpawner : MonoBehaviour
{
    public GameObject graphite;

    private void Awake()
    {
        if (GlobalVariableHolder.ReturnCurrentLevel() == 3) 
        {
            CreateGraphite();
        }
    }

    public void CreateGraphite()
    {
        for (int i = 0; i < 100; i++)
        {
            Instantiate(graphite, new Vector3(Random.Range(-11.71f, 9.68f), 200, Random.Range(-22.35f, 22.12f)), Quaternion.identity);
        }
    }
}
