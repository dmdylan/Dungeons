using Cinemachine;
using Mirror;
using StateStuff;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking.Types;

public class PlayerController : PlayerStateMachine
{
    [SerializeField] private List<GameObject> playerCinemachineCameraObjects = null;
    [SerializeField] private Transform playerFollow = null;
    [SerializeField] private Transform playerLookAt = null;

    public CharacterController PlayerCharacterController { get; private set; } = null;
    public Camera PlayerCamera { get; private set; } = null;
    public List<GameObject> PlayerCinemachineCameraObjects => playerCinemachineCameraObjects;

    public override void OnStartLocalPlayer()
    {
        base.OnStartLocalPlayer();

        gameObject.name = "Player " + netId.ToString();

        PlayerCharacterController = GetComponent<CharacterController>();
        PlayerCamera = Camera.main;

        //TODO: Assigns the targets to disabled gameobjects. Need to enable the gameobjects otherwise
        //unity/cinemachine decides to swap camera to other play when someone connects.
        foreach (GameObject playerCameraObject in playerCinemachineCameraObjects)
        {
            if(playerCameraObject.TryGetComponent(out CinemachineFreeLook cinemachineFreeLook))
            {
                cinemachineFreeLook.m_Follow = playerFollow;
                cinemachineFreeLook.m_LookAt = playerLookAt;
            }
        }
    }
}
