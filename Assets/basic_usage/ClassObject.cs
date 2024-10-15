using UnityEngine;

[System.Serializable]
public class Car
{
    public string brand;
    public int[] tires;
}

[System.Serializable]
public class Person
{
    public string name;
    public int age;
    public Car car;
}

public class ClassObject : MonoBehaviour
{
    public Person carOwner;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
