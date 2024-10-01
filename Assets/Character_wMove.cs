using UnityEngine;

public class Character_wMove : MonoBehaviour
{
    // Update is called once per frame
    //private void Update()
    //{
    //    if (Input.GetKey("w"))
    //    {
    //        Move(transform.forward * 2.0f);
    //    }
    //    if (Input.GetKey("s"))
    //    {
    //        Move(transform.forward * -2.0f);
    //    }
    //    if (Input.GetKey("d"))
    //    {
    //        Move(transform.right * 2.0f);
    //    }
    //    if (Input.GetKey("a")) {
    //        Move(transform.right * -2.0f);
    //    }
    //}

    public void Move(Vector3 velocity)
    {
        transform.position += velocity *= Time.deltaTime;
    }
}
