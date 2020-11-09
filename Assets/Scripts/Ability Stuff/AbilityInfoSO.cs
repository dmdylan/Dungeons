using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

//TODO: Either this is abstract and then making a different scriptable object with functions, or put
//that into their own classes.
public abstract class AbilityInfoSO : ScriptableObject
{
    [SerializeField] private string abilityName = null;
    [SerializeField] private float abilityDamage = 0f;
    [SerializeField] private int abilityID = 0;
    [SerializeField] private TextField toolTip = null;
}
