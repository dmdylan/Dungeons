using Cinemachine;
using Mirror;
using StateStuff;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

enum PlayerState { OutOfCombat = 0, InCombat = 1 }
public class PlayerController : PlayerStateMachine
{
    [SerializeField] private CinemachineFreeLook[] playerCinemachineCameras = null;
    [SerializeField] private Transform playerFollow = null;
    [SerializeField] private Transform playerLookAt = null;

    [SyncVar (hook = nameof(SetPlayerState))]
    private PlayerState playerState = PlayerState.OutOfCombat;

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
        //TODO: Throws null state in debug after client joins
        Debug.Log(State);
    }

    private void SetPlayerState(PlayerState oldState, PlayerState newState)
    {
        if (!isLocalPlayer) return;

        switch (newState)
        {
            case PlayerState.OutOfCombat:
                SetState(new OutOfCombat(this));
                break;
            case PlayerState.InCombat:
                SetState(new InCombat(this));
                break;
            default:
                break;
        }
    }

    private void OnBaseAttackOne()
    {
        if (!isLocalPlayer) return;

        if (state is InCombat) return;

        CmdSetState(PlayerState.InCombat);
    }

    private void OnBaseAttackTwo()
    {
        if (!isLocalPlayer) return;

        if (state is OutOfCombat) return;

        CmdSetState(PlayerState.OutOfCombat);
    }

    #endregion
   
    #region Server Side

    [Command]
    private void CmdSetState(PlayerState playerState)
    {
        this.playerState = playerState;
    }

    #endregion
}
