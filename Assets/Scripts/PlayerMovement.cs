using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController characterController;
    private Camera playerCamera;
    private Vector2 movement;
    private Vector2 mousePosition;
    [SerializeField] private float moveSpeed = 0;

    [SerializeField] private float mouseSensitivity = 100.0f;
    [SerializeField] private float lowerClampAngle = 80.0f;
    [SerializeField] private float upperClampAngle = 20f;

    private float rotY = 0.0f; // rotation around the up/y axis
    private float rotX = 0.0f; // rotation around the right/x axis

    // Start is called before the first frame update
    void Start()
    {
        //Cursor.visible = false;
        //Cursor.lockState = CursorLockMode.Locked;
        characterController = GetComponent<CharacterController>();
        playerCamera = Camera.main;

        Vector3 rot = transform.localRotation.eulerAngles;
        rotY = rot.y;
        rotX = rot.x;
    }

    private void FixedUpdate()
    {
        MoveCharacter();
    }

    private void Update()
    {
        RotateCharacter();
        Debug.Log(mousePosition);
    }

    private void OnMove(InputValue value)
    {
        movement = value.Get<Vector2>();     
    }

    private void MoveCharacter()
    {
        //use input from new input system
        var movementDirection = new Vector3(movement.x, 0, movement.y);
        
        //translate it into local coordinates instead of world
        movementDirection = transform.TransformDirection(movementDirection);
        
        //multiply it by move speed and deltatime
        movementDirection = movementDirection * moveSpeed * Time.deltaTime;
        
        characterController.Move(movementDirection);
    }

    private void OnMousePosition(InputValue value)
    {
        mousePosition = value.Get<Vector2>();
    }

    //maybe link the character rotation to the aim of the 3rd person camera
    private void RotateCharacter()
    {
        //float mouseX = mousePosition.x;
        //float mouseY = -mousePosition.y;
        //
        //rotY += mouseX * mouseSensitivity * Time.deltaTime;
        //rotX += mouseY * mouseSensitivity * Time.deltaTime;
        //
        //rotX = Mathf.Clamp(rotX, upperClampAngle, lowerClampAngle);
        //
        //Quaternion localRotation = Quaternion.Euler(rotX, rotY, 0.0f);
        //transform.rotation = localRotation;

        //Vector3 mousePos = new Vector3(mousePosition.x, mousePosition.y, 0);
        //mousePos = playerCamera.ScreenToWorldPoint(mousePos);
        //Vector2 direction = new Vector2(mousePos.x - transform.position.x, mousePos.y - transform.position.y);
        //transform.up = direction;
    }
}
