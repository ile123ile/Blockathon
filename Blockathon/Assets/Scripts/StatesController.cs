using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatesController : MonoBehaviour
{
    Light lt;
    public int colorid;
    State[] states = { new State(0, Color.red), new State(1, Color.green), 
        new State(2, Color.blue), new State(3, Color.yellow), new State(4, Color.cyan), new State(5, Color.magenta)};
    LightState[] lightstates;

    // Start is called before the first frame update
    void Start()
    {
        lt = GetComponent<Light>();

        lightstates = (LightState[]) FindObjectsOfType(typeof(LightState));
    }

    // Update is called once per frame
    void Update()
    {
        lt.color = states[colorid].color;

        foreach (LightState e in lightstates)
        {
            Renderer rend = e.gameObject.GetComponent<Renderer>();
            if (e.colorid == this.colorid)
            {
                rend.enabled = true;
            }
            else
            {
                rend.enabled = false;
            }
        }
    }

    struct State
    {
        public int id;
        public Color color;

        public State(int id, Color color)
        {
            this.id = id;
            this.color = color;
        }
    }

}
