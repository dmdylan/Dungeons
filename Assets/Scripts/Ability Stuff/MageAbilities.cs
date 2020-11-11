using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[CreateAssetMenu(menuName = ("Abilities/Mage Abilities"), fileName =("Mage Abilities"))]
public class MageAbilities : ScriptableObject
{
    public List<AbilityTemplateObject> mageAbilites = new List<AbilityTemplateObject>();
}
