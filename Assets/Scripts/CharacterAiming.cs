using UnityEngine;
using Cinemachine;
using Mirror;

public class CharacterAiming : NetworkBehaviour
{
    [SerializeField] private float turnSpeed = 15f;
    //[SerializeField] private Transform lookAt = null;
    //[SerializeField] private Transform follow = null;
    [SerializeField] private bool isInCombat = false;
    //CinemachineFreeLook[] freeLook;
    Camera playerCamera;
    

    public override void OnStartLocalPlayer()
    {
        base.OnStartLocalPlayer();
        playerCamera = Camera.main;
        //freeLook = FindObjectsOfType<CinemachineFreeLook>();
        //
        ////TODO: Move the camera assign to different script. Maybe player setup script or something.
        ////Could also make the cameras part of the player prefab and directly assign in editor.
        //foreach(CinemachineFreeLook camera in freeLook)
        //{
        //    camera.m_LookAt = lookAt;
        //    camera.m_Follow = follow;
        //}
    }

    private void FixedUpdate()
    {
        if (!isLocalPlayer) return;

        if (isInCombat.Equals(true))
        {
            float yawCamera = playerCamera.transform.rotation.eulerAngles.y;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, yawCamera, 0), turnSpeed * Time.fixedDeltaTime);
        }
    }
}
