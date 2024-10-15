using UnityEngine;
using UnityEngine.Events;

public class Input_Manager_UnityEvent_EventCenter : MonoBehaviour
{
    public UnityEvent<Vector3> eventMove;

    public void Invoke(Vector3 velocity)
    {
        eventMove.Invoke(velocity);
    }

    public void Subscribe(UnityAction<Vector3> action)
    {
        eventMove.AddListener(action);
    }

    public void Unsubscribe(UnityAction<Vector3> action)
    {
        eventMove.RemoveListener(action);
    }
}
