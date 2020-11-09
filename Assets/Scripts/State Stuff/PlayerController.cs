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
    #region Variables

    [SerializeField] private CinemachineFreeLook[] playerCinemachineCameras = null;
    [SerializeField] private Transform playerFollow = null;
    [SerializeField] private Transform playerLookAt = null;

    #endregion

    #region Properties

    //Player state class cannot be sent over the network. Enum to change and track player state on sever
    //is sent to client to change internal state
    [SyncVar (hook = nameof(SetPlayerState))]
    private PlayerState playerState = PlayerState.OutOfCombat;
    public CharacterController PlayerCharacterController { get; private set; } = null;
    public Camera PlayerCamera { get; private set; } = null;
    public CinemachineFreeLook[] PlayerCinemachineCameras => playerCinemachineCameras;
    public PlayerInput PlayerInput { get; private set; } = null;
    public State State => state;

    #endregion

    #region Client Side

    public override void OnStartLocalPlayer()
    {
        base.OnStartLocalPlayer();

        //gameObject.name = "Player " + netId.ToString();
        PlayerCharacterController = GetComponent<CharacterController>();
        PlayerCamera = Camera.main;
        PlayerInput = GetComponent<PlayerInput>();

        foreach (CinemachineFreeLook playerCameraObject in playerCinemachineCameras)
        {
            playerCameraObject.m_Follow = playerFollow;
            playerCameraObject.m_LookAt = playerLookAt;     
        }

        SetState(new OutOfCombat(this));
    }

    [ClientCallback]
    private void Update()
    {
        Debug.Log($"{netIdentity} variable state: {playerState}");
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

    private void OnBaseAttackOne(InputValue value)
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
