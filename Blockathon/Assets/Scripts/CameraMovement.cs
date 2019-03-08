using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {
    public float speedH = 2.0f;
    public float speedV = 2.0f;
    public float maxPitch = 80f;
    public float minPitch = -80f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    void Update()
    {
        Cursor.lockState = CursorLockMode.Locked;

        bool iPressed = Input.GetKey(KeyCode.I);
        bool jPressed = Input.GetKey(KeyCode.J);
        bool kPressed = Input.GetKey(KeyCode.K);
        bool lPressed = Input.GetKey(KeyCode.L);

        if (iPressed)
        {
            pitch -= speedV;
        }
        if (jPressed)
        {
            yaw -= speedH;
        }
        if (kPressed)
        {
            pitch += speedV;
        }
        if (lPressed)
        {
            yaw += speedH;
        }
        
        if (!iPressed && !jPressed && !kPressed && !lPressed)
        {
            yaw += 5 * speedH * Input.GetAxis("Mouse X");
            pitch -= 5 * speedV * Input.GetAxis("Mouse Y");
        }
        pitch = Mathf.Max(Mathf.Min(pitch, maxPitch), minPitch);
        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }
}
