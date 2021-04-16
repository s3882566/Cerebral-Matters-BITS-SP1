using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuLogic : MonoBehaviour
{

    public void launchGame()
    {
    SceneManager.LoadScene("TestScene");
    }


    public void goToSettingsMenu()
    {

    }

    public void quitGame()
    {
      Application.Quit();
    }
}
