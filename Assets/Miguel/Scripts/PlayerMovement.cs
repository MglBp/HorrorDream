using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float baseSpeed = 3f;
    public float acceleration = 0.1f;
    public float maxSpeed = 10f;
    public float horizontalSpeed = 5f;

    private float currentSpeed;

    void Start()
    {
        currentSpeed = baseSpeed;
    }

    void Update()
    {
        if (GameManager.instance.IsGameOver()) return;

        float moveHorizontal = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(moveHorizontal * horizontalSpeed * Time.deltaTime,
                                      currentSpeed * Time.deltaTime,
                                      0f);

        transform.Translate(movement);

        if (currentSpeed < maxSpeed)
        {
            currentSpeed += acceleration * Time.deltaTime;
        }
    }
}