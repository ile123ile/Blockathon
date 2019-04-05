using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public PlayerMovement player;
    public Vector3 offset;
    public float turnSpeed = 30.0f;
    public float maxPitch = 80f;
    public float minPitch = -80f;

    private float pitch = 0.0f;
    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position;
        transform.rotation = player.transform.rotation;
        Vector3 newAngle = player.transform.eulerAngles;
        newAngle.y = player.Yaw;
        transform.eulerAngles = newAngle;
        TurnFromMouse();
        transform.Translate(offset);


    }

    private void TurnFromMouse()
    {
        Cursor.lockState = CursorLockMode.Locked;
        pitch -= turnSpeed * Time.fixedDeltaTime * Input.GetAxis("Mouse Y");
        pitch = Mathf.Min(Mathf.Max(pitch, minPitch), maxPitch);
        Vector3 newAngle = transform.eulerAngles;
        newAngle.x = pitch;
        transform.eulerAngles = newAngle;
    }
}
