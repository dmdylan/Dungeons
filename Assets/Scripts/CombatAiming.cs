using UnityEngine;
using Mirror;



//TODO: Move all this shit to own combat state. Idk about the variables.
public class CombatAiming : NetworkBehaviour
{
    [SerializeField] private float turnSpeed = 15f;
    [SerializeField] private bool isInCombat = true;
    Camera playerCamera;

    public override void OnStartLocalPlayer()
    {
        base.OnStartLocalPlayer();
        playerCamera = Camera.main;
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
