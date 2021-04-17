using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuLogic : MonoBehaviour
{

    public void launchGame()
    {
        // This loads a specific scene
        // SceneManager.LoadScene("TestScene");

        // This loads the next scene in the build queue
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void goToSettingsMenu()
    {

    }

    public void quitGame()
    {
        Debug.Log("Debug: Quit button is working!");
        Application.Quit();
    }
}
