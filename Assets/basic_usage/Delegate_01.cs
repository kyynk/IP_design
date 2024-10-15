using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delegate_01 : MonoBehaviour
{
    // 1. Define a delegate
    public delegate void MyDelegate(string message, int hour, int min, int sec);

    // Start is called before the first frame update
    void Start()
    {
        // 2. Instantiate the delegate
        MyDelegate myDele = new MyDelegate(ShowTime);

        // 3. Invoke the delegate
        myDele("Hello", 7, 5, 55);
    }

    // Method that matches the delegate signature
    public void ShowTime(string message, int hour, int min, int sec)
    {
        Debug.Log(message);
        Debug.Log($"The time now is: {hour}:{min}:{sec}");
    }
}
