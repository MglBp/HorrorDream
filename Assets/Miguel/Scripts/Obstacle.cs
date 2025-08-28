using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float rotationSpeed = 30f;

    void Update()
    {
        if (!GameManager.instance.IsGameOver())
        {
            transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
        }
    }
}