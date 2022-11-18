using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorScript : MonoBehaviour
{
    Animator animator;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        animator.SetBool("IsGrounded", isGrounded);
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetBool("IsRunning", true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetBool("IsRunning", false);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetBool("IsRunningBack", true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetBool("IsRunningBack", false);
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
             animator.SetBool("IsJumping", false);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("IsJumping", true);
        }
    }
}
