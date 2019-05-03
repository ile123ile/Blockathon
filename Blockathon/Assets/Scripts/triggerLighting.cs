using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerLighting : MonoBehaviour
{
    public StatesController sc;
    public int colorToSet = -3;

    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMovement>() != null)
        {
            if (colorToSet >= 0)
            {
                sc.colorid = colorToSet;
            }
            else
            {
                sc.colorid += 1;
                if (sc.colorid >= -colorToSet)
                {
                    sc.colorid = 0;
                }
            }
        }
    }
}
