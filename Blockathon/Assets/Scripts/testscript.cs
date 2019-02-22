using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//wu tang clams ain't nuthin to suck with.

public class testscript : MonoBehaviour
{
    public Vector3 spinspeed = new Vector3(2, 5, 10);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(spinspeed);
    }
}
