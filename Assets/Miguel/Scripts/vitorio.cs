using UnityEngine;
using UnityEngine.SceneManagement;

public class Vitoria : MonoBehaviour
{
    [Tooltip("vitorio")]
    public string victorySceneName = "vitoriaScene";

    [Tooltip("Evita múltiplos carregamentos acidentais.")]
    public bool disableAfterTrigger = true;

    private bool triggered = false;

    void Reset()
    {
        
        Collider2D col = GetComponent<Collider2D>();
        if (col != null)
            col.isTrigger = true;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (triggered) return; // evita muitos disparos

        
        if (other.CompareTag("Player"))
        {
            triggered = true;

            if (disableAfterTrigger)
                GetComponent<Collider2D>().enabled = false;

            LoadVictoryScene();
        }
    }

    void LoadVictoryScene()
    {
        
        SceneManager.LoadScene("vitorio");
    }
}