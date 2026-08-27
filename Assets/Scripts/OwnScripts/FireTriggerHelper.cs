using UnityEngine;

public class FireTriggerHelper : MonoBehaviour
{
    public int FireID;
    private int untilDeath = 100;

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);

        --untilDeath;      
    }

    private void FixedUpdate()
    {
        GlobalVariableHolder.ChangeFireStatus(FireID, untilDeath);

        if (untilDeath <= 0)
        {
            transform.parent.gameObject.SetActive(false);
        }
    }
}
