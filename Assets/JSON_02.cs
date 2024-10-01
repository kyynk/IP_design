using Defective.JSON;
using UnityEngine;

public class JSON_02 : MonoBehaviour
{
    JSONObject jsonPerson;

    // Start is called before the first frame update
    void Start()
    {
        string jsonString = "{" +
                "\"name\": \"Bob json02\"," +
                "\"age\": 30," +
                "\"car\": {" +
                    "\"brand\": \"Toyota\"," +
                    "\"tires\": [100, 90, 78]" +
                "}" +
            "}";

        jsonPerson = new JSONObject(jsonString);
        print(jsonPerson["name"]);
        print(jsonPerson["age"]);
        print(jsonPerson["car"]["brand"]);
        print(jsonPerson["car"]["tires"][0]);
        print(jsonPerson["car"]["tires"][1]);
        print(jsonPerson["car"]["tires"][2]);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
