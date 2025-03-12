using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement01 : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed;
    public float groundDrag;

    [Header("Ground Check")]
    public float playerHeight;
    public LayerMask Ground;
    public bool grounded;

    public Transform orientation;

    float Hinput;
    float Vinput;

    Vector3 moveDirection;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    private void PlayerInput()
    {
        Hinput = Input.GetAxisRaw("Horizontal");
        Vinput = Input.GetAxisRaw("Vertical");
    }

    private void MovePlayer()
    {
        moveDirection = orientation.forward * Vinput + orientation.right * Hinput;

        rb.AddForce(moveDirection.normalized * moveSpeed * 10f, ForceMode.Force);
    }

    private void SpeedControl()
    {
        Vector3 flatVelocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        //****** Limit Velocity ******

        if(flatVelocity.magnitude > moveSpeed)
        {
            Vector3 limitedVelocity = flatVelocity.normalized * moveSpeed;
            rb.velocity = new Vector3(limitedVelocity.x, rb.velocity.y, limitedVelocity.z);
        }
    }

    private void Update()
    {
        //****** Ground Check ******

        grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 1.0f, Ground);

        //****** Ground Check ******

        //****** Handle Drag ******

        if(grounded)
        {
            rb.drag = groundDrag;
        }
        else
        {
            rb.drag = 0;
        }

        //****** Handle Drag ******

        PlayerInput();
        SpeedControl();
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }
}
