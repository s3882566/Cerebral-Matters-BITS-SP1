using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleMenuLogic : MonoBehaviour
{
    public void LoadMainMenu()
    {
        Debug.Log("Loading main menu");
        SceneManager.LoadScene("MainMenu");
    }
}
