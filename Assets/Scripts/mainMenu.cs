using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        // Load the game scene
        SceneManager.LoadSceneAsync(1);
    }

    public void QuitGame()
    {
        // Quit the application
        Application.Quit();
        
        // If running in the editor, log a message
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
