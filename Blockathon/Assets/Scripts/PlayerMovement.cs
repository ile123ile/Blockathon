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
    public float speedLimit = 20f;
    public float turnSpeed = 30.0f;
    public float jumpDelay = 0.1f;

    private float yaw = 0.0f;
    private float prevVelY;
    private float jumpTime = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb.freezeRotation = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        jumpTime -= Time.fixedDeltaTime;
        if (Mathf.Sqrt(Mathf.Pow(rb.velocity.x, 2)+Mathf.Pow(rb.velocity.z,2)) > speedLimit)
        {
            Vector3 v = rb.velocity;
            v.y = 0;
            v = v.normalized * speedLimit;
            v.y = rb.velocity.y;
            rb.velocity = v;
        }

        //if (midAir == false)
        {
            rb.AddRelativeForce(Input.GetAxis("Horizontal") * sidewaysforce * Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);
            rb.AddRelativeForce(0,0,Input.GetAxis("Vertical") * sidewaysforce * Time.fixedDeltaTime, ForceMode.VelocityChange);
        }
        
        if (Input.GetKey(KeyCode.Space) && midAir == false && jumpTime <= 0)
        {
            rb.AddForce(0,upwardsforce * Time.fixedDeltaTime,0, ForceMode.Impulse);
            jumpTime = jumpDelay;
        }

        TurnFromMouse();

    }

    public void Knockback()
    {
        rb.AddRelativeForce(-Input.GetAxis("Horizontal") * 30 * sidewaysforce * Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);
        rb.AddRelativeForce(0, 0, -Input.GetAxis("Vertical") * 30 * sidewaysforce * Time.fixedDeltaTime, ForceMode.VelocityChange);
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
