using UnityEngine;

public class Input_Manager_CSEvent_EventCenter : MonoBehaviour
{
    public delegate void DelegateMove(Vector3 velocity);
    private event DelegateMove eventMove;
    
    public void Invoke(Vector3 velocity)
    {
        eventMove.Invoke(velocity);
    }

    public void Subscribe(DelegateMove action)
    {
        eventMove += action;
    }

    public void Unsubscribe(DelegateMove action)
    {
        eventMove -= action;
    }
}
