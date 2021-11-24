using DnD.Classes;
using DnD.Enums;
using DnD.Races;
using DnD.Rules;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace DnD.Characters
{
    [Serializable]
    [CreateAssetMenu(fileName = "new Character", menuName = "Character/new Character", order = 1)]
    public class Character : ScriptableObject
    {
        public event Action<Character> onValueChanged;

        public string characterName = "The Nameless";
        public Sprite characterImage;
        private const uint maxLevel = 20u;
        [SerializeField] [Range(1, maxLevel)] private uint characterLevel = 1u;

        [SerializeField] private uint currentHitPoints;  // the hit points during combat
        [SerializeField] private uint hitPoints;         // the hit point maximum at your current level
        [SerializeField] private CharacterRace characterRace;
        //[SerializeField] private RaceSubType characterSubRace;
        [SerializeField] private CharacterClass characterClass;
        //[SerializeField] private ClassSubType characterSubClass;

        //[SerializeField] private uint experiencePoints = 0u;
        [SerializeField] private uint characterAge;
        [SerializeField] private CharacterBackground background;
        [SerializeField] private List<Equipment> equipment;

        // Feats

        /// Abilities provide a quick description of every creature’s physical and mental characteristics
        private Dictionary<AbilityType, Ability> abilities = new Dictionary<AbilityType, Ability>(6)
        {
            {AbilityType.Strength, new Ability(AbilityType.Strength, 8) },
            {AbilityType.Dexterity, new Ability(AbilityType.Dexterity, 8) },
            {AbilityType.Constitution, new Ability(AbilityType.Constitution, 8) },
            {AbilityType.Intelligence, new Ability(AbilityType.Intelligence, 8) },
            {AbilityType.Wisdom, new Ability(AbilityType.Wisdom, 8) },
            {AbilityType.Charisma, new Ability(AbilityType.Charisma, 8) }
        };

        /* Strength
         * Physical power, natural athleticism, bodily power
         * Barbarian, fighter, paladin
         * Mountain dwarf(+2), Dragonborn(+2), Half-orc(+2), Human(+1)  */
        public Ability Strength => GetAbility(AbilityType.Strength);

        /* Dexterity
         * Physical agility, reflexes, balance, poise
         * Monk, ranger, rogue
         * Elf(+2), Halfling(+2), Forest gnome(+1), Human(+1)   */
        public Ability Dexterity => GetAbility(AbilityType.Dexterity);

        /* Constitution
         * Health/endurance, stamina, vital force
         * Everyone
         * Dwarf(+2), Stout halfling(+1), Rock gnome(+1), Half-orc(+1), Human(+1)   */
        public Ability Constitution => GetAbility(AbilityType.Constitution);

        /* Intelligence
         * Mental acuity, information recall, analytical skill, measuring reasoning and memory
         * Wizard
         * High elf(+1), Gnome(+2), Tiefling(+1), Human(+1) */
        public Ability Intelligence => GetAbility(AbilityType.Intelligence);

        /* Wisdom 
         * Perception, awareness, intuition, insight
         * Cleric, druid
         * Hill dwarf(+1), Wood elf(+1), Human(+1)  */
        public Ability Wisdom => GetAbility(AbilityType.Wisdom);

        /*Charisma
         * Personality, confidence, eloquence, leadership
         * Bard, sorcerer, warlock
         * Half-elf(+2), Drow(+1), Lightfoot halfling(+1), Dragonborn(+1), Tiefling(+2), Human(+1)  */
        public Ability Charisma => GetAbility(AbilityType.Charisma);

        public Ability GetAbility(AbilityType type)
        {
            abilities.TryGetValue(type, out Ability ability);
            return ability;
        }

        private uint CarryingCapacity => Strength.Score * 15; // * SizeModifier
        private uint PushDragLift => Strength.Score * 30; // * SizeModifier

        // TODO: Variant: Encumbrance -> slows you down and gives disadvantage on AbilityChecks using Strength, Dexterity, Constitution

        uint ProficiencyBonus => (uint)Mathf.Ceil((characterLevel + 4u) / 4u);

        public void SetCharacterName(string characterName) => this.characterName = characterName;

        public void SetCharacterImage(Sprite characterImage) => this.characterImage = characterImage;

        public void SetCharacterRace(CharacterRace charRace) => characterRace = charRace;

        public void SetCharacterClass(CharacterClass charClass) => characterClass = charClass;

        public void SetCharacterLevel(uint level) => characterLevel = Math.Min(maxLevel, level);

        public void SetCharacterAge(uint age) => this.characterAge = Math.Min(characterRace.AdultAge, age);

        public void AddExperiencePoints(uint xp)
        {
            // experiencePoints += xp;
            // if exceded threshold
            // LevelUp()
        }

        public void LevelUp()
        {
            characterLevel++;
            // spend your level point on one of the unlocked classes
            // add the features of that classLevel to your character
            // increase your base classes abilityScores
            // incrase your character's proficiency bonus?

            // calculate hitPoints
            hitPoints = (uint)(characterClass.HitDice + Constitution.Modifier) + characterClass.averageHitDiceRoll * characterLevel;
        }

        public void Rest()
        {

        }
    }

    public enum Equipment
    {
        // Trinkets
    }
}