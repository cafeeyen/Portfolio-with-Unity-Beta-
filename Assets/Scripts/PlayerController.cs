using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed = 50f, gravity = 50.0f, jumpForce = 15.0f;

    private CharacterController charControl;
    private Vector3 moveDirection;

    void Start()
    {
        charControl = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (charControl.isGrounded)
        {
            moveDirection = transform.TransformDirection(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection *= speed;
        }
        moveDirection.y -= gravity * Time.deltaTime;
        charControl.Move(moveDirection * Time.deltaTime);
    }
}
