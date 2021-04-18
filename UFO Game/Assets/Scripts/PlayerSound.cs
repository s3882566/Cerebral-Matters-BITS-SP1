using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSound : MonoBehaviour
{
    private Rigidbody2D rb;
    private AudioSource Audio1;
    public AudioSource Audio11 { get => Audio1; set => Audio1 = value; }
    public AudioSource Audio21 { get => Audio2; set => Audio2 = value; }

    private AudioSource Audio2;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.magnitude > 0)
        {
            // Player is moving
        }
    }
}
