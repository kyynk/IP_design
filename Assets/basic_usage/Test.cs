using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum STATE
{
    IDLE,
    COUNTDOWN,
    RUN,
    GAMEOVER
}

public class Test : MonoBehaviour
{
    public STATE state;

    // Start is called before the first frame update
    void Start()
    {
        state = STATE.RUN;
        print("start state is: " + state.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        // game loop
        switch (state)
        {
            case STATE.IDLE:
                print("IDLE");
                // idle logic
                if (Input.GetKeyDown("1"))
                {
                    state = STATE.COUNTDOWN;
                }
                break;
            case STATE.COUNTDOWN:
                print("COUNTDOWN");
                // countdown logic
                break;
            case STATE.RUN:
                print("RUN");
                // run logic
                break;
            case STATE.GAMEOVER:
                print("GAMEOVER");
                // gameover logic
                break;
            default:
                break;
        }
    }
}
