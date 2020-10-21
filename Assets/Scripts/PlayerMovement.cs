using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController characterController;
    private Vector2 movement;
    [SerializeField] private float moveSpeed = 0;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    private void FixedUpdate()
    {
        MoveCharacter();
    }

    private void OnMove(InputValue value)
    {
        movement = value.Get<Vector2>();     
    }

    private void MoveCharacter()
    {
        characterController.Move(new Vector3(movement.x, 0, movement.y) * Time.deltaTime * moveSpeed);
    }
}
