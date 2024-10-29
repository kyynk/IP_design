using UnityEngine;

namespace FSMBulb
{
    public class Machine : MonoBehaviour
    {
        // don't use public ContextBulb c = new ContextBulb(); here,
        // since it will create a new instance of ContextBulb on Unity Editor
        public ContextBulb c;
        //public Context c = new Context();

        private IState state;
        private bool triggerEnter;

        public void Init(ContextBulb _c)
        {
            c = _c;
            c.Init(this);
        }

        void Start()
        {
            Init(c);
            //c.Init(this);
            //// state = new StateOn(this);
            //GoToState(new StateOn(this));
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
