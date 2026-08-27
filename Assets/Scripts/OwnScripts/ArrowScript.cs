using UnityEngine;
using UnityEngine.UI;

public class ArrowScript : MonoBehaviour
{
    public Transform target;
    public Transform arrow;

    private void FixedUpdate()
    {
        arrow.LookAt(target);
    }
}
