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
    [SerializeField] private float minimumCameraDistance = 0f;
    [SerializeField] private float maximumCameraDistance = 10f;

    // Start is called before the first frame update
    void Start()
    {
        playerCamera = FindObjectOfType<CinemachineVirtualCamera>();
        transposer = playerCamera.GetCinemachineComponent<CinemachineOrbitalTransposer>();
    }

    private void Update()
    {
        Debug.DrawLine(transform.position, playerCamera.m_Follow.position, Color.red);
        Debug.Log(Vector3.Distance(playerCamera.transform.position, playerCamera.m_Follow.position));
    }

    //Change so it is taking a ray float distance to the follow target to gauge distance
    //Check if transposer values can be changed to adjust zoom.
    //possiby change the rotation of the look at object to rotate camera?
    //Can change rotation bias to change angle camera is looking while 

    private void OnMouseScroll(InputValue value)
    {
        var input = value.Get<Vector2>();

        if (Vector3.Distance(playerCamera.transform.position, playerCamera.m_Follow.position) <= minimumCameraDistance ||
            Vector3.Distance(playerCamera.transform.position, playerCamera.m_Follow.position) >= maximumCameraDistance)
            return; 
        
        Debug.Log(input);
             
        if(input.y > 0)
        {
            //DOTWEEN from current camera position towards player position?
            //playerCamera.transform.domo
            transposer.m_FollowOffset.z -= 1f;
            Debug.Log(playerCamera.m_LookAt.position);
        
        }
        else if(input.y < 0)
        {
            //playerCamera.m_Lens.FieldOfView += 10;
            Debug.Log("Back scroll");
        }

    }
}
