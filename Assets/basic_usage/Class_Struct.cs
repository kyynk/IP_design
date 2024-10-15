using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    // Properties
    public string Name { get; set; }  // auto property, read/write
    public int Health { get; }        // auto property, read-only

    private int id;
    public int Id
    {
        get { return id; }            // getter
        set { id = value; }           // setter
    }

    // Fields
    public string NickName;
    private int age;

    // Methods
    public void Attack()
    {
        // Attack logic
    }
}

public struct Point
{
    public float x { get; set; }
    public float y { get; set; }

    public Point(float _x, float _y)
    {
        x = _x;
        y = _y;
    }
}

public class Class_Struct : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
