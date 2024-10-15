using System.Collections;
using UnityEngine;

public class Coroutine_04 : MonoBehaviour
{
    private Coroutine myCoroutine;

    // Start is called before the first frame update
    private void Start()
    {
        myCoroutine = StartCoroutine(MyCoroutine());
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            StopCoroutine(myCoroutine);
        }
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
