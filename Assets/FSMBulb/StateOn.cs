using UnityEngine;

namespace FSMBulb
{
    public class StateOn : IState
    {
        public StateOn(Machine machine) : base(machine) { }

        public override void OnEnter()
        {
            Debug.Log("StateOn: OnEnter.");
        }

        public override void IsState()
        {
            if (Input.GetKeyDown("t"))
            {
                machine.GoToState(new StateOff(machine));
            }
            Debug.Log("StateOn: IsState.");
        }

        public override void OnExit()
        {
            Debug.Log("StateOn: OnExit.");
        }
    }
}
