using UnityEngine;
using UnityEngine.Events;

public class UnityEvent_Subscriber : MonoBehaviour
{
    public UnityEvent_Center eventCenter;
    public UnityAction action = new UnityAction (
        // Lamda method: () => {}
        () => { Debug.Log("Event handled. (UnityEvent)"); }
    );

    private void OnEnable()
    {
        eventCenter.Subscribe(action);
    }

    private void OnDisable()
    {
        eventCenter.Unsubscribe(action);
    }
}
