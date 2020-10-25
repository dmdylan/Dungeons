using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterLocomotion : NetworkBehaviour
{
    private Animator animator;
    private CharacterController characterController;
    private Vector2 movement;
    [SerializeField] private float moveSpeed = 0;


    public override void OnStartLocalPlayer()
    {
        base.OnStartLocalPlayer();
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        animator = GetComponent<Animator>();
        characterController = GetComponent<CharacterController>();
    }

    private void FixedUpdate()
    {
        if (!isLocalPlayer) return;

        MoveCharacter();
    }

    private void OnMove(InputValue value)
    {
        movement = value.Get<Vector2>();     
    }

    //Move speed is the same regardles of the characters move direction
    //Might make it slower if they are moving backwards as opposed to forwards
    private void MoveCharacter()
    {
        if (!isLocalPlayer) return;

        //use input from new input system
        var movementDirection = new Vector3(movement.x, 0, movement.y);
        
        //translate it into local coordinates instead of world
        movementDirection = transform.TransformDirection(movementDirection);
        
        //multiply it by move speed and deltatime
        movementDirection = movementDirection * moveSpeed * Time.deltaTime;

        animator.SetFloat("InputX", Mathf.Round(movement.x));
        animator.SetFloat("InputY", Mathf.Round(movement.y));
        characterController.Move(movementDirection);
    }
}
