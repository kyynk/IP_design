using UnityEngine;

public class Input_Manager_MethodCall : MonoBehaviour
{
    public Character_wMove charMove;

    private void Update()
    {
        if (Input.GetKey("w"))
        {
            charMove.Move(charMove.transform.forward * 2.0f);
        }
        if (Input.GetKey("s"))
        {
            charMove.Move(charMove.transform.forward * -2.0f);
        }
        if (Input.GetKey("d"))
        {
            charMove.Move(charMove.transform.right * 2.0f);
        }
        if (Input.GetKey("a"))
        {
            charMove.Move(charMove.transform.right * -2.0f);
        }
    }
}
