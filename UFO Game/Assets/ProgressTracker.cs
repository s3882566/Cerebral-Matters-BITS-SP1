using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressTracker : MonoBehaviour
{
    public int progress = 0;
    public int pointsToUnlockPortal = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateProgress(string humanType)
    {
        if (humanType.Equals("Adult"))
        {
            progress++;
            Debug.Log(progress);
            if (progress == pointsToUnlockPortal)
            {
                //unlock portal
            }
        } else if (humanType.Equals("Penalty")){
            if (progress > 0)
            {
                progress--;
            }
        }
    }
}
