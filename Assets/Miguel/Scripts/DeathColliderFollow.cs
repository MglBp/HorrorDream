using UnityEngine;

public class DeathColliderFollow : MonoBehaviour
{
    public Transform cameraTransform;
    public float offsetY;

    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.y = cameraTransform.position.y + offsetY;
        transform.position = newPosition;
    }
}
