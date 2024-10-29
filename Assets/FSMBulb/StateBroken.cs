using UnityEngine;

namespace FSMBulb
{
    public class StateBroken : IState
    {
        public StateBroken(Machine machine) : base(machine) { }

        public override void OnEnter()
        {
            machine.c.TurnLight(false);
            machine.c.ChangeMaterial(machine.c.matBroken);
            //Debug.Log("StateBroken: OnEnter.");
        }

        public override void IsState()
        {
            if (Input.GetKeyDown("r"))
            {
                machine.c.hp = 3;
                machine.GoToState(new StateOff(machine));
            }
            //Debug.Log("StateBroken: IsState.");
        }

        public override void OnExit()
        {
            //Debug.Log("StateBroken: OnExit.");
        }
    }
}
