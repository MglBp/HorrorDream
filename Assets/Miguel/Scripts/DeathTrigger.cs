using UnityEngine;

public class DeathTrigger : MonoBehaviour
{
    public GameObject gameOverScreen;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            gameOverScreen.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}