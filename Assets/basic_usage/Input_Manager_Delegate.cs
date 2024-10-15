using UnityEngine;

public class Input_Manager_Delegate : MonoBehaviour
{
    public Character_wMove charMove;
    public delegate void DelegateMove(Vector3 velocity);
    private DelegateMove delegateMove;

    private void OnEnable()
    {
        delegateMove += charMove.Move;
    }

    private void OnDisable()
    {
        delegateMove -= charMove.Move;
    }

    private void Update()
    {
        if (Input.GetKey("w"))
        {
            delegateMove(charMove.transform.forward * 2.0f);
        }
        if (Input.GetKey("s"))
        {
            delegateMove(charMove.transform.forward * -2.0f);
        }
        if (Input.GetKey("d"))
        {
            delegateMove(charMove.transform.right * 2.0f);
        }
        if (Input.GetKey("a"))
        {
            delegateMove(charMove.transform.right * -2.0f);
        }
    }
}
