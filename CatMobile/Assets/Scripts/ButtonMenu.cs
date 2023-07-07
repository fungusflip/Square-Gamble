using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonMenu : MonoBehaviour
{
    
	public void Exit()
	{ 
		Application.Quit();
	}

	public void SwitchToScene(string sceneName)
	{
		SceneManager.LoadScene(sceneName);
	}
}	
