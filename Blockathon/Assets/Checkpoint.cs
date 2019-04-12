using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public Vector3 respawnPoint;
    public float respawnYaw;

    private void OnTriggerEnter(Collider other)
    {
        Restart restarter = other.gameObject.GetComponent<Restart>();
        if (restarter != null)
        {
            restarter.checkpoint = respawnPoint;
            restarter.yaw = respawnYaw;
        }
    }
}
