using UnityEngine;
using UnityEngine.UI;

public class AsyncAwait_04 : MonoBehaviour
{
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        MethodA();
        print("Start ends");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            text.text = "W pressed";
        }
        else
        {
            text.text = "W not pressed";
        }
    }

    void MethodA()
    {
        long a = 0;
        //for (long i = 0; i < 30000000000; i++)
        for (long i = 0; i < 300; i++)
        {
            a++;
        }
        print("end of MethodA: " + a);
    }

}
