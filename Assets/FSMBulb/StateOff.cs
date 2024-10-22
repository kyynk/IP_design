using UnityEngine;

namespace FSMBulb
{
    public class StateOff : IState
    {
        public StateOff(Machine machine) : base(machine) { }

        public override void OnEnter()
        {
            Debug.Log("StateOff: OnEnter.");
        }

        public override void IsState()
        {
            if (Input.GetKeyDown("t"))
            {
                machine.GoToState(new StateOn(machine));
            }
            Debug.Log("StateOff: IsState.");
        }

        public override void OnExit()
        {
            Debug.Log("StateOff: OnExit.");
        }
    }
}
