using UnityEngine;

public class Input_Manager_SendMessage : MonoBehaviour
{
    public GameObject character;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey("w"))
        {
            character.SendMessage("Move", character.transform.forward * 2.0f);
        }
        if (Input.GetKey("s"))
        {
            character.SendMessage("Move", character.transform.forward * -2.0f);
        }
        if (Input.GetKey("d"))
        {
            character.SendMessage("Move", character.transform.right * 2.0f);
        }
        if (Input.GetKey("a"))
        {
            character.SendMessage("Move", character.transform.right * -2.0f);
        }
    }
}
