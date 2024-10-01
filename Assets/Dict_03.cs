using System.Collections.Generic;
using UnityEngine;

public class Dict_03 : MonoBehaviour
{
    public Dictionary<string, string> dict;
    // Start is called before the first frame update
    void Start()
    {
        dict = new Dictionary<string, string> {
            { "keyA", "valueA" },
            { "keyB", "valueB" },
            { "keyC", "valueC" }
        };
        foreach (var item in dict)  // use Anonymous Type
        {
            print(item.Key + " : " + item.Value);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
