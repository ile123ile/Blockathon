﻿
using UnityEngine;

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
}
