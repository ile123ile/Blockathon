using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerScript : MonoBehaviour
{
    StatesController s;
    int colorIndex;

    //enters this method of something hits the trigger
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.GetComponent<PlayerCollision>() != null)
        {
            colorIndex = s.colorid;

            if (colorIndex + 1 > s.states.Length)
            {
                colorIndex = -1;
            }

            colorIndex++;
            s.colorid = colorIndex;




            //    //change light

            //    //if the colorid of the light is the first index (red)
            //    if(s.colorid == 0)
            //    {
            //        //change the color to the second index (blue)
            //        s.colorid = 1;

            //        //set the public variable colorIndex to colorid as well
            //        colorIndex = 1;
            //    }
            //    //if the colorid of the light is the second index (blue)
            //   else if (s.colorid == 1)
            //    {
            //        //change the color to the second index (blue)
            //        s.colorid = 0;
            //        //
            //        colorIndex = 0;
            //    }
            //}

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
}