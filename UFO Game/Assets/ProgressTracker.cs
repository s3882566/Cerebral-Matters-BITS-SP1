using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressTracker : MonoBehaviour
{
    public int progress = 0;
    public int pointsToUnlockPortal = 10;

    public GameObject portal;

    public Image progressBar;

    public GameObject portalOpenedText;

    public void updateProgress(string humanType)
    {
        if (humanType.Equals("Adult")  && progress < pointsToUnlockPortal)
        {
            progress += 2;
            Debug.Log(progress);
            progressBar.rectTransform.sizeDelta = new Vector2(progress * 10, 100);
            progressBar.color = new Color(0, 255, 255, 255);
            if (progress == pointsToUnlockPortal)
            {
                portal.GetComponent<portalScript>().portalUnlocked = true;
                portalOpenedText.SetActive(true);
            }

        } else if (humanType.Equals("Penalty")){
            if (progress > 0)
            {
                progress -= 2;
                progressBar.rectTransform.sizeDelta = new Vector2(progress * 10, 100);
                progressBar.color = new Color(255, 0, 0, 255);
                portal.GetComponent<portalScript>().portalUnlocked = false;
                portalOpenedText.SetActive(false);
            }
        }
    }
}
