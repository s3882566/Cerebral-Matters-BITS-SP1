using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionAnim : MonoBehaviour
{
    public Animator animator;
    void OnCollisionEnter2D(Collision2D collision)
    {
        animator.SetTrigger("Collide");
        
    }
}
