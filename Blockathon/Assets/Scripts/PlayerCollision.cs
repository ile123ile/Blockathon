
using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    public void FixedUpdate()
    {
        if (Physics.Raycast(transform.position, new Vector3(0, -1, 0), out RaycastHit hit, 1)
            && !hit.collider.isTrigger)
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

        if (collision.collider.tag == "Obstacle")
        {
            movement.Knockback(30);
        }

        if (collision.collider.tag == "Enemy")
        {
            gameObject.GetComponent<Restart>().Teleport();
        }

    }
}
