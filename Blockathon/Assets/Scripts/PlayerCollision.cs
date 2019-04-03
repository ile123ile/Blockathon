
using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    public void FixedUpdate()
    {
        if (Physics.Raycast(transform.position, new Vector3(0, -1, 0), out RaycastHit hit, 1))
        {
            movement.midAir = false;
        }
        else
        {
            movement.midAir = true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Spikes")
        {
            Debug.Log("spiky");
            movement.pstate.addStatus("hurt");
        }
        
        if (collision.collider.tag == "Obstacle")
        {
            Debug.Log("AAAAAAAAAAAAAAAAA");
            movement.Knockback();
        }
    }
}
