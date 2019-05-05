using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public GameObject Player;
    public float movementSpeed = 4;
    void Update()
    {
        transform.LookAt(Player.transform);

        Vector3 p = transform.position;
        Vector3 q = Player.transform.position;
        float f = Vector3.Distance(p, q);
        if (f <= 50.0)
        {
            transform.position += transform.forward * movementSpeed * Time.deltaTime;
        }
    }
}