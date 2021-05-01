using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbductionScript : MonoBehaviour
{
    public GameObject progressTracker;
    public GameObject HumanAbductionEffects;
    public GameObject ChildHumanAbductionEffects;
    public GameObject ElderlyAbductionEffects;
    public GameObject FemaleHumanAbductionEffects;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    } 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Adult"))
        {
            Debug.Log("working");
            progressTracker.GetComponent<ProgressTracker>().updateProgress("Adult");
            Instantiate(HumanAbductionEffects);
            Destroy(collision.gameObject);

        } else if (collision.gameObject.CompareTag("Child"))
        {
            Debug.Log("penalty");
            progressTracker.GetComponent<ProgressTracker>().updateProgress("Penalty");
            Instantiate(ChildHumanAbductionEffects);
            Destroy(collision.gameObject);
        } else if (collision.gameObject.CompareTag("Elderly"))
        {
            Debug.Log("penalty");
            progressTracker.GetComponent<ProgressTracker>().updateProgress("Penalty");
            Instantiate(ElderlyAbductionEffects);
            Destroy(collision.gameObject);
        } else if (collision.gameObject.CompareTag("FemAdult"))
        {
            Debug.Log("working");
            progressTracker.GetComponent<ProgressTracker>().updateProgress("Adult");
            Instantiate(FemaleHumanAbductionEffects); 
            Destroy(collision.gameObject);
        }

    }
}
