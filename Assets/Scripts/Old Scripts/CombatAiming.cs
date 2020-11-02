using UnityEngine;
using Mirror;

public class CombatAiming : NetworkBehaviour
{
    [SerializeField] private float turnSpeed = 15f;
    Camera playerCamera;

    public override void OnStartLocalPlayer()
    {
        base.OnStartLocalPlayer();
        playerCamera = Camera.main;
    }

    [ClientCallback]
    private void FixedUpdate()
    {
        if (!isLocalPlayer) return;

        float yawCamera = playerCamera.transform.rotation.eulerAngles.y;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, yawCamera, 0), turnSpeed * Time.fixedDeltaTime);
    }
}
