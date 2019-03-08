using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardforce = 1000f;
    public float sidewaysforce = 600f;
    public float upwardsforce = 6000f;
    public bool midAir = false;
    public float speedLimit = 200f;
    public float turnSpeed = 30.0f;

    private float yaw = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb.freezeRotation = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log(rb.velocity.magnitude);
        if (Mathf.Sqrt(Mathf.Pow(rb.velocity.x, 2)+Mathf.Pow(rb.velocity.z,2)) > speedLimit)
        {
            Vector3 v = rb.velocity;
            v.y = 0;
            v = v.normalized;
            rb.velocity = v * speedLimit;
        }

        if (midAir == false)
        {
            rb.AddRelativeForce(Input.GetAxis("Horizontal") * sidewaysforce * Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);
            rb.AddRelativeForce(0,0,Input.GetAxis("Vertical") * sidewaysforce * Time.fixedDeltaTime, ForceMode.VelocityChange);
        }
        
        if (Input.GetKey(KeyCode.Space) && midAir == false)
        {
            rb.AddForce(0,upwardsforce * Time.fixedDeltaTime,0, ForceMode.Impulse);
            midAir = true;
        }

        TurnFromMouse();

    }

    private void TurnFromMouse()
    {
        Cursor.lockState = CursorLockMode.Locked;
        yaw += turnSpeed * Time.fixedDeltaTime * Input.GetAxis("Mouse X");
        Vector3 newAngle = transform.eulerAngles;
        newAngle.y = yaw;
        transform.eulerAngles = newAngle;
    }
}
