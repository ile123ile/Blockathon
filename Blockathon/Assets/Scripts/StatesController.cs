using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatesController : MonoBehaviour
{
    Light lt;
    public int colorid;
    public State[] states = { new State(0, Color.red), new State(1, Color.green) };
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
            if (e.colorid != this.colorid)
            {
                rend.enabled = true;
            }
            else
            {
                rend.enabled = false;
            }
        }
    }

    [System.Serializable]
    public struct State
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
