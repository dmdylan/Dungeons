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
    private float velocityY; 
    [SerializeField] private float moveSpeed = 0f;
    [SerializeField] private float jumpHeight = 1f;
    [SerializeField] private float gravityMultiplier = 1f;


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

    //Move speed is the same regardles of the characters move direction
    //Might make it slower if they are moving backwards as opposed to forwards
    private void MoveCharacter()
    {
        if (!isLocalPlayer) return;

        //stop gravity pog
        if(characterController.isGrounded && velocityY < 0)
        {
            velocityY = 0;
        }

        //Makes sure the character is brought back to the ground and character controller is grounded
        velocityY += Time.fixedDeltaTime * Physics.gravity.y;

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
