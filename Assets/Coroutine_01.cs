using System.Collections;
using UnityEngine;

public class Coroutine_01 : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(MyCoroutine());
    }

    private IEnumerator MyCoroutine()
    {
        Debug.Log("Coroutine started");
        yield return new WaitForSeconds(2);
        Debug.Log("Coroutine resumed after 2 seconds");
        yield return new WaitForSeconds(2);
        Debug.Log("Coroutine resumed after 4 seconds");
        yield return new WaitForSeconds(2);
        Debug.Log("Coroutine resumed after 6 seconds");
        yield return null;
    }
}
