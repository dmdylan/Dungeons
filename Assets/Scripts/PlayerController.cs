using Cinemachine;
using Mirror;
using StateStuff;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : PlayerStateMachine
{
    [SerializeField] private GameObject[] playerCinemachineCameraObjects = null;
    [SerializeField] private Transform playerFollow = null;
    [SerializeField] private Transform playerLookAt = null;

    public CharacterController PlayerCharacterController { get; private set; } = null;
    public Camera PlayerCamera { get; private set; } = null;
    public GameObject[] PlayerCinemachineCameraObjects => playerCinemachineCameraObjects;
    public PlayerInput PlayerInput { get; private set; } = null;

    public event Action OnEnterCombat;

    public override void OnStartLocalPlayer()
    {
        base.OnStartLocalPlayer();

        gameObject.name = "Player " + netId.ToString();

        PlayerCharacterController = GetComponent<CharacterController>();
        PlayerCamera = Camera.main;
        PlayerInput = GetComponent<PlayerInput>();

        //TODO: Assigns the targets to disabled gameobjects. Need to enable the gameobjects otherwise
        //unity/cinemachine decides to swap camera to other play when someone connects.
        foreach (GameObject playerCameraObject in playerCinemachineCameraObjects)
        {
            if (playerCameraObject.TryGetComponent(out CinemachineFreeLook cinemachineFreeLook))
            {
                cinemachineFreeLook.m_Follow = playerFollow;
                cinemachineFreeLook.m_LookAt = playerLookAt;
            }
        }

        //TODO: Does this need to be server side?
        SetState(new OutOfCombat(this));
    }

    [ClientCallback]
    private void Update()
    {
        Debug.Log(state);
    }

    private void OnMainMouseButtons()
    {
        if(!isLocalPlayer) return;

        SetState(new InCombat(this));
    }
}
