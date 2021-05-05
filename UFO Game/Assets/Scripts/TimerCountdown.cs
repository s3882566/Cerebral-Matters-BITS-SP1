using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerCountdown : MonoBehaviour
{
    public GameObject textDisplay;
    public float timeLeft = 900f;
    public bool clock = false;

    public GameObject player;

    public GameOverScreen GameOverScreen;

    void Start()
    {
        UpdateTimer();
    }

    void FixedUpdate()
    {
        if(timeLeft > 0 && clock == false)
        {
            clock = true;
            StartCoroutine(TimerTake());
        } else if (timeLeft == 0)
        {
            //end game.
            Debug.Log("working");
            RespawnPlayer();
        }
    }

    IEnumerator TimerTake()
    {
        timeLeft -= 1;
        UpdateTimer();
        yield return new WaitForSeconds(1);
        clock = false;
    }

    void UpdateTimer()
    {
        int min = Mathf.FloorToInt(timeLeft / 60);
        int sec = Mathf.FloorToInt(timeLeft % 60);
        textDisplay.GetComponent<UnityEngine.UI.Text>().text = min.ToString("00") + ":" + sec.ToString("00");
    }

    void RespawnPlayer()
    {
        //disable character controlls.
        player.GetComponent<PlayerMovement>().enabled = false;
        player.GetComponent<TractorBeam>().enabled = false;
        //open up a respawn screen.
        GameOverScreen.EndGame("TimeOver");
    }
}
