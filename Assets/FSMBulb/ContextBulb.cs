using UnityEngine;
using UnityEngine.Events;

namespace FSMBulb
{
    [System.Serializable]
    public class ContextBulb: IContext
    {
        public Light light;
        public MeshRenderer meshRenderer;
        public Material matNormal;
        public Material matBroken;
        public int hp;
        public UnityEvent evtTouch;
        public Sensor sensor;

        public override void Init(Machine machine)
        {
            light = machine.GetComponentInChildren<Light>();
            meshRenderer = machine.GetComponent<MeshRenderer>();
            machine.GoToState(new StateOff(machine));
            hp = 3;
            sensor = machine.GetComponent<Sensor>();
            sensor.c = this;
        }

        public void ChangeMaterial(Material targetMat)
        {
            Material[] mats = meshRenderer.materials;
            mats[0] = targetMat;
            meshRenderer.materials = mats;
        }

        public void TurnLight(bool value)
        {
            light.enabled = value;
        }
    }
    //[System.Serializable]
    //public class Context
    //{
    //    public Light light;
    //    public MeshRenderer meshRenderer;
    //    public Material matNormal;
    //    public Material matBroken;
    //    public int hp;
    //    public UnityEvent evtTouch;
    //    public Sensor sensor;

    //    public void Init(Machine machine)
    //    {
    //        light = machine.GetComponentInChildren<Light>();
    //        meshRenderer = machine.GetComponent<MeshRenderer>();
    //        machine.GoToState(new StateOff(machine));
    //        hp = 3;
    //        sensor = machine.GetComponent<Sensor>();
    //        sensor.c = this;
    //    }

    //    public void ChangeMaterial(Material targetMat)
    //    {
    //        Material[] mats = meshRenderer.materials;
    //        mats[0] = targetMat;
    //        meshRenderer.materials = mats;
    //    }

    //    public void TurnLight(bool value)
    //    {
    //        light.enabled = value;
    //    }
    //}
}
