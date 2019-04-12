using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour
{
    public Vector3 checkpoint = new Vector3(0, 1, 0);
    public float yaw = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("k"))
        {
            Teleport();
        }
    }

    public void Teleport()
    {
        transform.position = checkpoint;
        gameObject.GetComponent<PlayerMovement>().setYaw(yaw);
    }
}
