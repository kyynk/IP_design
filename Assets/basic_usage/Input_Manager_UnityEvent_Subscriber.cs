using UnityEngine;

public class Input_Manager_UnityEvent_Subscriber : MonoBehaviour
{
    public Input_Manager_UnityEvent_EventCenter eventCenter;

    private void OnEnable()
    {
        eventCenter.Subscribe(Move);
    }

    private void OnDisable()
    {
        eventCenter.Unsubscribe(Move);
    }

    public void Move(Vector3 velocity)
    {
        transform.position += velocity * Time.deltaTime;
    }
}
