using UnityEngine;
using UnityEngine.Events;

public class UnityEvent_Center : MonoBehaviour
{
    public UnityEvent myEvent;

    public void Invoke()
    {
        myEvent.Invoke();
    }

    public void Subscribe(UnityAction action)
    {
        myEvent.AddListener(action);
    }

    public void Unsubscribe(UnityAction action)
    {
        myEvent.RemoveListener(action);
    }
}
