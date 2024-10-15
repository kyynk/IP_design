using UnityEngine;

public class Input_Manager_CSEvent_Publisher : MonoBehaviour
{
    public Input_Manager_CSEvent_EventCenter eventCenter;

    private void Update()
    {
        if (Input.GetKey("w"))
        {
            eventCenter.Invoke(transform.forward * 2.0f);
        }
        if (Input.GetKey("s"))
        {
            eventCenter.Invoke(transform.forward * -2.0f);
        }
        if (Input.GetKey("d"))
        {
            eventCenter.Invoke(transform.right * 2.0f);
        }
        if (Input.GetKey("a"))
        {
            eventCenter.Invoke(transform.right * -2.0f);
        }
    }
}
