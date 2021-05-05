using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class respawnManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public GameOverScreen GameOverScreen;

    // Start is called before the first frame update
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            //restart game
            //gameoverscreen.setup();
        }
    }
}


