using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;

//TODO: Add enum for which class ability belongs to
public enum AbilityUseType { FreeAim, GroundTarget, Buff }
public enum AbilitySlot { Primary, Secondary }
public enum AbilityType { BaseAbility, Talent }

public abstract class AbilityTemplateObject : ScriptableObject
{
    [SerializeField] private string abilityName = null;
    [SerializeField] private float abilityDamage = 0f;
    [SerializeField] private int abilityID = 0;
    [TextArea]       
    [SerializeField] private string toolTip = null;
    [SerializeField] private float damageStatMultiplier = 0f;
    [SerializeField] private Sprite abilityIcon = null;
    [SerializeField] private float abilityCooldown = 0f;
    [SerializeField] private GameObject abilityGameObject = null;
    [SerializeField] private ParticleSystem abilityParticles = null;
    [SerializeField] private float abilityRange = 0f;
    [SerializeField] private float abilityCastTime = 0f;
    [SerializeField] private bool isChargeAbility = false;
    [SerializeField] private AbilityUseType abilityUseType = default;
    [SerializeField] private AbilitySlot abilitySlot = default;
    [SerializeField] private AbilityType abilityType = default;

    public abstract IEnumerator Use();

    public string AbilityName => abilityName;
    public float AbilityDamage => abilityDamage;
    public int AbilityID => abilityID;
    public string ToolTip => toolTip;
    public float DamageStatMultiplier => damageStatMultiplier;
    public Sprite AbilityIcon => abilityIcon;
    public float AbilityCooldown => abilityCooldown;
    public GameObject AbilityGameObject => abilityGameObject;
    public ParticleSystem AbilityParticles => abilityParticles;
    public float AbilityRange => abilityRange;
    public float AbilityCastTime => abilityCastTime;
    public bool IsChargeAbility => isChargeAbility;
    public AbilityUseType AbilityUseType => abilityUseType;
    public AbilitySlot AbilitySlot => abilitySlot;
    public AbilityType AbilityType => abilityType;
}
