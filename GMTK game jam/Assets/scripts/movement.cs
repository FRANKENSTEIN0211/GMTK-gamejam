using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public charactercontroller2d controller;
    public Animator animator;
    float HorizontalMove = 0f;
    public float runspeed =40.0f;
    bool jump = false;
    bool crouch = false;
    // Update is called once per frame
    void Update()
    {
        HorizontalMove=Input.GetAxisRaw("Horizontal")*runspeed;
        animator.SetFloat("speed", Mathf.Abs(HorizontalMove));
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("isjumping", true);
        }
    }

    public void OnLanding()
    {
        animator.SetBool("isjumping", false);
    }
    void FixedUpdate()
    {
        controller.Move(HorizontalMove*Time.fixedDeltaTime,crouch, jump);
        jump = false;
    }
}
