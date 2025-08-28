using UnityEngine;

public class DebugCollision : MonoBehaviour
{
    void Update()
    {
        // Teste manual com tecla T
        if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log("Testando Game Over manualmente...");
            FindObjectOfType<GameManager>().GameOver();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Encostei em: " + other.name);

        if (other.CompareTag("Obstacle"))
        {
            Debug.Log("Chamando Game Over...");
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}