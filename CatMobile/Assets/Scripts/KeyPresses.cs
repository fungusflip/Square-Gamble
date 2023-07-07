using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyPresses : MonoBehaviour
{
	public string sceneName;

    void Update()
    {

	    if (Input.GetKeyDown(KeyCode.Escape))
	    {
		    SwitchToScene(sceneName);
	    }
        
    }

    public void SwitchToScene(string sceneName)
    {
	    SceneManager.LoadScene(sceneName);
    }

}
