
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            Debug.Log("WTF MAN XD");
        }
        if (collision.collider.tag == "Ground")
        {
            movement.midAir = false;
        }
    }
}
