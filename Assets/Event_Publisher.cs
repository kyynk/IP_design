using System;
using UnityEngine;

public class Event_Publisher : MonoBehaviour
{
    public Event_Center eventCenter;
    
    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            //eventCenter.Invoke();
            eventCenter.Invoke(this, new EventArgs());
        }
    }
}
