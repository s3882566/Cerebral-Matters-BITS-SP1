using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tut2 : MonoBehaviour
{

    public GameObject portal;
    public GameObject dialoguetr;


    public GameObject progresstracker;
    public GameObject beam;
    public GameObject humancontainer;
    public GameObject humancontainerclone;

    private bool abducted = false;
    private bool correctlyabducted = false;

    // Start is called before the first frame update
    void Start()
    {
        dialoguetr.GetComponent<DialogueTrigger>().TriggerDialogue(0);
        TrackAbduct();
    }

    // Update is called once per frame
    void Update()
    {
        if (progresstracker.GetComponent<ProgressTracker>().progress > 0)
        {
            abducted = true;
          
        }

        if (progresstracker.GetComponent<ProgressTracker>().progress == 10)
        {
            correctlyabducted = true; 

        }
    }

    void TrackAbduct()
    {
        StartCoroutine(timer());


    }

    IEnumerator timer()
    {
        yield return new WaitForSeconds(10);

     
        if (abducted is false)
        {
            dialoguetr.GetComponent<DialogueTrigger>().TriggerDialogue(1);
            TrackAbduct();
        }
        else if (abducted is true)
        {
            spawnNewHumans();
        }
    }

    void spawnNewHumans()
    {
        dialoguetr.GetComponent<DialogueTrigger>().TriggerDialogue(2);
        humancontainer.SetActive(true);
        StartCoroutine(newtimer());

    }

    IEnumerator newtimer()
    {
        yield return new WaitForSeconds(10);

        if (progresstracker.GetComponent<ProgressTracker>().progress < 10)
        {
            dialoguetr.GetComponent<DialogueTrigger>().TriggerDialogue(3);
            respawnHumans();
            

        }

        if (correctlyabducted is true)
        {
            openPortal();
        }

    }

    void respawnHumans()
    {
        Instantiate(humancontainerclone);
        Destroy(humancontainer);
        progresstracker.GetComponent<ProgressTracker>().progress = 2;
        StartCoroutine(newtimer());
    }



    void openPortal()
    {
        dialoguetr.GetComponent<DialogueTrigger>().TriggerDialogue(4);

        portal.GetComponent<portalScript>().UnlockPortal();

    }

    void openPortalWrong()
    {
        portal.GetComponent<portalScript>().UnlockPortal();

    }

}
