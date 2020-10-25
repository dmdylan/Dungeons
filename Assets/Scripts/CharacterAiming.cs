using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.InputSystem;
using UnityEngine.Animations;
using DG.Tweening;
using Mirror;

public class CharacterAiming : NetworkBehaviour
{
    [SerializeField] private float turnSpeed = 15f;
    [SerializeField] private Transform lookAt = null;
    [SerializeField] private Transform follow = null;
    CinemachineFreeLook freeLook;
    Camera playerCamera;

    public override void OnStartLocalPlayer()
    {
        base.OnStartLocalPlayer();
        playerCamera = Camera.main;
        freeLook = FindObjectOfType<CinemachineFreeLook>();

        freeLook.m_LookAt = lookAt;
        freeLook.m_Follow = follow;
    }

    private void FixedUpdate()
    {
        if (!isLocalPlayer) return;

        float yawCamera = playerCamera.transform.rotation.eulerAngles.y;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, yawCamera, 0), turnSpeed * Time.fixedDeltaTime);
    }
}
