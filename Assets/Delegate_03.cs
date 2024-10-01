using UnityEngine;

public class Delegate_03 : MonoBehaviour
{
    public delegate void MyDelegate(string message);

    // Start is called before the first frame update
    void Start()
    {
        // Create a delegate instance that references ShowMessage1
        MyDelegate del = ShowMessage1;

        // Add ShowMessage2 to the delegate invocation list
        del += ShowMessage2;

        // Invoke the delegate
        del("Hello, world");

        // Remove ShowMessage1 from the delegate invocation list
        del -= ShowMessage1;

        // Invoke the delegate
        del("Hello, world");
    }
    
    public void ShowMessage1(string message)
    {
        Debug.Log("Message1: " + message);
    }

    public void ShowMessage2(string message)
    {
        Debug.Log("Message2: " + message);
    }
}
