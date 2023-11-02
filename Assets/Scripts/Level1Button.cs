using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1Button : MonoBehaviour
{
    public string sceneToLoad; // Name of the scene to load

    public void LoadScene()
    {
        SceneManager.LoadScene(sceneToLoad); // Load the specified scene
    }
}