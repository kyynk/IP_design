using UnityEngine;

namespace FSMBulb
{
    public class StateOff : IState
    {
        public StateOff(Machine machine) : base(machine) { }

        public override void OnEnter()
        {
            machine.c.TurnLight(false);
            machine.c.ChangeMaterial(machine.c.matNormal);
            machine.c.evtTouch.AddListener(OnMouseDown);
            //Debug.Log("StateOff: OnEnter.");
        }

        public override void IsState()
        {
            //if (Input.GetKeyDown("t"))
            //{
            //    if (machine.c.hp > 0)
            //    {
            //        machine.c.hp--;
            //        machine.GoToState(new StateOn(machine));
            //    }
            //    else
            //    {
            //        machine.GoToState(new StateBroken(machine));
            //    }
            //}
            //Debug.Log("StateOff: IsState.");
        }

        public override void OnExit()
        {
            machine.c.evtTouch.RemoveListener(OnMouseDown);
            //Debug.Log("StateOff: OnExit.");
        }

        public void OnMouseDown()
        {
            if (machine.c.hp > 0)
            {
                machine.c.hp--;
                machine.GoToState(new StateOn(machine));
            }
            else
            {
                machine.GoToState(new StateBroken(machine));
            }
        }
    }
}
