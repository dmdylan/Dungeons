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
        Debug.Log("Ability Used!");
        yield return null;
    }
}
