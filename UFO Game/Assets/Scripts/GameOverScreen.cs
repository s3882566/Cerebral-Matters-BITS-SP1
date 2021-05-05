using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameOverScreen : MonoBehaviour
{
    public Text gameOverText;
    public string[] explodedText;
    public string[] timeOverText;

    bool gameHasEnded = false;

    public void EndGame(string loseCondition)
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            //restart game
            Setup(loseCondition);
        }
    }

    public void Setup(string loseCondition)
    {
        int randomNum = Random.Range(0,4);
        if (loseCondition.Equals("TimeOver"))
        {
            gameOverText.text = '"' + timeOverText[randomNum] +'"';
        } else if (loseCondition.Equals("Exploded"))
        {
            gameOverText.text = '"' + explodedText[randomNum] + '"';
        }
        gameObject.SetActive(true);
    }

    public void restartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void menuButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
