using UnityEngine;

public class JSON_03 : MonoBehaviour
{
    Person person = new Person();
    Car car = new Car();

    // Start is called before the first frame update
    private void Start()
    {
        car.brand = "Toyota";
        car.tires = new int[3] { 100, 90, 78 };

        person.name = "Bob json03";
        person.age = 30;
        person.car = car;

        print(JsonUtility.ToJson(person));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
