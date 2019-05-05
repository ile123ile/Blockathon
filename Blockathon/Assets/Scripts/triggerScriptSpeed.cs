using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class triggerScriptSpeed : MonoBehaviour
{
    PlayerMovement p;
    System.Random rnd = new System.Random();
    float speed; //tbh is it even worth storing this if we're just going to update each time the ball collides it

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.GetComponent<PlayerCollision>() != null)
        {
            //if the normal right now
            if (speed == 20f)
            {
                int fastOrSlow = rnd.Next(1);  //generates random number between 0 and 1

                if (fastOrSlow == 0) //make it slow
                {
                    speed = speed / 2;
                }
                else if (fastOrSlow == 1) //make it fast
                {
                    speed = speed * 2;
                }

                p.speedLimit = speed; //set new speedLimits

            }
            //else if speed is fast right now or its slow righ tnow
            else if (speed == 40f || speed == 10f) // 40f would be 2 * 20f right? and 10f would be 20f/2 right?
            {
                speed = 20f; //change it back to normal
            }

        }
    }


        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    
}