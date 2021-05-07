using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TractorBeam : MonoBehaviour
{

    public GameObject laserContainer;
    public Animator animator;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetButton("Fire1"))
        {
            laserContainer.SetActive(true);
            animator.SetTrigger("ActivateBeam");



        } else
        {
            laserContainer.SetActive(false);
        }
    }


}
