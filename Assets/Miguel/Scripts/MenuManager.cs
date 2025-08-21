using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    [Header("Botões")]
    public Button playButton;
    public Button quitButton;

    [Header("Configurações")]
    public string sceneToLoad = "GameScene";

    void Start()
    {
        if (playButton != null)
        {
            playButton.onClick.AddListener(PlayGame);
        }

        if (quitButton != null)
        {
            quitButton.onClick.AddListener(QuitGame);
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(sceneToLoad);

        Debug.Log("Carregando cena: " + sceneToLoad);
    }

    public void QuitGame()
    {
        Debug.Log("Saindo do jogo...");

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        // Se estiver em build compilado
        Application.Quit();
#endif
    }

    public void LoadScene(string sceneName)
    {
        if (!string.IsNullOrEmpty(sceneName))
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}