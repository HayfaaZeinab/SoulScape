using UnityEngine;
using UnityEngine.SceneManagement;  // Required for scene management

public class ChangeScene : MonoBehaviour
{
    public void LoadScene(string scene)
    {
        SceneManager.LoadScene(scene); // Load the specified scene
    }
}
