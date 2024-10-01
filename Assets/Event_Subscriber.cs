using System;
using UnityEngine;

public class Event_Subscriber : MonoBehaviour
{
    public Event_Center eventCenter;

    private void OnEnable()
    {
        eventCenter.Subscribe(HandleEvent);
    }

    private void OnDisable()
    {
        eventCenter.Unsubscribe(HandleEvent);
    }

    //public void HandleEvent()
    //{
    //    Debug.Log("Event handled.");
    //}
    public void HandleEvent(object sender, EventArgs e)
    {
        Debug.Log("Event handled.");
    }
}
