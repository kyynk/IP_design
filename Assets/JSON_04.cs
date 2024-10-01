using UnityEngine;

public class JSON_04 : MonoBehaviour
{
    Person person = new Person();
    Car car = new Car();

    // Start is called before the first frame update
    private void Start()
    {
        string jsonString = "{" +
            "\"name\": \"Bob json04\"," +
            "\"age\": 30," +
            "\"car\": {" +
                "\"brand\": \"Toyota\"," +
                "\"tires\": [100, 90, 78]" +
            "}" +
        "}";

        person = JsonUtility.FromJson<Person>(jsonString);
        print(person.name);
        print(person.age);
        print(person.car.brand);
        print(person.car.tires[0]);
        print(person.car.tires[1]);
        print(person.car.tires[2]);
    }
}
