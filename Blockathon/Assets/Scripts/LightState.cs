using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightState : MonoBehaviour
{
    public int colorid;
    public double timeToShow = 0.5;
    public double timeLeft;
    private Renderer rend;

    public void Start()
    {
        rend = gameObject.GetComponent<Renderer>();
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<PlayerMovement>() != null)
        {
            if(!rend.enabled)
            {
                timeLeft = timeToShow;
            }
        }
    }

    public void FixedUpdate()
    {
        if(timeLeft > 0)
        {
            timeLeft -= Time.fixedDeltaTime;
        }
    }
}
