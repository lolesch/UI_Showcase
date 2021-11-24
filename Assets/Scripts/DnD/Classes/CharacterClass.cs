using DnD.Enums;
using System.Collections.Generic;
using UnityEngine;

namespace DnD.Classes
{
    [CreateAssetMenu(fileName = "new ClassValues", menuName = "Character/ClassValuse", order = 1)]
    public class CharacterClass : ScriptableObject
    {
        [SerializeField] private ClassType classType;
        public ClassType ClassType => classType;

        [SerializeField] private Sprite classIcon;
        public Sprite ClassIcon => classIcon;

        //[SerializeField] private uint classLevel = 1u;

        [SerializeField] private Dice hitDice;
        public Dice HitDice => hitDice;

        public uint averageHitDiceRoll => (uint)Mathf.Ceil(((uint)HitDice + 1u) * .5f);

        public List<AbilityType> savingThrowProficiencies;

        //public List<ArmorType> armorProficiency;

        //public List<WeaponType> weaponProficiency;
    }
}