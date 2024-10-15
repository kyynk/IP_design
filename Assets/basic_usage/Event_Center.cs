using System;
using UnityEngine;

public class Event_Center : MonoBehaviour
{
    // Delegate declaration
    //public delegate void MyEventHandler();
    public delegate void MyEventHandler(object sender, EventArgs e);

    // Event declaration
    private event MyEventHandler MyEvent;

    // Invoke the event
    //public void Invoke()
    //{
    //    MyEvent?.Invoke();
    //}
    public void Invoke(object sender, EventArgs e)
    {
        MyEvent?.Invoke(sender, e);
    }

    // Hook the event
    public void Subscribe(MyEventHandler handler)
    {
        MyEvent += handler;
    }

    // Un-hook the event
    public void Unsubscribe(MyEventHandler handler)
    {
        MyEvent -= handler;
    }
}
