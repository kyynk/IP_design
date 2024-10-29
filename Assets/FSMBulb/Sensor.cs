using UnityEngine;

namespace FSMBulb
{
    public class Sensor : MonoBehaviour
    {
        public ContextBulb c;

        public void OnMouseDown()
        {
            c?.evtTouch?.Invoke();
        }
    }
}
