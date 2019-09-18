using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtonFunction : MonoBehaviour {

    PauseMenu pauseMenu;

	// Use this for initialization
	void Start () {
        pauseMenu.mainMenuActive = true;		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartButton()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;


    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene(0);
    }

    public void quitButton()
    {
        Application.Quit();
    }

    public void RestartLevelButton()
    {
        Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
    }


}
