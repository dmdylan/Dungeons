using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using System;

[CreateAssetMenu(menuName = ("Abilities/TestMageAbility"))]
public class TestMageAbility : AbilityTemplateObject
{
    public override IEnumerator Use()
    {
        GameObject iceLanceObject = Instantiate(this.AbilityGameObject);
        //Cannot spawn objects without an active server. Most likely has to be called from a network behavior.
        NetworkServer.Spawn(iceLanceObject);
        Debug.Log("Ability Used!");
        yield return null;
    }
}
