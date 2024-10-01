using Defective.JSON;
using UnityEngine;

public class JSON_01 : MonoBehaviour
{
    JSONObject jsonPerson = new JSONObject();

    // Start is called before the first frame update
    void Start()
    {
        JSONObject jsonCar = new JSONObject();
        jsonCar.AddField("brand", "Toyota");
        jsonCar.AddField("tires", new JSONObject("[100, 90, 78]"));

        jsonPerson.AddField("name", "Bob json01");
        jsonPerson.AddField("age", 30);
        jsonPerson.AddField("car", jsonCar);

        print(jsonPerson.ToString());
        print(jsonPerson["name"]);
        print(jsonPerson["car"]["tires"][1]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
