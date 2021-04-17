using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuLogic : MonoBehaviour
{

    public void LaunchGame()
    {
        // This loads a specific scene
        SceneManager.LoadScene("TestScene");

        // This loads the next scene in the build queue
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LaunchSettingsMenu()
    {
        SceneManager.LoadScene("SettingsMenu");
    }

    public void QuitGame()
    {
        Debug.Log("Debug: Quit button is working!");
        Application.Quit();
    }
}
