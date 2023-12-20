using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] bool isJumping;
    [SerializeField] float jumpForce;
    [SerializeField] Animator anim;
    [SerializeField] GameObject legKick;
    public Rigidbody2D rig;

    public void Jump()
    {
        anim.Play("kick");
        
        if(!isJumping)
        {
            //ig.velocity = Vector2.up * jumpForce;
            rig.velocity = new Vector2(-1, jumpForce);
            isJumping = true;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if(collision.gameObject.layer == 6)
        {
            isJumping = false;
        }
    }

    private void Gravity()
    {

    }
}
