using System.Collections;
using UnityEngine;

public class Coroutine_03 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FirstCoroutine());
    }

    private IEnumerator FirstCoroutine()
    {
        Debug.Log("First Coroutine");
        yield return new WaitForSeconds(1);
        yield return StartCoroutine(SecondCoroutine());
    }

    private IEnumerator SecondCoroutine()
    {
        Debug.Log("Second Coroutine");
        yield return null;
    }
}
