using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;

//TODO: Either this is abstract and then making a different scriptable object with functions, or put
//that into their own classes.
public enum AbilityUseType { FreeAim, GroundTarget }
public enum AbilityType { Primary, Secondary }
public abstract class AbilityInfoSO : ScriptableObject
{
    [SerializeField] protected string abilityName = null;
    [SerializeField] protected float abilityDamage = 0f;
    [SerializeField] protected int abilityID = 0;
    [TextArea]
    [SerializeField] protected string toolTip = null;
    [SerializeField] protected float damageStatMultiplier = 0f;
    [SerializeField] protected Sprite abilityIcon = null;
    [SerializeField] protected float abilityCooldown = 0f;
    [SerializeField] protected GameObject abilityGameObject = null;
    [SerializeField] protected ParticleSystem abilityParticles = null;
    [SerializeField] protected float abilityRange = 0f;
    [SerializeField] protected float abilityCastTime = 0f;
    [SerializeField] protected AbilityUseType abilityUse;
    [SerializeField] protected AbilityType abilityType;

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
    public AbilityUseType AbilityUseType => abilityUse;
    public AbilityType AbilityType => abilityType;
}
