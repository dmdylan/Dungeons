using Cinemachine;
using Mirror;
using StateStuff;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PlayerController : PlayerStateMachine
{
    [SerializeField] private CinemachineFreeLook[] playerCinemachineCameras = null;
    [SerializeField] private Transform playerFollow = null;
    [SerializeField] private Transform playerLookAt = null;

    //public CombatAiming CombatAiming { get; private set; } = null;
    public CharacterController PlayerCharacterController { get; private set; } = null;
    public Camera PlayerCamera { get; private set; } = null;
    public CinemachineFreeLook[] PlayerCinemachineCameras => playerCinemachineCameras;
    public PlayerInput PlayerInput { get; private set; } = null;
    public State State => state;

    public override void OnStartLocalPlayer()
    {
        base.OnStartLocalPlayer();

        gameObject.name = "Player " + netId.ToString();

        PlayerCharacterController = GetComponent<CharacterController>();
        PlayerCamera = Camera.main;
        PlayerInput = GetComponent<PlayerInput>();
        //CombatAiming = GetComponent<CombatAiming>();

        //TODO: Assigns the targets to disabled gameobjects. Need to enable the gameobjects otherwise
        //unity/cinemachine decides to swap camera to other play when someone connects.
        foreach (CinemachineFreeLook playerCameraObject in playerCinemachineCameras)
        {
            playerCameraObject.m_Follow = playerFollow;
            playerCameraObject.m_LookAt = playerLookAt;     
        }

        //TODO: Does this need to be server side?
        SetState(new OutOfCombat(this));
    }

    [ClientCallback]
    private void Update()
    {
        Debug.Log(state);
    }

    private void OnLeftMouseButton()
    {
        if(!isLocalPlayer) return;

        if (state is InCombat) return;

        SetState(new InCombat(this));
    }

    private void OnRightMouseButton()
    {
        if (!isLocalPlayer) return;

        if (state is OutOfCombat) return;

        SetState(new OutOfCombat(this));
    }

    [Command]
    private void CmdSetState()
    {

    }
}
