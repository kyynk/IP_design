using System.Collections;
using UnityEngine;

public class Coroutine_05 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Program starts");
        StartCoroutine(CoroutineA());
        print("Program ends");
    }

    IEnumerator CoroutineA()
    {
        print("CoroutineA starts");

        yield return new WaitForSeconds(1);

        print("CoroutineA ends");
    }
}
