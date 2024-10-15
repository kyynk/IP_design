using UnityEngine;

namespace MyProject
{
    public class ClassAndObject : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Character chracter = new Character();
            chracter.Name = "John";
            chracter.Age = 20;
            chracter.Greet();
        }
    }

    public class Character
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Greet()
        {
            Debug.Log("Hello, my name is " + Name);
        }
    }
}

