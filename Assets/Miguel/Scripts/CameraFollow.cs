using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float minY;
    private float highestY;
    private Vector3 initialPosition;

    void Start()
    {
        initialPosition = transform.position;
        highestY = player.position.y;
    }

    void Update()
    {
        if (player.position.y > highestY)
        {
            highestY = player.position.y;
        }

        Vector3 newPosition = transform.position;

        if (highestY > minY)
        {
            newPosition.y = highestY;
        }
        else
        {
            newPosition.y = minY;
        }

        transform.position = newPosition;
    }
}