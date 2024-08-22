using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public void Restart()
    {
        // Load lại Scene hiện tại
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}