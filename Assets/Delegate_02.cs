using UnityEngine;

public class Delegate_02 : MonoBehaviour
{
    public delegate void MyDelegate(string message, int hour, int min, int sec);

    // Start is called before the first frame update
    void Start()
    {
        MyDelegate myDele = new MyDelegate(ShowTime);
        myDele("Hello, world", 7, 5, 55);

        myDele = new MyDelegate(ShowAlarmSettings);
        myDele("Wake up in the morning", 7, 5, 55);
    }

    public void ShowTime(string message, int hour, int min, int sec)
    {
        Debug.Log(message);
        Debug.Log($"The time now is: {hour}:{min}:{sec}");
    }

    public void ShowAlarmSettings(string label  , int hour, int min, int sec)
    {
        Debug.Log($"Alarm: <{label}> will be ring on {hour:D2}:{min:D2}:{sec:D2}");
    }
}
