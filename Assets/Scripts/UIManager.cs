using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // For referencing the Button if needed

public class StartGameController : MonoBehaviour
{
    [Header("Audio")]
    [SerializeField] private AudioManager gameAudioSource;
    
    [Header("Spawners")]
    [SerializeField] private GameObject[] spawnerGameObjects;

    [Header("UI")]
    [SerializeField] private Canvas menuCanvas;

    /// <summary>
    /// Call this method when the button is pressed.
    /// </summary>
    public void OnStartButtonPressed()
    {
         if (menuCanvas != null)
        {
            menuCanvas.enabled = false;
        }
        // Play the audio if not already playing
        if (gameAudioSource != null)
        {
            gameAudioSource.Play();
        }

        // Activate all the spawners
        foreach (GameObject spawner in spawnerGameObjects)
        {
            if (spawner != null)
            {
                spawner.SetActive(true);
            }
        }
    }

    public void OnRestartButtonPressed()
    {
        // Reload the current active scene
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.buildIndex);
    }
}
