using UnityEngine;

namespace FSMBulb
{
    public enum STATE
    {
        ON,
        OFF
    }

    public class Bulb_01 : MonoBehaviour
    {
        public STATE state;
        private Light pLight;

        void Start()
        {
            pLight = GetComponentInChildren<Light>();
        }

        void Update()
        {
            switch (state) {
                case STATE.ON:
                    pLight.enabled = true;
                    break;
                case STATE.OFF:
                    pLight.enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void OnMouseDown()
        {
            if (state == STATE.ON)
            {
                GoToState(STATE.OFF);
            }
            else if (state == STATE.OFF)
            {
                GoToState(STATE.ON);
            }
        }

        private void GoToState(STATE targetState)
        {
            state = targetState;
        }
    }
}
