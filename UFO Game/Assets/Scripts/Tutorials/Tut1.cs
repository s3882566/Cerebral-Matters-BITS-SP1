using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tut1 : MonoBehaviour
{

    public GameObject portal;
    public GameObject dialoguetr;
    

    public GameObject ufo;


     private bool hasmoved = false;

    // Start is called before the first frame update
    void Start()
    {
        dialoguetr.GetComponent<DialogueTrigger>().TriggerDialogue(0);
        TrackMovement();
    }

    // Update is called once per frame
    void Update()
    {
        if (ufo.GetComponent<Rigidbody2D>().velocity.magnitude > 0)
        {
            hasmoved = true;
        }
    }

    void TrackMovement()
    {
        StartCoroutine(timer());
        

    }

    IEnumerator timer()
    {
        yield return new WaitForSeconds(10);

        if(hasmoved is true)
        {
            dialoguetr.GetComponent<DialogueTrigger>().TriggerDialogue(1);
            Finish();
        }
        else if (hasmoved is false)
        {
            dialoguetr.GetComponent<DialogueTrigger>().TriggerDialogue(2);
            TrackMovement();
        }
    }

    void Finish()
    {
        portal.GetComponent<portalScript>().UnlockPortal();
    }
}
