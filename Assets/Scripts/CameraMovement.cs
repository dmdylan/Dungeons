using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.InputSystem;
using UnityEngine.Animations;

public class CameraMovement : MonoBehaviour
{
    private CinemachineVirtualCamera playerCamera;

    // Start is called before the first frame update
    void Start()
    {
        playerCamera = FindObjectOfType<CinemachineVirtualCamera>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseScroll(InputValue value)
    {
        var input = value.Get<Vector2>();

        if(input.y > 0)
        {
            //DOTWEEN from current camera position towards player position?
            playerCamera.m_Lens.FieldOfView -= 10;
        }
        else if(input.y < 0)
        {
            playerCamera.m_Lens.FieldOfView += 10;
        }

        Debug.Log(input);
    }
}
