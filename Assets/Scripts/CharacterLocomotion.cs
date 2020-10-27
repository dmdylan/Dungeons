﻿using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterLocomotion : NetworkBehaviour
{
    private Animator animator;
    private CharacterController characterController;
    private Vector2 movement;
    private float velocityY;
    private float turnSmoothVelocity;
    private float currentSpeed;
    private float speedSmoothVelocity;
    Transform cameraT;

    [SerializeField] private bool debug = false;
    [SerializeField] private float moveSpeed = 0f;
    [SerializeField] private float jumpHeight = 1f;
    [SerializeField] private float gravity = -12f;
    [SerializeField] private float gravityMultiplier = 1f;
    [SerializeField] private float speedSmoothTime = .1f;
    [SerializeField] private float turnSmoothTime = .1f;

    [Range(0, 1)]
    [SerializeField] private float airControlPercent = 0f;

    public override void OnStartLocalPlayer()
    {
        base.OnStartLocalPlayer();
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        cameraT = Camera.main.transform;
        animator = GetComponent<Animator>();
        characterController = GetComponent<CharacterController>();
    }

    private void FixedUpdate()
    {
        if (!isLocalPlayer) return;

        if (debug.Equals(false))
            CombatMovement();
        else
            OutOfCombatMove();
    }

    //Move speed is the same regardles of the characters move direction
    //Might make it slower if they are moving backwards as opposed to forwards
    private void CombatMovement()
    {
        if (!isLocalPlayer) return;

        //stop gravity pog
        if(characterController.isGrounded && velocityY < 0)
        {
            velocityY = 0;
        }

        //Makes sure the character is brought back to the ground and character controller is grounded
        velocityY += Time.fixedDeltaTime * gravity;

        //use input from new input system
        var movementDirection = new Vector3(movement.x, velocityY, movement.y);

        //translate it into local coordinates instead of world
        movementDirection = transform.TransformDirection(movementDirection);

        //multiply it by move speed and deltatime
        movementDirection = movementDirection * moveSpeed * Time.fixedDeltaTime;

        //TODO: Take animation out of movement script?
        animator.SetFloat("InputX", Mathf.Round(movement.x));
        animator.SetFloat("InputY", Mathf.Round(movement.y));
        
        characterController.Move(movementDirection);
    }

    void OutOfCombatMove()//, bool running)
    {
        if (movement != Vector2.zero)
        {
            float targetRotation = Mathf.Atan2(movement.x, movement.y) * Mathf.Rad2Deg + cameraT.eulerAngles.y;
            transform.eulerAngles = Vector3.up * Mathf.SmoothDampAngle(transform.eulerAngles.y, targetRotation, ref turnSmoothVelocity, GetModifiedSmoothTime(turnSmoothTime));
        }

        float targetSpeed = moveSpeed * movement.magnitude; //((running) ? runSpeed : walkSpeed) * inputDir.magnitude;
        currentSpeed = Mathf.SmoothDamp(currentSpeed, targetSpeed, ref speedSmoothVelocity, GetModifiedSmoothTime(speedSmoothTime));

        velocityY += Time.fixedDeltaTime * gravity;
        Vector3 velocity = transform.forward * currentSpeed + Vector3.up * velocityY;

        animator.SetFloat("InputX", Mathf.Round(movement.x));
        animator.SetFloat("InputY", Mathf.Round(movement.y));

        characterController.Move(velocity * Time.fixedDeltaTime);
        currentSpeed = new Vector2(characterController.velocity.x, characterController.velocity.z).magnitude;

        if (characterController.isGrounded)
        {
            velocityY = 0;
        }
    }

    float GetModifiedSmoothTime(float smoothTime)
    {
        if (characterController.isGrounded)
        {
            return smoothTime;
        }

        if (airControlPercent == 0)
        {
            return float.MaxValue;
        }

        return smoothTime / airControlPercent;
    }

    #region InputCommands
    private void OnMove(InputValue value)
    {
        if (!isLocalPlayer) return;

        movement = value.Get<Vector2>();     
    }

    private void OnJump()
    {
        if (!isLocalPlayer) return;

        if (characterController.isGrounded)
        {
            float jumpVelocity = Mathf.Sqrt(Physics.gravity.y * jumpHeight * gravityMultiplier);
            velocityY = jumpVelocity;
        }
    }
    #endregion
}
