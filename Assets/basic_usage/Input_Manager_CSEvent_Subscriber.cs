using UnityEngine;

public class Input_Manager_CSEvent_Subscriber : MonoBehaviour
{
    public Input_Manager_CSEvent_EventCenter eventCenter;

    public void OnEnable()
    {
        eventCenter.Subscribe(Move);
    }

    public void OnDisable()
    {
        eventCenter.Unsubscribe(Move);
    }

    public void Move(Vector3 velocity)
    {
        transform.position += velocity * Time.deltaTime;
    }
}
