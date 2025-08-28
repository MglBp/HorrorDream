using UnityEngine;

public class DeathColliderFollow : MonoBehaviour
{
    public Transform cameraTransform;
    public float offsetY = -10f;

    void Update()
    {
        Vector3 newPosition = new Vector3(transform.position.x,
                                         cameraTransform.position.y + offsetY,
                                         transform.position.z);
        transform.position = newPosition;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instance.GameOver();
        }
    }
}