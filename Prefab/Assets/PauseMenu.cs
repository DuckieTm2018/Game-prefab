using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {


    public static PauseMenu
        
    Instance { get; private set; }
    public bool GameIsPaused { get; private set; }
    public GameObject pauseMenuUI;
    public KeyCode pauseKey = KeyCode.P;

    public bool IsInMainMenu; 

    private void Awake()
    {
        if (Instance != null && Instance != this)
        { 
            Destroy(this);
            return;
        }
        Instance = this;
    }

    void Start()
    {
        DontDestroyOnLoad(this);
        pauseMenuUI.SetActive(false);

    }

    // Update is called once per frame
    void Update () {
		if (Input.GetKeyDown(pauseKey))
        {

          
            

                if (GameIsPaused)
                {

                    Resume();



                }
                else
                {
                    Pause();



                    Debug.Log(GameIsPaused);
                }
         
        }
	}

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene(0);
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void quitButton()
    {
        Application.Quit();
    }

    public void RestartLevelButton()
    {
        Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Pause()
    {
        GameIsPaused = true;
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
