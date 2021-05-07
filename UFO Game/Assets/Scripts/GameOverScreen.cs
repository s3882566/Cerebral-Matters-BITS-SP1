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
        if (loseCondition.Equals("TimeOver"))
        {
            gameOverText.text = '"' + timeOverText[Random.Range(0, timeOverText.Length)] +'"';
        } else if (loseCondition.Equals("Exploded"))
        {
            gameOverText.text = '"' + explodedText[Random.Range(0, explodedText.Length)] + '"';
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
