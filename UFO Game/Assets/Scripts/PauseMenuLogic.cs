using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuLogic : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadSettingsMenu()
    {
        SceneManager.LoadScene("SettingsMenu");
    }
    public void LoadMainMenu()
    {
        Debug.Log("Loading main menu");
        SceneManager.LoadScene("MainMenu");
    }

    public void LaunchGame()
    {
        // This loads a specific scene
        SceneManager.LoadScene("TestScene");

        // This loads the next scene in the build queue
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
