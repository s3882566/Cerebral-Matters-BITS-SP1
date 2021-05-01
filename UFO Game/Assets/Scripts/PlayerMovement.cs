using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float movement_scalar;

    public float max_speed;

    public float slowMovementModifier = 0.5f;
    private float slowedMovement;

    private Rigidbody2D rb;


    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {


        if (Input.GetButton("Fire1"))
        {
            slowedMovement = max_speed * slowMovementModifier;
            movePlayer(slowedMovement);
        } else
        {
            movePlayer(max_speed);
        }

        

    }

    void movePlayer(float movementSpeed)
    {
        float x_movement = Input.GetAxis("Horizontal");
        float y_movement = Input.GetAxis("Vertical");
        if (rb.velocity.magnitude < movementSpeed)
        {
            
            Vector3 movement = new Vector3(x_movement, y_movement);
            rb.AddForce(movement_scalar * movement);
        }
    }

   
}
