using UnityEngine;

namespace FSMBulb
{
    public class Machine : MonoBehaviour
    {
        private IState state;
        private bool triggerEnter;

        void Start()
        {
            // state = new StateOn(this);
            GoToState(new StateOn(this));
        }

        void Update()
        {
            if (triggerEnter)
            {
                state?.OnEnter();
                triggerEnter = false;
            }
            state?.IsState();
        }

        public void GoToState(IState targetState)
        {
            state?.OnExit();
            state = targetState;
            triggerEnter = true;
        }
    }
}
