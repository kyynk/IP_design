using UnityEngine;

namespace FSMBulb
{
    public class StateOn : IState
    {
        public StateOn(Machine machine) : base(machine) { }

        public override void OnEnter()
        {
            machine.c.TurnLight(true);
            machine.c.ChangeMaterial(machine.c.matNormal);
            machine.c.evtTouch.AddListener(OnMouseDown);
            //Debug.Log("StateOn: OnEnter.");
        }

        public override void IsState()
        {
            if (Input.GetKeyDown("t"))
            {
                machine.GoToState(new StateOff(machine));
            }
            //Debug.Log("StateOn: IsState.");
        }

        public override void OnExit()
        {
            machine.c.evtTouch.RemoveListener(OnMouseDown);
            //Debug.Log("StateOn: OnExit.");
        }

        public void OnMouseDown()
        {
            machine.GoToState(new StateOff(machine));
        }
    }
}
