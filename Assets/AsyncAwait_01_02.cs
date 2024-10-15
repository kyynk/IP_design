using System.Threading.Tasks;
using UnityEngine;

public class AsyncAwait_01_02 : MonoBehaviour
{
    // 01
    //void Start()
    //{
    //    print("Before");
    //    MethodA();
    //    print("After");
    //}
    // 02
    async void Start()
    {
        print("Before");
        await MethodA();
        print("After");
    }

    async Task MethodA()
    {
        print("Method A Start");
        await Task.Delay(2000);    // wait for 2 seconds
        print("Method A End");
    }
}
