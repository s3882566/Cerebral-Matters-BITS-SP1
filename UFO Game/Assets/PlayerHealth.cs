using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private int Health;
    private bool isDead;
    public GameObject Explosion;

    // Start is called before the first frame update
    void Start()
    {
        Health = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead == true)
        {
            Instantiate(Explosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Health--;

        if(Health < 1)
        {
            isDead = true;
            Debug.Log("Dead");
        }
    }
}
