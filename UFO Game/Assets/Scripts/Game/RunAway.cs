using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunAway : MonoBehaviour
{

    private Rigidbody2D rb;
    public Transform target;
    public Transform ufo;
    public Vector3 change;
    public Vector3 Spawn;
    public float runRadius;
    public float moveSpeed;
    public Animator animator;

    public int issafe;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindWithTag("safe").transform;
        ufo = GameObject.FindWithTag("Player").transform;
        Spawn = transform.position;
        issafe = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        change = Vector3.zero;
        CheckDistance();
    }

    void CheckDistance()
    {
        if (Vector3.Distance(ufo.position, transform.position) <= runRadius)
        {
            Vector3 targetPosition = new Vector3(target.position.x, target.position.y, transform.position.z);

            Vector3 temp = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);

            temp.y = -8.08f;
            rb.MovePosition(temp);

            animator.SetFloat("Speed", Mathf.Abs(moveSpeed));
        }
        else if (Vector3.Distance(ufo.position, transform.position) >= runRadius)
        {
            Vector3 moveBack = Vector3.MoveTowards(transform.position, Spawn, moveSpeed * Time.deltaTime);

            rb.MovePosition(moveBack);
            
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("safe"))
        {
            issafe = 1;
            Debug.Log("safe");
        }
    }


}
