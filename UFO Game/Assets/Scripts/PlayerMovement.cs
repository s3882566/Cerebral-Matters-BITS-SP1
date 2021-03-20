using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float movement_scalar;

    public float max_speed;

    private Rigidbody2D rb;

    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (Input.GetButton("Fire1"))
        {

        }
        else
        {
            float x_movement = Input.GetAxis("Horizontal");
            float y_movement = Input.GetAxis("Vertical");
            if (rb.velocity.magnitude < max_speed)
            {
                Vector3 movement = new Vector3(x_movement, y_movement);
                rb.AddForce(movement_scalar * movement);
            }
        }

            
    }

   
}
