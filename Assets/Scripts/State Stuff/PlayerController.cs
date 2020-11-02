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

    #region Client Side

    public override void OnStartLocalPlayer()
    {
        base.OnStartLocalPlayer();

        gameObject.name = "Player " + netId.ToString();

        PlayerCharacterController = GetComponent<CharacterController>();
        PlayerCamera = Camera.main;
        PlayerInput = GetComponent<PlayerInput>();

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
        if (!isLocalPlayer) return;

        if (state is InCombat) return;

        CmdSetInCombatState();
    }

    private void OnRightMouseButton()
    {
        if (!isLocalPlayer) return;

        if (state is OutOfCombat) return;

        CmdSetOutOfCombatState();
    }

    #endregion

    #region Server Side


    //TODO: Cannot set states from server because the state class cannot be saved and sent across the network
    //Either need to make own type that can be, figure something else out, or just keep it client side.
    [Command]
    private void CmdSetInCombatState()
    {
        SetState(new InCombat(this));
        //TargetSetPlayerState(new InCombat(this));
    }

    [Command]
    private void CmdSetOutOfCombatState()
    {
        SetState(new OutOfCombat(this));
    }

    //[TargetRpc]
    //private void TargetSetPlayerState(State state)
    //{
    //    SetState(state);
    //}

    #endregion
}
