using UnityEngine;

namespace FSMBulb
{
    public class Bulb_02 : MonoBehaviour
    {
        public STATE state;
        private Light pLight;
        private bool triggerEnter;

        void Start()
        {
            pLight = GetComponentInChildren<Light>();
            triggerEnter = false;
        }

        void Update()
        {
            switch (state)
            {
                case STATE.ON:
                    if (triggerEnter)
                    {
                        pLight.enabled = true;
                    }
                    break;
                case STATE.OFF:
                    if (triggerEnter)
                    {
                        pLight.enabled = false;
                    }
                    break;
                default:
                    break;
            }
            triggerEnter = false;
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
            triggerEnter = true;
        }
    }
}
