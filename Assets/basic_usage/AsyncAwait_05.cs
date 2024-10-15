using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class AsyncAwait_05 : MonoBehaviour
{
    public Text text;

    // 01
    //void Start()
    //{
    //    MethodA();
    //    print("Start ends");
    //}

    //  02
    async Task Start()
    {
        int result = await MethodA();
        print("Start ends: " + result);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            text.text = "W is pressed";
        }
        else
        {
            text.text = "";
        }
    }

    // 01
    //async Task MethodA()
    // 02
    async Task<int> MethodA()
    {
        await Task.Run(() =>
        {
            long a = 0;
            //for (long i = 0; i < 30000000000; i++)
            for (long i = 0; i < 3000000; i++)
            {
                a++;
            }
            print("end of MethodA: " + a);
        });
        // 02
        return 888;
    }
}
