using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressTracker : MonoBehaviour
{
    public int progress = 0;
    public int pointsToUnlockPortal = 10;

    public GameObject portal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (progress >= pointsToUnlockPortal)
        {
            portal.GetComponent<portalScript>().portalUnlocked = true;
        } else
        {
            portal.GetComponent<portalScript>().portalUnlocked = false;
        }
    }

    public void updateProgress(string humanType)
    {
        if (humanType.Equals("Adult"))
        {
            progress += 2;
            Debug.Log(progress);

        } else if (humanType.Equals("Penalty")){
            if (progress > 0)
            {
                progress -= 2;
            }
        }
    }
}
