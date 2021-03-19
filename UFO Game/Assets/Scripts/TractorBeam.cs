using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TractorBeam : MonoBehaviour
{

    public GameObject laserContainer;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetButton("Fire1"))
        {
            laserContainer.SetActive(true);
        } else
        {
            laserContainer.SetActive(false);
        }
    }


}
