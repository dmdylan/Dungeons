using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.InputSystem;
using UnityEngine.Animations;
using DG.Tweening;

public class CameraMovement : MonoBehaviour
{
    private CinemachineVirtualCamera playerCamera;
    private CinemachineTransposer transposer;

    // Start is called before the first frame update
    void Start()
    {
        playerCamera = FindObjectOfType<CinemachineVirtualCamera>();
        transposer = GetComponent<CinemachineTransposer>();
    }

    //Change so it is taking a ray float distance to the follow target to gauge distance
    //Check if transposer values can be changed to adjust zoom.
    //possiby change the rotation of the look at object to rotate camera?
    //Can change rotation bias to change angle camera is looking while moving

    private void OnMouseScroll(InputValue value)
    {
        var input = value.Get<Vector2>();

        if(input.y > 0)
        {
            //DOTWEEN from current camera position towards player position?
            transposer.m_FollowOffset.z -= 1f;
            Debug.Log(playerCamera.m_LookAt.position);

        }
        else if(input.y < 0)
        {
            //playerCamera.m_Lens.FieldOfView += 10;
            Debug.Log("Back scroll");
        }

        //Debug.Log(input);
    }
}
