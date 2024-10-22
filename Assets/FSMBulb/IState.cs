using UnityEngine;

namespace FSMBulb
{
    public abstract class IState
    {
        protected Machine machine;

        public IState(Machine _machine)
        {
            machine = _machine;
            Debug.Log("state create.");
        }

        public abstract void OnEnter();
        public abstract void IsState();
        public abstract void OnExit();
    }
}
