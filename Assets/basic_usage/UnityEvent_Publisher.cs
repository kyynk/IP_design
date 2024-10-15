using UnityEngine;

public class UnityEvent_Publisher : MonoBehaviour
{
    public UnityEvent_Center eventCenter;

    void Update()
    {
        if (Input.GetKeyDown("b"))
        {
            eventCenter.Invoke();
        }
    }
}
