using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadScene(int buildIndex)
    {
        int sceneToLoad = LoopBuildIndex(buildIndex);
        SceneManager.LoadScene(buildIndex);
    }

    public void LoadNextScene()
    {
        int sceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
        sceneToLoad = LoopBuildIndex(sceneToLoad);
        SceneManager.LoadScene(sceneToLoad);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    private int LoopBuildIndex(int buildIndex)
    {
        if (buildIndex >= SceneManager.sceneCountInBuildSettings || buildIndex < 0)
        {
            Debug.Log("invalid build index, loading scene 0");
            buildIndex = 0;
        }
        return buildIndex;
    }
    public void LoadLossScreen()
    {
        SceneManager.LoadScene("GameOver");
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }
}
