using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCombatController : NetworkBehaviour
{
    //TODO: Need a way to grab all the abilities from the player ability SO (depends on class), find which ones are currently active,
    //and add them to a list which can be accessed here to pass into player input
    //Could be done through separate struct 
    public MageAbilities MageAbilities;

    public override void OnStartLocalPlayer()
    {
        base.OnStartLocalPlayer();
    }

    //Use input value float to change when actions are called because button interaction
    //is set to press and release
    private void OnBaseAttackOne(InputValue value)
    {
        if (!isLocalPlayer) return;

        if (MageAbilities.mageAbilites[0].IsChargeAbility == false)
            if (value.Get<float>() == 0f)
                StartCoroutine(MageAbilities.mageAbilites[0].Use());
    }

    [Command]
    private void CmdOnBaseAttackOne()
    {

    }
}
