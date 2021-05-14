using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketLol : MonoBehaviour
{
    public float speed;
    public bool left;
    public bool right;
    public bool up;
    public bool down;
    public bool triggered;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (triggered == true)
        {


            if (up == true)
            {
                transform.Translate(Vector3.up * Time.deltaTime * speed, Space.World);

            }
            else if (right == true)
            {
                transform.Translate(Vector3.right * Time.deltaTime * speed, Space.World);

            }

            else if (left == true)
            {
                transform.Translate(Vector3.left * Time.deltaTime * speed, Space.World);

            }

            else if (down == true)
            {
                transform.Translate(Vector3.down * Time.deltaTime * speed, Space.World);

            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        triggered = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

    }


}
