using UnityEngine;

namespace FSMBulb
{
    public class Bulb_04 : MonoBehaviour
    {
        public STATE state;
        public Material matNormal;
        public Material matBroken;

        private Light pLight;
        private MeshRenderer meshRenderer;
        [SerializeField]
        private int hp;
        private bool triggerEnter;

        void Start()
        {
            pLight = GetComponentInChildren<Light>();
            meshRenderer = GetComponent<MeshRenderer>();
            triggerEnter = false;
            hp = 3;
        }

        void Update()
        {
            switch (state)
            {
                case STATE.ON:
                    if (triggerEnter)
                    {
                        ChangeMaterial(matNormal);
                        pLight.enabled = true;
                    }
                    break;
                case STATE.OFF:
                    if (triggerEnter)
                    {
                        ChangeMaterial(matNormal);
                        pLight.enabled = false;
                    }
                    break;
                case STATE.BROKEN:
                    if (triggerEnter)
                    {
                        ChangeMaterial(matBroken);
                        pLight.enabled = false;
                        print("Broken");
                    }
                    break;
                default:
                    break;
            }
            triggerEnter = false;
            if (Input.GetKeyDown("f"))
            {
                if (state == STATE.BROKEN)
                {
                    hp = 3;
                    GoToState(STATE.OFF);
                }
            }
        }

        private void OnMouseDown()
        {
            if (state == STATE.ON)
            {
                GoToState(STATE.OFF);
            }
            else if (state == STATE.OFF)
            {
                if (hp > 0)
                {
                    hp -= 1;
                    GoToState(STATE.ON);
                }
                else
                {
                    GoToState(STATE.BROKEN);
                }
            }
        }

        private void GoToState(STATE targetState)
        {
            state = targetState;
            triggerEnter = true;
        }

        private void ChangeMaterial(Material targetMat)
        {
            Material[] mats = meshRenderer.materials;
            mats[0] = targetMat;
            meshRenderer.materials = mats;
        }
    }
}
