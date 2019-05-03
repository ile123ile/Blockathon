using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerLighting : MonoBehaviour
{
    public StatesController sc;
    public int colorToSet;

    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMovement>() != null)
        {
            sc.colorid = colorToSet;
        }
    }
}
